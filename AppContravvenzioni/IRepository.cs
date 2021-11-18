using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContravvenzioni
{
    interface IRepository<T>
    {
        public List<T> GetAll();

    }
}
