using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate void Del(string str);

        static void Main(string[] args)
        {
            Del notifyDel = new Del(Notify);
            notifyDel("Rostyslav");

            Del notifyDel2 = Notify;
            notifyDel2("Romko");

            Del notifyDel3 = delegate (string name)//З анонімним методом
            {
                Console.WriteLine($"GOODBYE {name}!!!");
            };
            notifyDel3("Vovvan");

            Del notifyDel4 = name => { Console.WriteLine("Hello, {0}", name); };//З лямбда виразом
            notifyDel4("Bogdan");

            Del composeDel = notifyDel3 + notifyDel4;
            composeDel("Composed Delegate");

            Console.WriteLine();

            composeDel = composeDel - notifyDel3;
            composeDel("Composed Delegate 2");

        }
    

        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }

        static void Notify(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }
    }
}
