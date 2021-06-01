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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            Buscar_ID();
            Rellenar_ListBox();
        }

        private void Calcular_Total_Horas()
        {
            string HEntrada = "";
            string HSalida = "";
            string THoraS = "";
            string THorasE = "";
            TimeSpan valor1;
            TimeSpan valor2;

            HEntrada = (maskedTextBox1.Text.ToString());
            HSalida = (maskedTextBox2.Text.ToString());
            THorasE = HEntrada.Substring(0, 2) + ":" + HEntrada.Substring(3, 2);
            THoraS = HSalida.Substring(0, 2) + ":" + HSalida.Substring(3, 2);
            valor1 = TimeSpan.Parse(THorasE); 
            valor2 = TimeSpan.Parse(THoraS);

            TimeSpan diferencia = valor2.Subtract(valor1);
            textBox4.Text = Convert.ToString(diferencia);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(maskedTextBox1) != "" && Convert.ToString(maskedTextBox2) != "")
            {
                Calcular_Total_Horas();
            }
            else
            {
                MessageBox.Show("Debes insertar la hora de entrada y la de salida.");
            }

            string COD_Horas = "";
            string Fecha = "";
            string Obra = "";
            string H_entrada = "";
            string H_salida = "";
            string Total = "";
            string Expediente = "";
            string Titulo = "";

            COD_Horas = textBox1.Text;
            Fecha = Convert.ToString(dateTimePicker1.Text);
            Obra = textBox_ID.Text;
            H_entrada = maskedTextBox1.Text;
            H_salida = maskedTextBox2.Text;
            Total = textBox4.Text;
            Expediente = Convert.ToString(textBox_Exp.Text);
            Titulo = Convert.ToString(textBox_Tit.Text);

            if (Convert.ToString(COD_Horas) != "" && Convert.ToString(Obra) != "" && Convert.ToString(Total) != "")
            {
                string SQL = "INSERT INTO horas (COD_Horas, Fecha, Obra, Expediente, Titulo, H_entrada, H_salida, Total) " +
                    "VALUES ('" + COD_Horas + "', '" + Fecha + "', '" + Obra + "', '" + Expediente + "', '" + Titulo + "', '" + H_entrada + "', '" + H_salida + "', '" + Total + "')";
                Conexiones.Ejecuta_Consulta("INSERT INTO horas (COD_Horas, Fecha, Obra, Expediente, Titulo, H_entrada, H_salida, Total) " +
                    "VALUES ('" + COD_Horas + "', '" + Fecha + "', '" + Obra + "', '" + Expediente + "', '" + Titulo + "', '" + H_entrada + "', '" + H_salida + "', '" + Total + "')");

                MessageBox.Show("Registro guardado correctamente.");

                this.Close();

            }
            else
            {
                MessageBox.Show("Debes seleccionar la obra e insertar las horas de entrada y salida.");
                return;
            }
        }

        private void Rellenar_ListBox()
        {
            DataSet ds = Conexiones.Retorna_Datos("Select ID, Expediente, Titulo, Estado from obras where (Estado = 'PUBLICADA' or Estado = 'PRESENTADA' or Estado = 'EN EVALUACIÓN' or Estado = 'ADJUDICADA' or Estado = 'EN EJECUCIÓN' or Estado = 'FINALIZADA' or Estado = 'OTROS')");

            List<string> Lista_ID_obras = new List<string>();
            List<string> Lista_Exp_obras = new List<string>();
            List<string> Lista_Ti_obras = new List<string>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string ID = ds.Tables[0].Rows[i]["ID"].ToString();
                string Exp = ds.Tables[0].Rows[i]["Expediente"].ToString();
                string Ti = ds.Tables[0].Rows[i]["Titulo"].ToString();
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
            listBox1.DataSource = Lista_todo;
        }

        private void Buscar_ID()
        {
            string maximo = "";
            try
            {
                String SQL = "SELECT MAX(COD_Horas) as COD_Horas FROM horas";
                DataSet ds = Conexiones.Retorna_Datos(SQL);
                maximo = Convert.ToString(ds.Tables[0].Rows[0]["COD_Horas"]);

                if (maximo == "")
                {
                    textBox1.Text = "1";
                }
                
                if (maximo != "" && ds.Tables[0].Rows.Count > 0)
                {
                    textBox1.Text = (Convert.ToInt32(ds.Tables[0].Rows[0]["COD_Horas"]) + 1).ToString();
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Todavía no existían registros.");
            }
        }

        List<string> Lista_desconcatenar = new List<string>();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lista_desconcatenar.Clear();
            string curItem = listBox1.SelectedItem.ToString();
            int index = listBox1.FindString(curItem);
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

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            Int32 horas = Int32.Parse(maskedTextBox1.Text.Substring(0, 2));
            if (horas > 24)
            {
                MessageBox.Show("No puede superar las 24hs");
                seleccionarhoras(maskedTextBox1);
                e.Cancel = true;
            }
        }

        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            Int32 horas = Int32.Parse(maskedTextBox1.Text.Substring(0, 2));
            if (horas > 24)
            {
                MessageBox.Show("No puede superar las 24hs");
                seleccionarhoras(maskedTextBox2);
                e.Cancel = true;
            }
        }

        private void seleccionarhoras(MaskedTextBox mkt)
        {
            mkt.Focus();
            mkt.SelectionStart = 0;
            mkt.SelectionLength = 2;
        }
    }
}
