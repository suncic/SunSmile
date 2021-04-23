using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SunSmile
{
    public partial class f1 : Form
    {
        public f1()
        {
            InitializeComponent();
        }

        private void f1_Load(object sender, EventArgs e)
        { 
        }

        private void b1_Click(object sender, EventArgs e)
        {
            var myForm = new Form();
            myForm.Show();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            var myForm = new Form();
            myForm.Show();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            var myForm = new Form();
            myForm.Show();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            var myForm = new Form();
            myForm.Show();
        }
        
    }
    static void Main(string[] args)
    {
        string file = "Pacijenti.txt";
        string osoba = "Petar Petrovic";

        SnimiTxt(file, osoba);

    }

    public void SnimiTxt(string file, string osoba)
    {
        StreamWriter sw = new StreamWriter(file);
        sw.WriteLine(osoba);
        sw.Close();
    }
}
