using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo0923_02
{
    public partial class Form1 : Form
    {
        private System.Collections.ArrayList _customers;

        public Form1()
        {
            InitializeComponent();

            _customers = new System.Collections.ArrayList();

            //Demo dummies
            Customer c = new Customer() { Name = "Kalle" };
            c.CreateAccount(1200);
            _customers.Add(c);

            c = new Customer() { Name = "Musse" };
            c.CreateAccount(2200);
            c.CreateAccount(4310);
            _customers.Add(c);

            //Visa alla kunder i listbox 1
            listBox1.DisplayMember = "Name";
            foreach (Customer item in _customers)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Visa alla konton för vald kund

            Customer c = (Customer)listBox1.SelectedItem;
            DisplayAccounts(c);
        }

        private void DisplayAccounts(Customer c)
        {
            listBox2.Items.Clear();
            listBox2.DisplayMember = "AccountInfo";
            foreach (Account item in c.GetAccounts())
            {
                listBox2.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sätt in pengar på valt konto
            if (listBox2.SelectedItem != null)
            {
                //Dvs ett konto har valts i listan

                Account a = (Account)listBox2.SelectedItem;
                a.Deposit(decimal.Parse(textBox1.Text));

                DisplayAccounts((Customer)listBox1.SelectedItem);
            }
        }
    }
}
