using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Security;
using System.Resources;
using System.Data;
using System.Management;
using System.Threading;
using System.IO;//!!!!!!! DirectoryInfo

namespace Anonimous_Methods
{
    class Program
    {
        public delegate void Anonym();
        public delegate void Anonym2(int start, int finish);

        static void Main(string[] args)
        {
            #region анонімні методи без параметрів
            Anonym anonym = delegate
            {
                DirectoryInfo dir = new DirectoryInfo("E:\\");
                foreach(DirectoryInfo d in dir.GetDirectories())//Виводить назву кожної папки(диркеторії)
                {
                    Console.WriteLine(d.Name);
                }
            };

            anonym();
            #endregion
            #region анонімні методи з параметрами

            Anonym2 anon2 = delegate (int a, int b)
            {
                for(int i = a; i <= b; i++)
                {
                    Console.WriteLine("Спортсмен на {0} километре. До финиша {1}", i, b - i);
                }
                Console.Read();
            };



            anon2(1, 12);
            Console.Read();
            #endregion  
        }
    }
}
