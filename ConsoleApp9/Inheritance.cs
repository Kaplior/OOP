using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Human
    {
        private string name;
        private int age;

        public void print(string name, int age)
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }

    class Tom : Human
    {
        private string job;
        public void print(string name, int age, string job)
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(job);
        }
    }

    class MainPro
    {
        public static void Main(String[] args)
        {
            string name = "Lol";
            string job = "IT";
            int age = 5;
            Tom h = new Tom();
            h.print(name, age, job);
            Console.ReadLine();
        }
    }
}