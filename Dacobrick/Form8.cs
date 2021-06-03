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
    public partial class Form8 : Form
    {
        string Fecha_desde = "";
        string Fecha_hasta = "";
        public Form8()
        {
            InitializeComponent();
            Rellenar_ListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        string ID = "";
        string Exp = "";
        string Ti = "";
        List<string> Lista_ID_obras = new List<string>();
        List<string> Lista_Exp_obras = new List<string>();
        List<string> Lista_Ti_obras = new List<string>();

        private void Rellenar_ListBox()
        {
            //DataSet ds = Conexiones.Retorna_Datos("Select ID, Expediente, Titulo, Estado from obras where (Estado = 'ADJUDICADA' or Estado = 'EN EJECUCIÓN' or Estado = 'FINALIZADA' or Estado = 'OTROS')");
            DataSet ds = Conexiones.Retorna_Datos("Select ID, Expediente, Titulo, Estado from obras");

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
            listBox1.DataSource = Lista_todo;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listBox1.Enabled = false;
            }
            else if (checkBox1.Checked == false)
            {
                listBox1.Enabled = true;

            }
        }

        List<string> Lista_desconcatenar = new List<string>();
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Fecha_desde = Convert.ToString(dateTimePicker1.Text);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";

            if (checkBox1.Checked == true)
            {
                if(dateTimePicker1.Text != "")
                {
                    string Fecha_inicio = Convert.ToString(dateTimePicker1.Text);
                    //string Fecha_fin = Convert.ToString(dateTimePicker2.Text);
                    //String SQL = "SELECT * FROM planificacion inner join obras on planificacion.ID_obra = obras.ID" +
                    //    " where Fecha between '" + Fecha_desde + "' and '" + Fecha_hasta + "'";

                    String SQL = "SELECT * FROM planificacion inner join obras on planificacion.ID_obra = obras.ID" +
                        " where Fecha = '" + Fecha_desde + "'";
                    DataSet ds = Conexiones.Retorna_Datos(SQL);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("No hay registros para la/s obra/s y/o fecha/s seleccionada/s.");
                    }


                }
                else
                {
                    MessageBox.Show("Debes seleccionar FECHA.");
                }
            }
            else if (listBox1.Text != "")
            {
                if (dateTimePicker1.Text != "")
                {
                    string Fecha_inicio = Convert.ToString(dateTimePicker1.Text);
                    //string Fecha_fin = Convert.ToString(dateTimePicker2.Text);
                    //String SQL = "SELECT * FROM planificacion inner join obras on planificacion.ID_obra = obras.ID" +
                    //    " where planificacion.ID_obra = '" + ID + "' and Fecha between '" + Fecha_desde + "' and '" + Fecha_hasta + "'";

                    String SQL = "SELECT * FROM planificacion inner join obras on planificacion.ID_obra = obras.ID" +
                        " where planificacion.ID_obra = '" + ID + "' and Fecha = '" + Fecha_desde + "'";

                    DataSet ds = Conexiones.Retorna_Datos(SQL);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("No hay registros para la/s obra/s y/o fecha/s seleccionada/s.");
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar FECHA.");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar la/s obra/s.");
            }
        }
    }
}
