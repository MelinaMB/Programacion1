using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_N3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> listaValores1 = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            int valorIngresado1 = int.Parse( textBox1.Text);
            listaValores1.Add(valorIngresado1);
            listBox1.Items.Add(valorIngresado1);
            textBox1.Clear();

        }


        List<int> listaValores2 = new List<int>();
        private void button2_Click(object sender, EventArgs e)
        {
            int valorIngresado2 = int.Parse(textBox2.Text);
            listaValores2.Add(valorIngresado2);
            listBox2.Items.Add(valorIngresado2);
            textBox2.Clear();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                
                int resultado = (listaValores1[i] + listaValores2[i]);
                listBox3.Items.Add(resultado);
                

            }
            
        }
    }
}
