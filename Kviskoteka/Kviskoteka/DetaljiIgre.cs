using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void DodajBodove(int igrac, int prvi, int drugi)
        {
            bodovi_igraca += igrac;
            bodovi_prvog += prvi;
            bodovi_drugog += drugi;
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

        public static void reset()
        {
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
            tezina_drugog = new int[4];
        }
    }
}
