using System;

namespace csharp_hianyzas_app
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //teszt futtatás
            Console.WriteLine(hetnapja(4, 6));
            Console.WriteLine(hetnapja(1, 1));
            Console.WriteLine(hetnapja(12, 4));
            Console.WriteLine(hetnapja(6, 4));
        }

        /**
         * 4. feladat
         * 
         * Ezt az egész függvényt feladat leírás definiálja, én csak elmagyarázom miért van így!
         * 
         * String a visszatérési érték, és két egész a bemeneti paraméter, ahogy azt a feladat kéri
         */
        private static String hetnapja(int honap, int nap)
        {
            //String tömbben tároljuk a hét napjait (lehetne akár lista is, de nekünk elég a tömb)
            String[] napnev = {"vasarnap", "hetfo", "kedd", "szerda", "csutortok", "pentek", "szombat"};

            //a hónapok napjai tömbben letárolva, az előzőhöz pedig hozzáadjuk mindig az aktuálisat
            //pl. január 31 napos, február 28 (mert nincs szökőév), tehát 31+28=59
            //  következőnél ugyanígy, március 31 napos, tehát az előző értékhez hozzáadjuk, 59+31=90
            // a végén kijön, hogy 366, azaz ennyi nap van egy évben
            int[] napszam = {0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 335};

            //napszam[honap - 1]: a bemeneti paraméterként kapott hónap alapján kikeressük, hogy az melyik hónapban vagyunk épp a tömb alapján, és az a hónap az évben hányadik nappal kezdődik
            //      január a nulladik nappal kezdődik, február a 31-kel, ez mindig az előző hónap utolsó napját jelenti
            //+ nap: hozzáadjuk a bemeneti paraméterként kapott nap számot
            //MOD azt jelenti, hogy MODULO, azaz maradék keresés, ez a % jellel való osztást jelenti, az mindig a maradékot adja vissza
            //  MOD ezt jegyezd meg, hogy maradékos osztást jelent!
            //      pl: 10%7=3, mert a 10-et maradékosan elosztjuk a 7-tel, az eredmény senkit nem érdekel hányszor van meg benne, csak hogy 3 a maradék
            //így aztán kijön, hogy a hét hányadik napjáról van szó
            int napsorszam = (napszam[honap - 1] + nap) % 7;

            //a napnev tömbből pedig nagyon egyszerűen csak kikeressük az előbb megkapott érték alapján, hogy melyik napról van szół
            String hetnapja = napnev[napsorszam];

            return hetnapja;
        }
    }
}