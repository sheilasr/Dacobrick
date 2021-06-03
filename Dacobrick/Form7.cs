using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dacobrick
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Cargar_Grid_Horas();
            Cargar_Chart();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form15")
                {
                    Application.OpenForms["Form15"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form15();
                frm.ShowDialog();
                Cargar_Grid_Horas();
                Cargar_Chart();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Cargar_Grid_Horas()
        {
            DataSet ds = Conexiones.Retorna_Datos("select * from horas ORDER BY COD_Horas");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Cargar_Chart()
        {
            //String SQL = "SELECT TITULO, YEAR(Fecha) AS yyyy, MONTHNAME(Fecha) as mm, SUM(Total) AS Su FROM horas " +
            //    "GROUP BY TITULO, YEAR(Fecha), MONTH(Fecha)";
            String SQL = "SELECT TITULO, SUM(Total) AS Su FROM horas GROUP BY TITULO";
            DataSet ds = Conexiones.Retorna_Datos(SQL);

            DataTable firstTable = ds.Tables[0];

            chart1.Series.Clear();

            chart1.Titles.Add("HORAS REALIZADAS POR OBRAS");
            foreach (DataRow row in firstTable.Rows)
            {
                Series series = chart1.Series.Add(row["TITULO"].ToString());
                series.Points.Add(Convert.ToDouble(row["Su"].ToString()));
                series.Label = row["Su"].ToString();
            }

            

        }
    }
}
