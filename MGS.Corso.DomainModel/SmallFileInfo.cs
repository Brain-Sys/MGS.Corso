using System;
using System.Collections.Generic;
using System.Text;

namespace MGS.Corso.DomainModel
{
    public class SmallFileInfo
    {
        public string NOMEFILE { get; set; }
        public string DIMENSIONE_IN_KBYTES { get; set; }

        public override string ToString()
        {
            return $"{this.NOMEFILE.ToUpper()}, {this.DIMENSIONE_IN_KBYTES}";
        }
    }
}