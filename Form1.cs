using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Practica_de_Contadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsumar_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtbox.Text);
            count++;
            txtbox.Text = count.ToString();
            if (count >= 25) {
                txtbox.Text = "25";
                MessageBox.Show("No es posible suamr mas valores.");

            }
        }

        private void buttonrestar_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtbox.Text);
            count--;
            txtbox.Text = count.ToString();
            if (count <= 0) {
                txtbox.Text = "0";
                MessageBox.Show("Ya no es posible restar mas valores.");
            }
        }
    }
}
