using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace асъе
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dicePoints = random.Next()%6+1;
            label1.Visible = true;
            if (dicePoints == 6)
            {
                label2.Text = "Well done it's 6";
            }
            else 
            {
                label2.Text = "Roll the dice again";
            }
            label1.Text = "The dice shows " + dicePoints + " points"; 
        }
    }
}
