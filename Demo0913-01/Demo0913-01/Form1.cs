using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo0913_01
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList MyCustomerList = new System.Collections.ArrayList();
        public Form1()
        {
            InitializeComponent();

            //Göm panelen
            panel1.Visible = false;


            //Skapa lite exempelkunder för denna demo
            Customer c = new Customer();
            c.Name = "Musse Pigg";
            c.VIP = false;

            MyCustomerList.Add(c);

            //Alternativt sätt, lite kortare
            //Här skapas/instansieras objektet OCH egenskaperna sätts direkt
            Customer d = new Customer() { Name = "Janne Långben", VIP = false };
            MyCustomerList.Add(d);

            //Alternativt sätt, ännu kortare
            //Här görs båda sakerna på samma rad, dvs skapa kund objekt OCH lägga till i kundlistan
            MyCustomerList.Add(new Customer() { Name = "Kalle Anka", VIP = false });

            MyCustomerList.Add(new Customer() { Name = "Arne Anka", VIP = false });
            MyCustomerList.Add(new Customer() { Name = "Kajsa Anka", VIP = false });


            //Visa alla kunderna i listboxen
            listBox1.Items.Clear();
            foreach (Customer item in MyCustomerList)
            {
                listBox1.Items.Add(item);
                //Obs: detta visar texten "Demo0913-01.Customer" vilket är korrekt
                //Vi har inte talat om för listboxen VAD den ska visa från ett Customer-objekt
                //och detta är default, kallas för metoden .ToString()
                //då skrivs namnespace.klassnamn ut

                //För att fixa detta, talar vi om för listboxen VAD den ska använda för att visa text
                //Det MÅSTE vara en PROPERTY från Customerklassen
                listBox1.DisplayMember = "Name";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Här hamnar vi om vi trycker på knappen (Spara ändring av VIP status)
            Customer c;
            c = (Customer)listBox1.SelectedItem;
            c.VIP = checkBox1.Checked;

            //Uppdatera listboxen
            listBox1.Items.Clear();
            foreach (Customer item in MyCustomerList)
            {
                listBox1.Items.Add(item);
                listBox1.DisplayMember = "Name";
            }

            //Göm panelen igen
            panel1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Visa panelen
            panel1.Visible = true;

            //Hugg tag i den kund (Customer objektet) som valts i listan
            Customer c;
            c = (Customer)listBox1.SelectedItem; //Måste CASTAS, dvs se till att rätt klass används, mer om detta imorgon

            //Skriv ut info om VIP
            checkBox1.Checked = c.VIP;

        }
    }
}
