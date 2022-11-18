using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medienverwaltung
{
    public class Buch
    {
        public string Name;

        public string Autor;

        public int Erscheinungsjahr;

        public Buch(string name, string autor, int erscheinungsjahr)
        {
            Name = name;
            Autor = autor;
            Erscheinungsjahr = erscheinungsjahr;
        }

        public override string ToString()
        {
            return $"{Name} - {Autor} - {Erscheinungsjahr}";
        }

    }
}
