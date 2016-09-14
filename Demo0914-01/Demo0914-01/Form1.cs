using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo0914_01
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList MyCustomers;

        //Detta är en CONSTRUCTOR och körs alltid automatiskt direkt vid new
        //Använd ALLTID en constructor
        //En constructor har samma namn som klassen och ingen returtyp inte ens void
        public Form1()
        {
            InitializeComponent();
            MyCustomers = new System.Collections.ArrayList();

            panel1.Visible = false;

            Customer c = new Customer() { Name="Kalle Anka", Secret="1234" };
            MyCustomers.Add(c);

            listBox1.Items.Add(c);
            //listBox1.DisplayMember = "Name"; //OBS: tar endast ett (1) PropertyName från Customer

            //Eftersom listboxen inte vet vad den ska vis från Customer
            //så anropar den .ToString()
            //ALLA objekt kan svara på ToSTring()
            //men för oss blir det då default namespace.klassnamn
            //inte kul... hur fixa detta?

            //Hmm, någon borde ha tänkt på detta innan...
            //JA, ToString är en metod som kan anpassas, dvs overrideable
            //Kolla Customer-klassen....


            //ALT

            //listBox1.Items.Add(c.Name);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Jag vill skriva ut .Secret
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            //MessageBox.Show(listBox1.SelectedItem.GetType().ToString());

            Customer c = (Customer)listBox1.SelectedItem;
            //MessageBox.Show(c.Secret);


            //Alt med Panel

            panel1.Visible = true;
            label1.Text = string.Format("The secret is {0}.",c.Secret);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
