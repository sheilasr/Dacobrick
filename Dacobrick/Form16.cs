using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dacobrick
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int CODI;
            string Nombre = "";
            string Apellidos = "";
            string DNI = "";
            string Telefono = "";
            string Nivel = "";
            string Contrato = "";
            string Apto = "";
            string EPIs = "";
            string Maquinaria = "";
            string PRL = "";
            string Albañileria = "";
            string Hormigon = "";
            string Grua = "";
            string Platafomras = "";
            string Libre = "";

            CODI = Convert.ToInt32(textBox1.Text);
            Nombre = textBox2.Text;
            Apellidos = textBox5.Text;
            DNI = textBox3.Text;
            Telefono = textBox4.Text;
            Nivel = listBox1.Text;
            //Contrato = textBox4.Text;
            //Apto = textBox2.Text;
            //EPIs = textBox3.Text;
            //Maquinaria = textBox4.Text;
            //PRL = textBox2.Text;
            //Albañileria = textBox3.Text;
            //Hormigon = textBox4.Text;
            //Grua = textBox3.Text;
            //Platafomras = textBox4.Text;
            //Libre = ;
        }
    }
}
