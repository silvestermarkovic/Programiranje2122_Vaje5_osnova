using System;
using System.Collections.Generic;

namespace NalogaMnozice
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: 1.1  Ustvarite mnozico
            //ustvarite ustrezno podatovno strukturo in jo imenujte mnozica1
            HashSet<string> seznam1 = new HashSet<string> { "Test1", "Test2", "Test3" };
            //Dodajte elemente Marko, Primoz, Zak, Pak, Mak  v mnozica1
            seznam1.Add("Marko");
            seznam1.Add("Primoz");
            seznam1.Add("Zak");
            seznam1.Add("Pak");
            seznam1.Add("Mak");
            //naredite 1.2 (spodaj)
            //izpišite množico elementov
            izpisSeznam(seznam1, "Seznam1");

            //TODO: 1.3
            //ustvarite ustrezno podatovno strukturo mnozica2
            HashSet<string> seznam2 = new HashSet<string>();
            //Dodajte elemente Matej, Ivan, Lan, Marko, Jaka, Makk  v mnozica2
            seznam2.Add("Matej");
            seznam2.Add("Ivan");
            seznam2.Add("Lan");
            seznam2.Add("Marko");
            seznam2.Add("Jaka");
            seznam2.Add("Mak");

            //izpišite mnozica
            izpisSeznam(seznam2, "Seznam2");

            //TODO: 1.4
            //ustvarite mnozicaUnija, naj predstavlja množico unije elemenov mnozica1 in mnozica2
            //izpišite množico mnozicaUnija
            HashSet<string> seznamUnija = new HashSet<string>(seznam1);
           
            seznamUnija.UnionWith(seznam2);
            izpisSeznam(seznam1, "Seznam1");
            izpisSeznam(seznam2, "Seznam2");
            izpisSeznam(seznamUnija, "Unija");

            //TODO: 1.5
            //ustvarite mnozicaPresek, naj predstavlja množico preseka elemenov mnozica1 in mnozica2
            //izpišite množico mnozicaPresek
            HashSet<string> seznamPresek = new HashSet<string>(seznam1);
            seznamPresek.IntersectWith(seznam2);
            izpisSeznam(seznamPresek, "Presek");

            // After using Remove method 
            Console.WriteLine("Total number of elements present" +
                                " in myhash: {0}", seznam1.Count);


            seznam1.Remove("Mak");


            seznamUnija.RemoveWhere(elt => elt.Length < 4);
            izpisSeznam(seznamUnija, "Elementi dolžina več kot 4 znaki");

            // Before using Remove method 
            Console.WriteLine("Total number of elements present" +
                                " in myhash: {0}", seznam1.Count);

            // Remove all elements from HashSet 
            // Using Clear method 
            seznam1.Clear();
            Console.WriteLine("Total number of elements present" +
                                 " in myhash:{0}", seznam1.Count);


        }

        //TODO: 1.2 metoda, ki izpiše množico, ki je podana kot vhodni parameter,
        //kot parameter je podan tudi naziv izpisa (to je prva vrsta izpisa, da vemo kaj izpisujemo)
        //izpis naj bo desno poravnan
        //Mnozic1
        //  Marko
        //    Mak
        //    Pak
        static void izpisSeznam(HashSet<String> pseznam, string naziv)
        {

            Console.WriteLine( );
            Console.WriteLine( $"{naziv,15}");
            foreach (var ele in pseznam)
            {
                Console.WriteLine($"{ele,15}" );
            }
        }
    }
}
