using System;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kupec> kupci = new List<Kupec>();
            kreirajSeznamKupci(kupci);
            List<Dokument> dokumenti = new List<Dokument>();
            kreirajSeznamDokument(dokumenti);

            //TODO 1.1 ustvarite Linq poizvedbo, ki bo vrnila vse kupce iz Avstije ali Nemčije, vrnite samo naziv kup.naziv
            // var poizv1 = ....

            //izpišite uporabite Extension  IzpisiElemente

            //TODO 1.1a
            //ustvarite poizvedbo v method obliki



            //TODO 1.2. dodajte kupca 21,Kupec21,Celovec,Avstrija
            //še 1x naredite poizvedbo (z izpisom), kaj opazite?



            //TODO 1.3. ustvarite seznam, ki bo vrnil kupce, ki NISO iz Slovenije, 
            //razvstite jih po državi, kraju in potem po nazivu, vrnite elemente od 6 do 10 mesta


            //TODO 1.4: ustvarite poizvedbo, ki bo vrnila, kupce razporejene po dolzini naziva kraja (naracsajoce) in nazivu
            //izpisejo naj se polja naziv, drzava,kraj in dolzina kraja (length) 



            //TODO 1.5.: prikazite vse dokumenta kupcev, ki imajo država različna od Italija
            //razvrstite po znesku naracajoce


            //TODO 1.6. naredite poizvedvo, ki bo vrnila seštevek po kupcih (brez Join)
            //izpiše naj ID_kupca, StRacunov (count), ZnesekRacunov


            //TODO 1.7: z uporabo join in group
            //izpišite državo, število računov, seštek računov po državah, razvrščeno po seštevku računov

        }




        public static void kreirajSeznamKupci(List<Kupec> pseznam)
        {


            dodajNaSeznamKupca(new Kupec(1, "Kupec1", "Novo mesto", "Slovenija"), pseznam);
            dodajNaSeznamKupca(new Kupec(2, "Kupec2", "Slovenj Gradec", "Slovenija"), pseznam);
            dodajNaSeznamKupca(new Kupec(3, "Kupec3", "Celje", "Slovenija"), pseznam);
            dodajNaSeznamKupca(new Kupec(4, "Kupec4", "Maribor", "Slovenija"), pseznam);
            dodajNaSeznamKupca(new Kupec(5, "Kupec5", "Gradec", "Avstrija"), pseznam);
            dodajNaSeznamKupca(new Kupec(6, "Kupec6", "Dunaj", "Avstrija"), pseznam);
            dodajNaSeznamKupca(new Kupec(7, "Kupec7", "Linz", "Avstrija"), pseznam);
            dodajNaSeznamKupca(new Kupec(8, "Kupec8", "Trst", "Italija"), pseznam);
            dodajNaSeznamKupca(new Kupec(9, "Kupec9", "Rim", "Italija"), pseznam);
            dodajNaSeznamKupca(new Kupec(10, "Kupec10", "Torino", "Italija"), pseznam);
            dodajNaSeznamKupca(new Kupec(11, "Kupec11", "Milano", "Italija"), pseznam);
            dodajNaSeznamKupca(new Kupec(12, "Kupec12", "Pariz", "Francija"), pseznam);
            dodajNaSeznamKupca(new Kupec(13, "Kupec13", "London", "Velika Britanija"), pseznam);
            dodajNaSeznamKupca(new Kupec(14, "Kupec14", "Liverpool", "Velika Britanija"), pseznam);
            dodajNaSeznamKupca(new Kupec(15, "Kupec15", "Bonn", "Nemčija"), pseznam);
            dodajNaSeznamKupca(new Kupec(16, "Kupec16", "Berlin", "Nemčija"), pseznam);
            dodajNaSeznamKupca(new Kupec(17, "Kupec17", "Zagreb", "Hrvaška"), pseznam);
            dodajNaSeznamKupca(new Kupec(18, "Kupec18", "Zadar", "Hrvaška"), pseznam);
            dodajNaSeznamKupca(new Kupec(19, "Kupec19", "Madrid", "Španija"), pseznam);
            dodajNaSeznamKupca(new Kupec(20, "Kupec20", "Barcelona", "Španija"), pseznam);

        }

        public static void dodajNaSeznamKupca(Kupec pkupec, List<Kupec> pseznam)
        {
            pseznam.Add(pkupec);
        }


        public static void kreirajSeznamDokument(List<Dokument> pseznam)
        {
            var _rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                dodajNaSeznamDokument(new Dokument("Racun" + i, _rnd.Next(1, 20), _rnd.Next(100, 1000)), pseznam);
            }

        }
        public static void dodajNaSeznamDokument(Dokument pdokuemnt, List<Dokument> pseznam)
        {
            pseznam.Add(pdokuemnt);
        }
    }
}
