using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS4_Registracija_Client
{
    public partial class Form1 : Form
    {
        private RegistracijaCallbackHandler rsh;
        private RegistracijaServis.RegistracijaServisClient client;

        public Form1()
        {
            InitializeComponent();
            rsh = new RegistracijaCallbackHandler();
            InstanceContext instanceContext = new InstanceContext(rsh);
            client = new RegistracijaServis.RegistracijaServisClient(instanceContext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.RegistrujVozilo(new RegistracijaServis.Vlasnik()
                                        {
                                            Ime = ime.Text,
                                            Prezime = prezime.Text,
                                            JMBG = jmbg.Text
                                        },
                                    new RegistracijaServis.Vozilo()
                                        {
                                            Marka = marka.Text,
                                            Model = model.Text,
                                            Boja = Color.FromName(boja.Text)
                                        });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tmp = client.VratiSve();
            foreach( RegistracijaServis.Vlasnik v in tmp.Keys)
            {
                richTextBox3.AppendText(v.Ime + " " + v.Prezime + " " + v.JMBG + "\n");
                foreach (var i in tmp[v])
                    richTextBox3.AppendText(i.Marka + " " + i.Model + " " + i.Boja+"\n");
            }
            richTextBox3.AppendText("####################################\n");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var tmp = client.VratiVozila(new RegistracijaServis.Vlasnik() { Ime =ime2.Text, Prezime = prezime2.Text, JMBG = jmbg2.Text });
            foreach (var i in tmp)
                richTextBox1.AppendText(i.Marka + " " + i.Model + " " + i.Boja + "\n");
            richTextBox1.AppendText("####################################\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tmp = client.VratiVlasnike(textBox1.Text);
            foreach (var v in tmp)
                richTextBox2.AppendText(v.Ime + " " + v.Prezime + " " + v.JMBG + "\n");
            richTextBox2.AppendText("####################################\n");
        }
    }
}
