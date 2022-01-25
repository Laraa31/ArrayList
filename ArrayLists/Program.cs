using System;
using System.Collections;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            int broj = 5;
            string nesto = "C# i .NET";
            for(int i = 0; i <= 100; i++)
            {
                lista.Add(i);
            }

            lista.Add(broj);
            lista.Add(nesto);

            Console.WriteLine("Broj elemenata liste: " + lista.Count + "\n");

            Console.WriteLine("Ispis svih elemenata\n");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Element br." + (i + 1));
                Console.WriteLine(lista[i] + "\n");
            }
            Console.WriteLine("\n");

            lista.Insert(1, "Programiranje");

            Console.WriteLine("Ispis svih elemenata nakon insert-a");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Element br." + (i + 1));
                Console.WriteLine(lista[i] + "\n");
            }


            Console.WriteLine("Ispis elemenata po danom uvjetu");

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].ToString() == "Programiranje")
                {
                    Console.WriteLine("Element br." + (i + 1));
                    Console.WriteLine(lista[i] + "\n");
                }
                try
                {
                    if (Convert.ToInt32(lista[i]) == 5)
                    {
                        Console.WriteLine("Element br." + (i + 1));
                        Console.WriteLine(lista[i] + "\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine (e.Message);
                }
            }

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.Contains(5))
                {
                    lista.Remove(5);
                }
            }
            Console.WriteLine("Ispis svih elemenata nakon brisanja 5");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Element br." + (i + 1));
                Console.WriteLine(lista[i] + "\n");
            }

            int pozicija = lista.IndexOf(97);
            Console.WriteLine("Pozicija broja 97 je: "+pozicija);

            if(pozicija >= 0)
            {
                lista.RemoveAt(97);
            }

            Console.WriteLine("Ispis svih elemenata nakon Remove-a");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Element br." + (i + 1));
                Console.WriteLine(lista[i] + "\n");
            }

            Console.ReadKey();
        }
    }
}
