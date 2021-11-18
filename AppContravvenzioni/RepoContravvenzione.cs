using AppContravvenzioni.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContravvenzioni
{
    class RepoContravvenzione : IRepository<Contravvenzione>
    {
        //Stringa connessione
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Contravvenzioni1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Contravvenzione> GetAll()
        {
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "select * from Contravvenzione c join Vigile v on c.MatricolaVigile=v.Matricola";

                    SqlDataReader reader = command.ExecuteReader();

                    List<Contravvenzione> multe = new List<Contravvenzione>();

                    while (reader.Read())
                    {
                        var nv = (int)reader["NumeroVerbale"];
                        var luogo = (string)reader["Luogo"];
                        var data = (DateTime)reader["Data"];
                        var mVigile = (string)reader["MatricolaVigile"];
                        var motociclo = ConvertFromDBVal<string>(reader["MotocicloTarga"]);
                        var auto = ConvertFromDBVal<string>(reader["AutomobileTarga"]);
                        var nomeVigile = (string)reader["Nome"];
                        var cognomeVigile = (string)reader["Cognome"];

                        Vigile v = new Vigile();
                        v.Matricola = mVigile;
                        v.Nome = nomeVigile;
                        v.Cognome = cognomeVigile;

                        Contravvenzione c = new Contravvenzione();
                        if (motociclo != null)
                        {
                            Motociclo m = new Motociclo();
                            m.Targa = motociclo;
                            c = new Contravvenzione(nv, luogo, data, v, m );
                        }
                        if (auto != null)
                        {
                            Automobile a = new Automobile();
                            a.Targa = auto;
                            c = new Contravvenzione(nv, luogo, data, v, a );
                        }
                        multe.Add(c);
                    }
                    return multe;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Contravvenzione>();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Contravvenzione>();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        public static T ConvertFromDBVal<T>(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return default(T); // returns the default value for the type
            }
            else
            {
                return (T)obj;
            }
        }
    }
}
