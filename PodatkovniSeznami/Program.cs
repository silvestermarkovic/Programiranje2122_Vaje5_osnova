using System;
using System.Collections.Generic;

namespace PodatkovniSeznami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Namen naloge je spoznati podatkovne strukture začnite spodaj 3.1

            //TODO. 3.2
            //ustvarite seznam, elementi so tipa Kupec
            //koda 1. vrstica
            LinkedList<Kupec> seznam = new LinkedList<Kupec>();

            //TODO: 3.5 Dodajte kupce v seznam
            //Dodajte 3 obicajne kupce, 2 pogodbea in 2 extra
            //koda
            dodajNaSeznam(new Kupec() { naziv = "Ime", extra = false, pogodba = false }, seznam);
            dodajNaSeznam(new Kupec() { naziv = "Ime2", extra = false, pogodba = false }, seznam);
            dodajNaSeznam(new Kupec() { naziv = "ExtraDona", extra = true, pogodba = false }, seznam);
            dodajNaSeznam(new Kupec() { naziv = "Ime3", extra = false, pogodba = false }, seznam);
            dodajNaSeznam(new Kupec() { naziv = "ImePogodba1", extra = false, pogodba = true }, seznam);
            dodajNaSeznam(new Kupec() { naziv = "ImePogodba2", extra = false, pogodba = true }, seznam);
            dodajNaSeznam(new Kupec() { naziv = "ExtraDona", extra = true, pogodba = false }, seznam);
            dodajNaSeznam(new Kupec() { naziv = "Ime5", extra = false, pogodba = false }, seznam);


            //TODO: 3.6 Kliči metodo izpisi seznam
            //izpisi seznam, kliči metodo
            izpisSeznam(seznam);

            //kličite metodo kupecObdelan (2 do 3x) in izpišite seznam
            kupecObdelan(seznam);
            kupecObdelan(seznam);

            izpisSeznam(seznam);

            dodajNaSeznam(new Kupec() { naziv = "ImeDodatni", extra = true, pogodba = false }, seznam);
            dodajNaSeznam(new Kupec() { naziv = "ImePogodba", extra = false, pogodba = false }, seznam);
            izpisSeznam(seznam);

        }


        //TODO: 3.3 ustvari metodo dodajNaSeznam
        //metoda doda, kupca na seznam, na točno določeno mesto, na podlagi pravil
        //če je extra nazačetek seznama
        //če je pogodba na drugo mesto
        public static void dodajNaSeznam(Kupec pkupec, LinkedList<Kupec> pseznam)
        {
            if (pkupec.extra == true)
            {
                pseznam.AddFirst(pkupec);
                return;
            }
            else if (pkupec.pogodba == false || pseznam.Count < 1)
            {
                pseznam.AddLast(pkupec);
                return;
            }
            else
            {
                //Pogodben dodamo na drugo mesto
                pseznam.AddAfter(pseznam.First, pkupec);

            }

        }


        //TODO: 3.4 ustvari metodo kupecObdelan
        //metoda kupecObdelan  (odstrani prvi element), kot parameter prejme seznam
        //namig ena vrstica
        public static void kupecObdelan(LinkedList<Kupec> pseznam)
        {
            pseznam.RemoveFirst();
        }


        //TODO: 3.5 Izpisite seznam
        //ustvarite metodo, ki izpiše seznam elementov Kupec, ki ga dobi kot parameter
        public static void izpisSeznam(LinkedList<Kupec> pseznam)
        {
            foreach (Kupec kup in pseznam)
            {
                Console.WriteLine($"{kup.naziv}");
            }
        }
    }

    //TODO: 3.1. ustvarite razred Kupec
    // naziv, pogodba, extra (get/set)
    //razred Kupec
    class Kupec
    {
        public string naziv { get; set; }
        public bool pogodba { get; set; }
        public bool extra { get; set; }

    }


}
