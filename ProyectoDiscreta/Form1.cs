using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiscreta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnComenzar_Click(object sender, EventArgs e)
        {
            FrmConvertidor convertidor = new FrmConvertidor();
            convertidor.Show();
        }

        private void BtnGrupo_Click(object sender, EventArgs e)
        {
            Integrantes integrantes = new Integrantes();
            integrantes.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
