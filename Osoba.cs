using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunSmile
{
    class Osoba
    {
        private string ime;
        private string prezime;
        private int id;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Osoba(string ime, string prezime, int id)
        {
            Ime = ime;
            Prezime = prezime;
            ID = id; 
        }

        public override string ToString()
        {
            return "Ime: " + ime + " Prezime: " + prezime + "ID: " + id;
        }
    }
}
