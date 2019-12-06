using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        private static object personllista;
        private static object m;

        public static void Main()
        {
            List<Person> personlista = new List<Person>();

            Person p = new Person("Luke Skywalker", 20, "Moisture farm 1138, Tatooine");
            personlista.Add(p);
            personlista.Add(new Person("Lando Calrissian", 28, "Cloud City, Bespin"));
            personlista.Add(new Person("Marko Popara", 19, "Växjö, Sverige"));
            personlista.Add(new Person("BMW 328Ci (E46)", 1999, "Germany"));
            personlista.Add(new Person("Honda Civic (D15Z6)", 1999, "Japan"));
            foreach (Person element in personlista)
            {

                Console.WriteLine(element.Namn);
                Console.WriteLine(element.Ålder);
                Console.WriteLine(element.Adress);
                Console.WriteLine("____________________");
            }
        }

        private static Person NewMethod()
        {
            return new Person("Luke skywalker", 20, "Moisture farm 1138, Tatooine");
        }
    }
}
