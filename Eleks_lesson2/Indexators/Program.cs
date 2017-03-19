using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexators
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection mc = new MyCollection();

            for(int i = 0; i<mc.LengthOO; i++)
            {
                Console.Write(mc[i] + " ");
            }
        }
    }

    public class MyCollection
    {
        private int[] numbers = {1,2,3,4,5,6,7,78 };

        public int LengthOO { get { return numbers.Length; } }

        public int this[int i]
        {
            get { return numbers[i]; }
            set { numbers[i] = value; }
        }
    }
}
