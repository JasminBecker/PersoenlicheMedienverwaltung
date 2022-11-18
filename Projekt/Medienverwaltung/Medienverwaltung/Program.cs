using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Medienverwaltung
{
    internal class Program
    {
       

        static void Main(string[] args)
        {


            CD a = new CD("POST HUMAN: SURVIVAL HORROR", "Bring Me the Horizon", 4, 2020);
            CD b = new CD("The Drug in Me Is You", "Falling in Reverse", 5, 2011);
            CD c = new CD("Tekkno", "Electric Cowboy", 10, 2022);
            CD d = new CD("Wretched and Divine: The Story of the Wild Ones", "Black Veil Brides", 18, 2013);
            CD e = new CD("Happier Than Ever", "Billie Eilish", 16, 2021);
 
            Buch aa = new Buch("Harry Potter und der Stein der Weisen", "´J. K. Rowling", 1997);
            Buch bb = new Buch("Faust. Eine Tragödie", "Johann Wolfgang von Goethe", 1808);
            Buch cc = new Buch("Essen gegen Herzinfarkt", "Dr. Caldwell B. Esselstyn", 2022);
            Buch dd = new Buch("How to kill your family", "Bella Mackie", 2022);
            Buch ee = new Buch("Depressionen bewältigen", "Dr. Ulrich Hegerl, Dr. Svenja Niescken", 2022);

            DVD aaa = new DVD("Jeepers Creepers Reborn", "Horror", 2022);
            DVD bbb = new DVD("Bullet Train", "Action, Thriller", 2022);
            DVD ccc = new DVD("Found - Mein Bruder ist ein Serienkiller", "Thriller", 2012);
            DVD ddd = new DVD("Halloween", "Horror", 1978);
            DVD eee = new DVD("Saw", "Horror", 2004);

            Liste Mediathek = new Liste();
            Mediathek.CDAdd(a);
            Mediathek.CDAdd(b);
            Mediathek.CDAdd(c);
            Mediathek.CDAdd(d);
            Mediathek.CDAdd(e);
            Mediathek.GetCDListe();
            Mediathek.BuchAdd(aa);
            Mediathek.BuchAdd(bb);
            Mediathek.BuchAdd(cc);
            Mediathek.BuchAdd(dd);
            Mediathek.BuchAdd(ee);
            Mediathek.GetBuchListe();
            Mediathek.DVDAdd(aaa);
            Mediathek.DVDAdd(bbb);
            Mediathek.DVDAdd(ccc);
            Mediathek.DVDAdd(ddd);
            Mediathek.DVDAdd(eee);

            Mediathek.WriteBookCsv();
            Mediathek.WriteCDCsv();
            Mediathek.WriteDvdCsv();


            Console.ReadLine();

        }
    }
}
