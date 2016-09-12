using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo0912_02
{
    public partial class Form1 : Form
    {
        //Exempel, vi vill nu spara alla kunderna på något sätt
        //så länge programmet körs
        //Vi testar att använda en ARRAYLIST
        //Den bor: System.Collections.ArrayList

        System.Collections.ArrayList MyCustomers = new System.Collections.ArrayList();


        //Denna metod körs automatiskt när klassen instansieras
        //Metoden kallas för en CONSTRUCTOR
        //Varje klass har alltid minst en constructor
        public Form1()
        {
            //Denna metod som anropas kommer se till att skapa  (instansiera)
            //alla de kontroller vi vill ha på vårt formulär
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //Vi vill nu skapa ett nytt Customer-objekt
            //och ange inmatade uppgifter för First- och Lastname
            //och visa upp hela namnet i en alertbox.

            Customer c = new Customer();
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;

            //Spara vår nya kund i vår lista med kunder
            MyCustomers.Add(c);

            MessageBox.Show(string.Format("Added a new Customer: {0}",c.FullName()));


        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            //Töm listboxen
            //Gå igenom alla Customers i vår lista MyCustomers
            //och skriv ut namnen i ListBoxen

            listBox1.Items.Clear();

            foreach (Customer item in MyCustomers)
            {
                listBox1.Items.Add(item.FullName());
            }
        }
    }
}
