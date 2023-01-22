using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juneOOP2_exercises
{
    public class MagicArray<T>
    {
        private T[] data;// = new int[3];
        private int position;

        public MagicArray()
        {
            data = new T[3];
            position = 0;
        }

        public void Add(T value)
        {
            if (position == 3)
            {
                position = 0;
            }

            data[position] = value;
            position++;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var element in data)
            {
                result += element.ToString();
            }

            return result;
        }
    }
}
