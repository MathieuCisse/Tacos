using System;
using System.Collections.Generic;
using System.Linq;

namespace Tacos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que souhaitez-vous faire ? ");
            Console.WriteLine("1/ Liste");
            Console.WriteLine("2/ Ajout");
            Console.WriteLine("q/ quitter");

            string key = null;

            do
            {
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        List();
                        break;
                    case "2":
                        Add();
                        break;
                }
            } while (key != "q");

        }


        public static void List()
        {
            var context = new TacosContext();
            var liste = context.Tacos.ToList();
            foreach (var l in liste)
            {
                Console.WriteLine($"{l.Id} : {l.Name}");
            }
        }

        public static void Add()
        {
            Console.WriteLine("Saisir le nom du tacos");
            var context = new TacosContext();
            var name = Console.ReadLine();
            var tacos = new Tacos()
            {
                Name = name
            };
            context.Tacos.Add(tacos);
            context.SaveChanges();
        }
    }
}
