using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class frmFormularioInicial : Form
    {
        public frmFormularioInicial() //constructor
        {
            InitializeComponent();
        }

        private void frmFormularioInicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmForm2 frm = new frmForm2();
            frm.BackColor = Color.White;
            frm.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingrese su nombre");

            }
            else
            {
                MessageBox.Show("Bienvenido" + textBox1.Text);

            }
        }

       

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)numericUpDown1.Value;
        }
    }
}
