using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcularNota
{
    public partial class frmCalcularNota : Form
    {
        public frmCalcularNota()
        {
            InitializeComponent();
        }

        private void LblNotaSeis_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            int nota1;
            int nota2;
            int nota3;
            int nota4;
            int media;
            nota1 = Convert.ToInt16(txtNota1.Text);
            nota2 = Convert.ToInt16(txtNota2.Text);
            nota3 = Convert.ToInt16(txtNota3.Text);
            nota4 = Convert.ToInt16(txtNota4.Text);
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            txtmedia.Text = media.ToString();
         
           
           
            MessageBox.Show("Aprovado "+txtmedia.Text);

        }

        private void frmCalcularNota_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
                txtNota1.Focus();
                txtNota2.Focus();
                txtNota3.Focus();
                txtNota4.Focus();
        }

        private void txtmedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNota5_Click(object sender, EventArgs e)
        {

        }
    }
}
