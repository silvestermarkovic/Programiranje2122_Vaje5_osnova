using System;
using System.Collections.Generic;
using System.Text;

namespace NalogaSingleton
{

    //TODO: 2.1. Ustvarite razred Strezniki
    //razred ima naslednje lastnosti (property):
    //javno ime (get/set)           string
    //javno ip (get/set)            string
    //javno stKlicev (get/set)      int
    //javno obremenitev (get/set)   double  trenutna obremenitev
    //javno ObremenitevMax (get/set) double maksimalna obremenitev streznika
    //koda razreda


    //TODO: 2.2. ustvarite sealed class Razporeditelj (odkomentirajte predpriplajvljeno osnovo)
    public sealed class Razporeditelj

    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization

        //POMEMBNO!!!!
        private static readonly Razporeditelj _instance = new Razporeditelj();


        //TODO: 2.3. ustvarite privatni seznam _strezniki tipa Strezniki (get/set) 
        //koda
        //TODO: 2.3A. ustvarite spremenljivko sprozenAlarm tipa bool privzena vrednost = false
        //koda

        //Pazite: konstruktor je 'private'
        //TODO: 2.4. uredite konstruktor, ki bo napolnil _strezniki s podatki o 3-5 streznikih
        //StKlicev naj bo vedno enako 0, ObremenitevMax naj bo med 100 in 200
        private Razporeditelj()
        {
            //vasa koda
            //pomoc  _strezniki = new List<Streznik>... seznam strežnikov
        }



        //vrne _instance, ki ob incalizaciji kliče konstruktor, ki je private
        //POMEMBNO!!!!
        public static Razporeditelj VrniRazporeditelj()
        {
            return _instance;
        }

        //predpripravljeni razporeditelj nalog na streznike

        /*odkomentirajte!!!!!!!!!!!!!!!!!!!!!!2222
        public Streznik NaslednjiStreznik(int pteza)
        {
             
            while (true)
            {
                //TODO: 2.5. spremenite tako, da bo obremenilo, najmanj obremenjeni strežnik  (obremenitev/obremenitveMax
                //tu je kot pomoč koda, ki vrne prvi strežnik, ki je prost (pteza + obremenitev <= obremenitevMax)
                //pazite, da lahko strežnik z manjmanjšo obremenitvijo sploh sprejme podano obremenitev (pteza)

                for (int i = 0; i < _strezniki.Count; i++)
                {
                    if (_strezniki[i].VServisu == false && _strezniki[i].ObremenitevMax >= (pteza + _strezniki[i].Obremenitev))
                    {
                        return _strezniki[i];
                    }
                }
                //če trenutno ni kapacitet počakamo 0.5s, če se sporstijo kapacitete
                Console.WriteLine("Vse kapacitete zasedene, čakamo!");
                Thread.Sleep(500);
            }
        }
        //odkomentirajte!!!!!!!!!!!!!!!!!!!!!!2222
        //*/
    }

}
