using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        public int age = 10;
        public string name = "Ali";
        public float cgpa = 3.3f;
        public double sgpa = 3.66;
        public char section = 'E';
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //abc
            Program pg = new Program();
            ArrayList arrayone = new ArrayList();
            Console.WriteLine(arrayone);
            arrayone.Add(pg.age);
            arrayone.Add(pg.name);
            arrayone.Add(pg.cgpa);
            arrayone.Add(pg.sgpa);
            arrayone.Add(pg.section);
            Console.WriteLine(arrayone);



        }
    }
}
