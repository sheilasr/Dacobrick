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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            Buscar_ID();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ID;
            string ID_obra;
            string Fecha = "";
            string Tipo = "";
            string Descripcion = "";

            ID = textBox1.Text;
            ID_obra = Convert.ToString(Variables_Globales.id);
            Fecha = Convert.ToString(dateTimePicker1.Text);
            Tipo = Convert.ToString(checkedListBox1.Text);
            Descripcion = textBox4.Text;

            if(Fecha != "" && Tipo != "" && Descripcion != "")
            {
                Conexiones.Ejecuta_Consulta("INSERT INTO planificacion (ID, ID_obra, Fecha, Tipo, Descripcion) " +
                    "VALUES ('" + ID + "', '" + ID_obra + "', '" + Fecha + "', '" + Tipo + "', '" + Descripcion + "')");

                MessageBox.Show("Registro guardado correctamente.");

                this.Close();

            }
            else
            {
                MessageBox.Show("Debes insertar fecha, tipo y/o descripción.");
                return;
            }

        }
        private void Buscar_ID()
        {
            string maximo = "";
            try
            {
                String SQL = "SELECT MAX(ID) as ID FROM planificacion";
                DataSet ds = Conexiones.Retorna_Datos(SQL);
                maximo = Convert.ToString(ds.Tables[0].Rows[0]["ID"]);

                if (maximo == "")
                {
                    textBox1.Text = "1";
                }

                if (maximo != "" && ds.Tables[0].Rows.Count > 0)
                {
                    textBox1.Text = (Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]) + 1).ToString();
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Todavía no existían registros.");
            }
        }
    }
}
