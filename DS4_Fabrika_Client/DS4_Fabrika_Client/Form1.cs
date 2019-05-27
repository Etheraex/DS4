using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS4_Fabrika_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FabrikaService.FabrikaServiceClient client = new FabrikaService.FabrikaServiceClient();
            if (!client.Flasiraj(double.Parse(textBox4.Text)))
                MessageBox.Show("Nemoguce flasiranje");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FabrikaService.FabrikaServiceClient client = new FabrikaService.FabrikaServiceClient();
            var tmp = client.PrikaziStanje();
            label1.Text = tmp.Zauzece.ToString();
            label2.Text = tmp.Gustina.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FabrikaService.FabrikaServiceClient client = new FabrikaService.FabrikaServiceClient();
            if (!client.DodajSastojak(textBox1.Text, double.Parse(textBox2.Text), double.Parse(textBox3.Text)))
                MessageBox.Show("Nemoguce dodavanje!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FabrikaService.FabrikaServiceClient client = new FabrikaService.FabrikaServiceClient();
            client.IsprazniSistem();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FabrikaService.FabrikaServiceClient client = new FabrikaService.FabrikaServiceClient();
            var tmp = client.VratiPromene();
            foreach (var s in tmp)
                richTextBox1.AppendText(s + "\n");
            richTextBox1.AppendText("############################\n");
        }
    }
}