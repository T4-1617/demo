using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAug31_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Här kan vi börja skriva kod eftersom nu är alla kontroller klara

            button1.Text = "Click me";
            label1.Text = "Ange förnamn:";
            label2.Text = "Ange efternamn:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Detta är en eventhandler som lagts till per automatik
            //då vi dubbelklickade i design-läget
            //obs: det finns automatgenererad kod som vi inte ser just nu 
            //den koden ligger i en designerfil

            //Ta reda på inmatat förnamn
            //Ta reda på inmatat efternamn
            //Slå ihop dem
            //Skriv ut hela namnet i listboxen
            //Töm inmatningsrutorna

            string firstname;
            firstname = textBox1.Text;

            string lastname;
            lastname = textBox2.Text;

            string fullname;
            //fullname = firstname + lastname;
            fullname = string.Format("{0} {1}!",firstname,lastname);

            listBox1.Items.Add(fullname);

            textBox1.Text = ""; //Här skapas en tom sträng i arkivet (Heap)
            textBox2.Text = string.Empty; //Detta är att föredra

            textBox1.Focus();
        }
    }
}
