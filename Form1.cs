using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bananacalculator
{
    public partial class Form1 : Form
    {
        string msgclose = "Köszönöm hogy használta a Banán Kalkulátort! \nKészítette: Müller István";

        public Form1()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(msgclose, "Bezárás", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();
        }

        private void inputbox_Click(object sender, EventArgs e)
        {
            inputbox.Text = string.Empty; //remove text on click
        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mm_CheckedChanged(object sender, EventArgs e)
        {
            if (mm.Checked)
            {
                resultlabel.Text = "Eredmény: " + (Convert.ToInt64(inputbox.Text) * 177.80) + " miliméter.\n";
            }
        }

        private void cm_CheckedChanged(object sender, EventArgs e)
        {
            if (cm.Checked)
            {
                resultlabel.Text = "Eredmény: " + (Convert.ToInt64(inputbox.Text) * 17.780) + " centiméter.\n";
            }
        }

        private void km_CheckedChanged(object sender, EventArgs e)
        {
            if (km.Checked)
            {
                resultlabel.Text = "Eredmény: " + (Convert.ToInt64(inputbox.Text) * 0.000178) + " kilóméter.\n";
            }
        }

        private void ft_CheckedChanged(object sender, EventArgs e)
        {
            if (ft.Checked)
            {
                resultlabel.Text = "Eredmény: " + (Convert.ToInt64(inputbox.Text) * 0.583) + " láb.\n";
            }
        }

        private void inch_CheckedChanged(object sender, EventArgs e)
        {
            if (inch.Checked)
            {
                resultlabel.Text = "Eredmény: " + (Convert.ToInt64(inputbox.Text) * 7.00) + " hüvelyk.\n";
            }
        }

        private void miles_CheckedChanged(object sender, EventArgs e)
        {
            if (miles.Checked)
            {
                resultlabel.Text = "Eredmény: " + (Convert.ToInt64(inputbox.Text) * 0.000110) + " mérföld.\n";
            }
        }
    }
}
