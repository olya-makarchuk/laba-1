using System;
using System.Collections.Generic;
using System.Linq;

namespace laba_1a
{
    public class ID
    {
        public string PartName { get; set; }
        public int PartId { get; set; }

        public override string ToString()
        {
            return "ID: " + PartId + "   Name: " + PartName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tЗавдання 1");

            List<ID> parts = new List<ID>();

            parts.Add(new ID() { PartName = "Ноутбук Microsoft", PartId = 1234 });
            parts.Add(new ID() { PartName = "Windows", PartId = 1634 }); ;
            parts.Add(new ID() { PartName = "Ноутбук Huawei", PartId = 1334 });
            parts.Add(new ID() { PartName = "MacBook", PartId = 1434 });
            parts.Add(new ID() { PartName = "Телефон Realme", PartId = 1444 });
            parts.Add(new ID() { PartName = "Телефон Samsung", PartId = 1564 });
            parts.Add(new ID() { PartName = "Google", PartId = 1731 });



            Console.WriteLine();
            foreach (ID aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine();
            Console.WriteLine("Введiть назву:");
            string nameid = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"\nFind: Part where name contains \"{nameid}\":  ");

            var resultid = parts.FindAll(part => part.PartName.Contains(nameid));
            foreach(var b in resultid)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine( );


            ////////////////////////////////////////

            Console.WriteLine("\tЗавдання 2");
            Console.WriteLine();

            var numb = new Dictionary<string, string>();
            numb.Add("a", "a");
            numb.Add("b", "3");
            numb.Add("3", "3d");
            numb.Add("7", "7");
            numb.Add("5", "4");
            numb.Add("f", "f");

            var keys_1 = numb.Keys;
            Console.WriteLine("Початковi данi:");
            foreach(string i in keys_1)
            {
                Console.WriteLine($"{i} - {numb[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Однаковi значення пари ключ-значення: ");
            foreach (string i in keys_1)
            {
                if (i == numb[i])
                {
                    Console.WriteLine($"{i} - {numb[i]}");
                }
            }
            Console.WriteLine();


            ////////////////////////////////////////
            

            Console.WriteLine("\tЗавдання 3");
            Console.WriteLine();

            var prod = new Dictionary<string, int>();
            prod.Add("Сир", 200);
            prod.Add("Хлiб", 25);
            prod.Add("Горiхи", 170);
            prod.Add("Картопля", 12);
            prod.Add("Зелень", 150);
            prod.Add("Селера", 35);
            prod.Add("Помiдори", 65);
            prod.Add("Перець", 105);

            List<int> list_v = new List<int>();
            List<string> list_k = new List<string>();
            Console.WriteLine("Список товарiв");
            foreach (var name in prod)
            {
                Console.WriteLine($"{name.Key} - {name.Value}");
                list_v.Add(name.Value);
                list_k.Add(name.Key);
            }

            Console.WriteLine();
            Console.WriteLine("Товари дорожче 100 гривень");
            
            var resmax = list_v.Where(i => i > 100).OrderBy(i => i);
            foreach (var a in resmax)
            {
                var resname = list_k.Where(i => prod[i] == a);
                foreach (var i in resname)
                {
                    Console.WriteLine($"{i} - {a}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Товари дешевше 100 гривень");
            var resmin = list_v.Where(i => i < 100).OrderBy(i => i);
            foreach (var a in resmin)
            {
                var resname = list_k.Where(i => prod[i] == a);
                foreach (var i in resname)
                {
                    Console.WriteLine($"{i} - {a}");
                }
            }

        }
    }
}
