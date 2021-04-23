using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunSmile
{
    class Pacijent
    {
        private string tretman;
        private int datum;

        public string Tretman
        {
            get { return tretman; }
            set { tretman = value; }
        }

        public int Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public Pacijent(string tretman, int datum)
        {
            Tretman = tretman;
            Datum = datum;
        }

        public override string ToString()
        {
            return "Tretman: " + tretman + " Datum: " + datum;
        }
    }
}
