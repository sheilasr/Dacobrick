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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            Buscar_ID();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int CODIGO;
            int N_factura;
            string Fecha = "";
            string Empresa = "";
            string Producto = "";
            string Importe = "";
            string ID_Obra = "";


            CODIGO = Convert.ToInt32(textBox1.Text);
            N_factura = Convert.ToInt32(textBox1.Text);
            Fecha = Convert.ToString(dateTimePicker1.Text);
            Empresa = textBox3.Text;
            Producto = textBox4.Text;
            Importe = textBox6.Text;
            ID_Obra = Variables_Globales.Identificador_obra;


            if (Convert.ToString(CODIGO) != "" && ID_Obra != "" && Convert.ToString(N_factura) != "" && Importe != "")
            {
                Conexiones.Ejecuta_Consulta("INSERT INTO facturas (CODIGO, ID_Obra, N_factura, Fecha, Empresa, Producto, Importe) " +
                    "VALUES ('" + CODIGO + "', '" + ID_Obra + "', '" + N_factura + "', '" + Fecha + "', '" + Empresa + "', '" + Producto + "', '" + Importe +"')");

                MessageBox.Show("Registro guardado correctamente.");

                //this.Close();

            }
            else
            {
                MessageBox.Show("Debes insertar nº de factura e importe.");
                return;
            }
        }
        
        private void Buscar_ID()
        {
            string maximo = "";
            try
            {
                String SQL = "SELECT MAX(COD_GASTOS) as COD_GASTOS FROM gastos";
                DataSet ds = Conexiones.Retorna_Datos(SQL);
                maximo = Convert.ToString(ds.Tables[0].Rows[0]["COD_GASTOS"]);

                if (maximo == "")
                {
                    textBox1.Text = "0";
                }

                if (maximo != "" && ds.Tables[0].Rows.Count > 0)
                {
                    textBox1.Text = (Convert.ToInt32(ds.Tables[0].Rows[0]["COD_GASTOS"]) + 1).ToString();
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Todavía no existían registros.");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conexiones.KeyPress_Decimal((TextBox)textBox6, e, false);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
