using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Person
    {
        private string namn;
        private int ålder;
        private string adress;
        //Konstruktor som tar tre parametrar

        public Person(string n, int å, string a)
        {
            namn = n;
            ålder = å;
            adress = a;
        }
        public Person() { }  //konstruktor som inte gör någontong
        public string Namn //Egenskap för datamedlemmen namn
        {
            get { return namn;  }
            set { namn = value; }
        }

        public int Ålder
        {
            get { return ålder; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Fel! Åldern måste vara positiv");
                    ålder = 0;
                }
                else
                    ålder = value;
            }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
    }
}
