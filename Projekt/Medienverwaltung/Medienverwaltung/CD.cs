using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Medienverwaltung
{
    public class CD
    {

        public string Name;

        public string Interpret;

        public int AnzahlLieder;

        public int Erscheinungsjahr; 
        
        public CD(string name, string interpret, int anzahllieder, int erscheinungsjahr)
        {
            Name = name;
            Interpret = interpret;
            AnzahlLieder = anzahllieder;
            Erscheinungsjahr = erscheinungsjahr;
        }

        public override string ToString()
        {
            return $"{Name} - {Interpret} - {AnzahlLieder} - {Erscheinungsjahr}";
        }

    }
}
