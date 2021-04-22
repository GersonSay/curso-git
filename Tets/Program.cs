using System;
using System.Collections.Generic;

namespace Tets
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 19;

            //Console.WriteLine(testes.Teste(x, y));
            //testes.Triple(ref x); // operação ref n pode ser feita dentro do writeline.
            //Console.WriteLine(x);



            //------------Listas---------

            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "maria", "alex" };

            list.Add("maria");
            list.Add("Alex");
            list.Add("bob");
            list.Add("Anna");

            list.Insert(2, "marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("list count: " + list.Count);


        }
    }
}
