using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudicijaKlijent
{
    public partial class Form1 : Form
    {

        private AudicijaServis.AudicijaServisClient client;
        private AudicijaServis.Klijent klijent;
        private static int id;
        public Form1()
        {
            InitializeComponent();
            client = new AudicijaServis.AudicijaServisClient();
            id = 0; 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            klijent = new AudicijaServis.Klijent() { Id = id++, Ime = textBox1.Text, Prezime = textBox2.Text };
            client.PrijaviKlijenta(klijent);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var tmp = client.VratiEksponat();
            richTextBox1.AppendText(tmp.Naziv + " " + tmp.KupacId + " " + tmp.TrenutnaCena + "\n");
            richTextBox1.AppendText("################################\n");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (client.Odustani(klijent.Id))
                MessageBox.Show("Uspesno ste odustali");
            else
                MessageBox.Show("Niste ni bili prijavljeni");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (client.PovecajCenu(klijent.Id) == 1)
                MessageBox.Show("Kupili ste predmet");
            else if (client.PovecajCenu(klijent.Id) == 2)
                MessageBox.Show("Uspesno uplacivanje");
            else
                MessageBox.Show("Neuspesno uplacivanje");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var tmp = client.VratiKlijente();
            foreach(var k in tmp)
                richTextBox1.AppendText(k.Ime + " " + k.Prezime + "\n");
            richTextBox1.AppendText("################################\n");
        }
    }
}
