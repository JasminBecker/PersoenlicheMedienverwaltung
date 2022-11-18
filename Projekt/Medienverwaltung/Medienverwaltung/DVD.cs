using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medienverwaltung
{
    public class DVD
    {
        public string Name;

        public string Genre;

        public int Erscheinungsjahr;

        public DVD(string name, string genre, int erscheinungsjahr)
        {
            Name = name;
            Genre = genre;
            Erscheinungsjahr = erscheinungsjahr;
        }

        public override string ToString()
        {
            return $"{Name} - {Genre} - {Erscheinungsjahr}";
        }



    }
}
