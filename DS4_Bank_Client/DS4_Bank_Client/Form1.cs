using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS4_Bank_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankService.BankServiceClient client = new BankService.BankServiceClient();
            label1.Text = client.ShowInDinars().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BankService.BankServiceClient client = new BankService.BankServiceClient();
            client.UpdateBalance(Double.Parse(textBox1.Text), textBox2.Text, Double.Parse(textBox3.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BankService.BankServiceClient client = new BankService.BankServiceClient();
            client.Withdraw(Double.Parse(textBox4.Text));
        }
    }
}
