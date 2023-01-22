using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juneOOP2_exercises
{
    public class DataStore<T>
    {
        public T Data { get; set; }

        public void Set(T data)
        {
        }

        public T Get()
        {
            return Data;
        }

        /*
         *
         */
    }
}
