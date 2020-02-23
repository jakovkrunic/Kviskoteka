using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviskoteka
{
    class DetaljiIgre
    {
        private static int[] tezina_prvog;
        private static int[] tezina_drugog;

        private static int bodovi_igraca;
        private static int bodovi_prvog;
        private static int bodovi_drugog;

        private static bool iskoristen_kvisko_igrac;
        private static bool iskoristen_kvisko_prvi;
        private static bool iskoristen_kvisko_drugi;

        private static bool neiskoristen_kvisko_igrac;
        private static bool neiskoristen_kvisko_prvi;
        private static bool neiskoristen_kvisko_drugi;

        private static int faza;

        public static Pocetna pocetna;

        /*
         * IGRA: 
         * 0 - ABC pitalica
         * 1 - Asocijacije
         * 2 - Detekcija
         * 3 - Zavrsna
         */
        public static void tezinaPrvog(int tezina, int igra)
        {
            tezina_prvog[igra] = tezina;
        }

        public static int TezinaPrvog(int igra)
        {
            return tezina_prvog[igra];
        }

        public static void tezinaDrugog(int tezina, int igra)
        {
            tezina_drugog[igra] = tezina;
        }

        public static int TezinaDrugog(int igra)
        {
            return tezina_drugog[igra];
        }

        public static int BodoviIgraca()
        {
            return bodovi_igraca;
        }

        public static int BodoviPrvog()
        {
            return bodovi_prvog;
        }

        public static int BodoviDrugog()
        {
            return bodovi_drugog;
        }

        public static void DodajBodove(Form form, int igrac, int prvi, int drugi)
        {
            form.Close();

            bodovi_igraca += igrac;
            bodovi_prvog += prvi;
            bodovi_drugog += drugi;

            if (faza == 0)
            {
                if (bodovi_igraca >= 70) neiskoristen_kvisko_igrac = true;
                if (bodovi_prvog >= 70) neiskoristen_kvisko_prvi = true;
                if (bodovi_drugog >= 70) neiskoristen_kvisko_drugi = true;
            }

            ++faza;

            new Bodovi(neiskoristen_kvisko_igrac).Show();
        }

        public static bool IskoristenKviskoIgrac()
        {
            return iskoristen_kvisko_igrac;
        }

        public static bool IskoristenKviskoPrvi()
        {
            return iskoristen_kvisko_prvi;
        }

        public static bool IskoristenKviskoDrugi()
        {
            return iskoristen_kvisko_drugi;
        }

        public static void IskoristiKviskoIgrac()
        {
            neiskoristen_kvisko_igrac = false;
            iskoristen_kvisko_igrac = true;
        }

        public static void IskoristiKviskoPrvi()
        {
            neiskoristen_kvisko_prvi = false;
            iskoristen_kvisko_prvi = true;
        }

        public static void IskoristiKviskoDrugi()
        {
            neiskoristen_kvisko_drugi = false;
            iskoristen_kvisko_drugi = true;
        }

        public static int Igra()
        {
            return faza;
        }

        public static void reset(Pocetna _pocetna)
        {
            pocetna = _pocetna;
            bodovi_igraca = 0;
            bodovi_prvog = 0;
            bodovi_drugog = 0;

            iskoristen_kvisko_igrac = false;
            iskoristen_kvisko_prvi = false;
            iskoristen_kvisko_drugi = false;

            neiskoristen_kvisko_igrac = false;
            neiskoristen_kvisko_prvi = false;
            neiskoristen_kvisko_drugi = false;

            tezina_prvog = new int[4];
            for (int i = 0; i < 4; ++i) tezina_prvog[i] = 1;
            tezina_drugog = new int[4];
            for (int i = 0; i < 4; ++i) tezina_drugog[i] = 1;

            faza = 0;
        }
    }
}
