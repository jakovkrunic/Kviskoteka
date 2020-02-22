using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kviskoteka
{
    class FileManager
    {

        public String[] abcPitalica()
        {
            int lineCount = File.ReadLines(@"potrebno/abc.txt").Count();
            int broj_pitanja = lineCount / 4;
            Random rnd = new Random();
            List<int> iskoristeno = new List<int>();
            String[] izlaz = new String[40];

            for (int i = 0; i < 10; ++i)
            {
                int pitanje = rnd.Next(broj_pitanja);
                if (iskoristeno.Contains(pitanje))
                {
                    --i;
                    continue;
                }
                iskoristeno.Add(pitanje);

                int brojac = 0;
                int interni = 0;

                string line;

                TextReader file = new StreamReader(@"potrebno/abc.txt", System.Text.Encoding.Default, true);

                while ((line = file.ReadLine()) != null && interni < 4)
                {
                    if (brojac < pitanje * 4) { ++brojac; continue; }
                    if (interni < 4) { izlaz[interni] = line; ++interni; }
                }

            }

            return izlaz;
        }
        public String[] asocijacija()
        {
            int lineCount = File.ReadLines(@"potrebno/asocijacije.txt").Count();
            int broj_igri = lineCount / 21;
            Random rnd = new Random();
            int igra = rnd.Next(broj_igri);
            String[] izlaz = new String[21];

            int brojac = 0;
            int interni = 0;

            string line;

            TextReader file = new StreamReader(@"potrebno/asocijacije.txt", System.Text.Encoding.Default, true);

            while ((line = file.ReadLine()) != null)
            {
                if (brojac < igra*21) { ++brojac; continue; }
                if (interni < 21) { izlaz[interni] = line; ++interni; }
                if (interni == 21) break;
            }

            return izlaz;
        }

        public String[] detekcija()
        {
            int lineCount = File.ReadLines(@"potrebno/detekcije.txt").Count();
            int broj_igri = lineCount / 42;
            Random rnd = new Random();
            int igra = rnd.Next(broj_igri);
            String[] izlaz = new String[42];

            int brojac = 0;
            int interni = 0;
            string line;

            TextReader file = new StreamReader(@"potrebno/detekcije.txt", System.Text.Encoding.Default, true);

            while ((line = file.ReadLine()) != null)
            {
                if (brojac < igra * 42) { ++brojac; continue; }
                if (interni < 42) { izlaz[interni] = line; ++interni; }
                if (interni == 42) break;
            }

            return izlaz;
        }

        public String[] zavrsna()
        {
            int lineCount = File.ReadLines(@"potrebno/zavrsna.txt").Count();
            int broj_pitanja = lineCount / 5;
            Random rnd = new Random();
            List<int> iskoristeno = new List<int>();
            String[] izlaz = new String[50];

            for (int i = 0; i < 10; ++i)
            {
                int pitanje = rnd.Next(broj_pitanja);
                if (iskoristeno.Contains(pitanje))
                {
                    --i;
                    continue;
                }
                iskoristeno.Add(pitanje);

                int brojac = 0;
                int interni = 0;

                string line;

                TextReader file = new StreamReader(@"potrebno/zavrsna.txt", System.Text.Encoding.Default, true);

                while ((line = file.ReadLine()) != null && interni < 5)
                {
                    if (brojac < pitanje * 5) { ++brojac; continue; }
                    if (interni < 5) { izlaz[interni] = line; ++interni; }
                }

            }

            return izlaz;
        }
    }
}
