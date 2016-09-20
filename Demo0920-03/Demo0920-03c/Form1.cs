using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo0920_03b;

namespace Demo0920_03c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer() { FirstName="Kalle", LastName="Anka" };
            MessageBox.Show(c.FirstName);
        }
    }
}
