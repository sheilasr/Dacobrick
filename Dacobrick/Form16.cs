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
            Buscar_ID();
            Rellenar_ListBox();
        }

        private void Buscar_ID()
        {
            string maximo = "";
            try
            {
                String SQL = "SELECT MAX(CODI) as CODI FROM trabajadores_obra";
                DataSet ds = Conexiones.Retorna_Datos(SQL);
                maximo = Convert.ToString(ds.Tables[0].Rows[0]["CODI"]);

                if (maximo == "")
                {
                    textBox1.Text = "1";
                }

                if (maximo != "" && ds.Tables[0].Rows.Count > 0)
                {
                    textBox1.Text = (Convert.ToInt32(ds.Tables[0].Rows[0]["CODI"]) + 1).ToString();
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Todavía no existían registros.");
            }
        }
        private void Rellenar_ListBox()
        {
            DataSet ds = Conexiones.Retorna_Datos("Select ID, Expediente, Titulo, Estado from obras where (Estado = 'ADJUDICADA' or Estado = 'EN EJECUCIÓN' or Estado = 'FINALIZADA' or Estado = 'OTROS')");

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
            listBox3.DataSource = Lista_todo;
        }

        List<string> Lista_desconcatenar = new List<string>();
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lista_desconcatenar.Clear();
            string curItem = listBox3.SelectedItem.ToString();
            int index = listBox3.FindString(curItem);
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

        string ID = "";
        string Exp = "";
        string Ti = "";
        List<string> Lista_ID_obras = new List<string>();
        List<string> Lista_Exp_obras = new List<string>();
        List<string> Lista_Ti_obras = new List<string>();

        private void button4_Click(object sender, EventArgs e)
        {
            string CODI = "";
            string Nombre = "";
            string Apellidos = "";
            string DNI = "";
            string Telefono = "";
            string Nivel = "";
            string Contrato = "";
            string EPIs = "";
            string Maquinaria = "";
            string Apto = "";
            string PRL = "";
            string Albañileria = "";
            string Hormigon = "";
            string Grua = "";
            string Plataformas = "";
            string Libre = "";
            string Obra = "";

            CODI = textBox1.Text;
            Nombre = textBox2.Text;
            Apellidos = textBox5.Text;
            DNI = textBox3.Text;
            Telefono = textBox4.Text;
            Nivel = listBox1.Text;
            Contrato = checkBox1.Checked.ToString();
            EPIs = checkBox2.Checked.ToString();
            Maquinaria = checkBox3.Checked.ToString();
            Apto = checkBox9.Checked.ToString();
            PRL = checkBox4.Checked.ToString();
            Albañileria = checkBox5.Checked.ToString();
            Hormigon = checkBox6.Checked.ToString();
            Grua = checkBox7.Checked.ToString();
            Plataformas = checkBox8.Checked.ToString();
            Libre = listBox2.Text;

            if (listBox2.Text == "SI")
            {
                Obra = "00";
            }
            else if (listBox2.Text == "NO")
            {
                Obra = textBox_ID.Text;
            }

            if (Libre == "NO")
            {
                if (listBox3.SelectedIndex == 0)
                {
                    MessageBox.Show("Si el trabajador NO está libre, debes asignarlo a una obra.");
                }
                else
                {
                    if (Convert.ToString(CODI) != "" && Nombre != "" && DNI != "" && Telefono != "" && Libre != "")
                    {
                        Conexiones.Ejecuta_Consulta("INSERT INTO trabajadores_obra (CODI, Nombre, Apellidos, DNI, Telefono, Nivel, Contrato, EPIs, Maquinaria, Apto, PRL, Albañileria, Hormigon, Grua, Plataformas, Libre, Obra_asignada) " +
                            "VALUES ('" + CODI + "', '" + Nombre + "', '" + Apellidos + "', '" + DNI + "','" + Telefono + "', '" + Nivel + "', '" + Contrato + "', '" + EPIs + "', '" + Maquinaria + "', '" + Apto + "', '" + PRL + "', '" + Albañileria + "','" + Hormigon + "', '" + Grua + "', '" + Plataformas + "', '" + Libre + "', '" + Obra + "')");

                        MessageBox.Show("Registro guardado correctamente.");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Debes insertar nombre, DNI, teléfono y si el trabajador no está asignado a una obra (Libre).");
                        return;
                    }
                }
            }
            else
            {
                if (Convert.ToString(CODI) != "" && Nombre != "" && DNI != "" && Telefono != "" && Libre != "")
                {
                    Conexiones.Ejecuta_Consulta("INSERT INTO trabajadores_obra (CODI, Nombre, Apellidos, DNI, Telefono, Nivel, Contrato, EPIs, Maquinaria, Apto, PRL, Albañileria, Hormigon, Grua, Plataformas, Libre, Obra_asignada) " +
                        "VALUES ('" + CODI + "', '" + Nombre + "', '" + Apellidos + "', '" + DNI + "','" + Telefono + "', '" + Nivel + "', '" + Contrato + "', '" + EPIs + "', '" + Maquinaria + "', '" + Apto + "', '" + PRL + "', '" + Albañileria + "','" + Hormigon + "', '" + Grua + "', '" + Plataformas + "', '" + Libre + "', '" + Obra + "')");

                    MessageBox.Show("Registro guardado correctamente.");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debes insertar nombre, DNI, teléfono y si el trabajador no está asignado a una obra (Libre).");
                    return;
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Text == "SI")
            {
                listBox3.Enabled = false;
            }
            else if (listBox2.Text == "NO")
            {
                listBox3.Enabled = true;
            }
        }
    }
}
