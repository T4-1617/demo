using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo0923_01
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList Customers;

        public Form1()
        {
            InitializeComponent();

            Customers = new System.Collections.ArrayList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal initialDeposit = decimal.Parse(textBox1.Text);

            Customer c = new Customer();
            //c.CreateAccount(1000);
            c.CreateAccount(initialDeposit);

            Customers.Add(c);

            MessageBox.Show("Saldo: " + c.GetAccount(0).Balance);
        }
    }
}
