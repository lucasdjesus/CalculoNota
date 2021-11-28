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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            txtMensagem.Text = "Seja bem vindo";
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
