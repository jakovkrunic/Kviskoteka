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
        public String[] asocijacija()
        {
            int lineCount = File.ReadLines(@"files\asocijacije.txt").Count();
            int broj_igri = lineCount / 21;
            Random rnd = new Random();
            int igra = rnd.Next(broj_igri);
            String[] izlaz = new String[21];

            int brojac = 0;
            int interni = 0;

            foreach (string line in File.ReadLines(@"files\asocijacije.txt"))
            {
                if (brojac < igra*21) { ++brojac; continue; }
                if (interni < 21) { izlaz[interni] = line; ++interni; }
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
            }

            return izlaz;
        }
    }
}
