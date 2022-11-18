using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;


namespace Medienverwaltung
{
    public class Liste
    {
        private List<CD> CDListe = new List<CD>();

        public void CDAdd(CD c)
        {
            CDListe.Add(c);
        }

        public void GetCDListe()
        {
            foreach(var item in CDListe)
            {
                Console.WriteLine(item);
            }
        }


        private List<Buch> BuchListe = new List<Buch>();

        public void BuchAdd(Buch b)
        {
            BuchListe.Add(b);
        }

        public void GetBuchListe()
        {
            foreach (var item in BuchListe)
            {
                Console.WriteLine(item);
            }
        }


        private List<DVD> DVDListe = new List<DVD>();

        public void DVDAdd(DVD d)
        {
            DVDListe.Add(d);
        }

        public void GetDVDListe()
        {
            foreach (var item in DVDListe)
            {
                Console.WriteLine(item);
            }

        }
        public void WriteDvdCsv()
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\..\..\DVDDaten.csv", false, Encoding.UTF8))
            {
                sw.WriteLine("Name;Genre;Erscheinungsjahr");

                foreach (var item in DVDListe)
                {
                    sw.WriteLine($"{item.Name};{item.Genre};{item.Erscheinungsjahr}");
                }
            }
        }
        public void WriteCDCsv()
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\..\..\CDDaten.csv", false, Encoding.UTF8))
            {
                sw.WriteLine("Name;Interpret;AnzahlLieder;Erscheinungsjahr");

                foreach (var item in CDListe)
                {
                    sw.WriteLine($"{item.Name};{item.Interpret};{item.AnzahlLieder};{item.Erscheinungsjahr}");
                }
            }
        }
        public void WriteBookCsv()
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\..\..\BuchDaten.csv", false, Encoding.UTF8))
            {
                sw.WriteLine("Name;Autor;Erscheinungsjahr");

                foreach (var item in BuchListe)
                {
                    sw.WriteLine($"{item.Name};{item.Autor};{item.Erscheinungsjahr}");
                }
            }
        }

    }
}
