using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Eleks_lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person{Name = "Rostyk"},
                new Person{Name = "Romko"},
                new Person{Name = "Vovan"}
            };

            PeopleEnum obj = new PeopleEnum(persons);  
            
            foreach(var item in obj._people)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    public class PeopleEnum : IEnumerable
    {
        public Person[] _people;
        public int _position = -1;

        public PeopleEnum(Person[] people)
        {
            _people = people;
        }

        public IEnumerator GetEnumerator()
        {
                for (int i = 0; i < _people.Length; i++)
                {
                    yield return _people[i];
                }
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}


