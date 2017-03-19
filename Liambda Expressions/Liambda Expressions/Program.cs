using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liambda_Expressions
{
    class Program
    {
        public delegate int Pow(int val);
        public delegate int LambdaDelegate(int a);

        static void Main(string[] args)
        { 
            #region Одиночні лямбда-вирази
            //Етапи використання Лямбда виразів
            //delegate int Pow(int change)                  //1.Визначення делегата сумісного з лябмда-виразом
            //Pow pow = change => change * change          //2.Створення делегата, якому присвоюється лямбда-вираз
            //Console.WriteLine(pow(10);-->100                  //3.Виеористання виразу, яке відбуваєття при зверненні до делегата
            Pow pow = value => value * value;
            Console.WriteLine(pow(10));
            Console.Read();
            #endregion

            Console.Clear();

            #region
            LambdaDelegate lamda_del = a => ++a;//<--@

            int step = 1;
            int finish = 12;

            while(step <= finish)
            {
                Console.WriteLine("Бегун на {0} километре к финишу. Осталось километров {1}", step, finish - step);
                step = lamda_del(step);//цей степ що в дужках йде до @
            }
            #endregion

            #region Блочні лямбда-вирази
            Pow pow2 = value =>
            {
                if (value != 0)
                   return value* value;
                return 0;
            };
            Console.WriteLine(pow2(3));//Ця трійка йде по першого велью потім перевіряється чи вона не нуль і тоді підноситься до квадрату
            #endregion

        }
    }
}
