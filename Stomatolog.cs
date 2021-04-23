using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunSmile
{
    class Stomatolog
    {
        private int br_pacijenata;
        private string vrsta_tretmana;
        private int datum;

        public int Br_pacijenata
        {
            get { return br_pacijenata; }
            set { br_pacijenata = value; }
        }

        public string Vrsta_tretmana
        {
            get { return vrsta_tretmana; }
            set { vrsta_tretmana = value; }
        }

        public int Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public Stomatolog(int br_pacijenata, string vrsta_tretmana, int datum)
        {
            Br_pacijenata = br_pacijenata;
            Vrsta_tretmana = vrsta_tretmana;
            Datum = datum;
        }

        public override string ToString()
        {
            return "Broj pacijenta" + br_pacijenata + "Vrsta tretmana: " + vrsta_tretmana + " Datum: " + datum;
        }
    }
}
