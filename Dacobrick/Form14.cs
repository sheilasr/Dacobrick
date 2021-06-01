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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            Buscar_ID();
            Rellenar_ListBox();
        }

        string ID = "";
        string Exp = "";
        string Ti = "";
        List<string> Lista_ID_obras = new List<string>();
        List<string> Lista_Exp_obras = new List<string>();
        List<string> Lista_Ti_obras = new List<string>();

        private void Rellenar_ListBox()
        {
            DataSet ds = Conexiones.Retorna_Datos("Select ID, Expediente, Titulo, Estado from obras where (Estado = 'PUBLICADA' or Estado = 'PRESENTADA' or Estado = 'EN EVALUACIÓN' or Estado = 'ADJUDICADA' or Estado = 'EN EJECUCIÓN' or Estado = 'FINALIZADA' or Estado = 'OTROS')");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ID = ds.Tables[0].Rows[i]["ID"].ToString();
                Exp = ds.Tables[0].Rows[i]["Expediente"].ToString();
                Ti = ds.Tables[0].Rows[i]["Titulo"].ToString();
                Lista_ID_obras.Add(ID);
                Lista_Exp_obras.Add(Exp);
                Lista_Ti_obras.Add(Ti);

            }

            List<string> Lista_todo = new List<string>();
            for (int i = 0; i < Lista_ID_obras.Count; i++)
            {
                string concatenar = Lista_ID_obras[i] + ", " + Lista_Exp_obras[i] + ", " + Lista_Ti_obras[i];
                Lista_todo.Add(concatenar);
            }
            listBox2.DataSource = Lista_todo;
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
                    textBox1.Text = "1";
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

        List<string> Lista_desconcatenar = new List<string>();
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lista_desconcatenar.Clear();
            string curItem = listBox2.SelectedItem.ToString();
            int index = listBox2.FindString(curItem);
            string[] words = curItem.Split(',');

            foreach (var word in words)
            {
                if (!Lista_desconcatenar.Contains(word))
                {
                    Lista_desconcatenar.Add(word);
                }
            }

            for (int i = 0; i < 1; i++)
            {
                textBox_ID.Text = Lista_desconcatenar[0];
                textBox_Exp.Text = Lista_desconcatenar[1];
                textBox_Tit.Text = Lista_desconcatenar[2];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string COD_GASTOS = "";
            string N_factura = "";
            string Fecha = "";
            string Tipo = "";
            string Obra = "";
            string Expediente = "";
            string Titulo = "";
            string Importe = "";

            COD_GASTOS = textBox1.Text;
            N_factura = Convert.ToString(textBox2.Text);
            Fecha = Convert.ToString(dateTimePicker1.Text);
            Tipo = Convert.ToString(listBox1.Text);
            Importe = textBox3.Text;
            Obra = textBox_ID.Text;
            Expediente = Convert.ToString(textBox_Exp.Text);
            Titulo = Convert.ToString(textBox_Tit.Text);

            if (Convert.ToString(COD_GASTOS) != "" && Convert.ToString(Obra) != "" && Convert.ToString(N_factura) != "" && Convert.ToString(Fecha) != "")
            {
                string SQL = "INSERT INTO gastos (COD_GASTOS, N_factura, Fecha, Tipo, Obra, Expediente, Titulo, Importe) " +
                    "VALUES ('" + COD_GASTOS + "', '" + N_factura + "', '" + Fecha + "', '" + Tipo + "', '" + Obra + "', '" + Expediente + "', '" + Titulo + "', '" + Importe + "')";
                Conexiones.Ejecuta_Consulta("INSERT INTO gastos (COD_GASTOS, N_factura, Fecha, Tipo, Obra, Expediente, Titulo, Importe) " +
                    "VALUES ('" + COD_GASTOS + "', '" + N_factura + "', '" + Fecha + "', '" + Tipo + "', '" + Obra + "', '" + Expediente + "', '" + Titulo + "', '" + Importe + "')");

                MessageBox.Show("Registro guardado correctamente.");

                this.Close();

            }
            else
            {
                MessageBox.Show("Debes insertar nº de factura, importe y fecha.");
                return;
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conexiones.KeyPress_Decimal((TextBox)textBox3, e, false);
        }
    }
}
