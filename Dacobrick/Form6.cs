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
using Variables;

namespace Dacobrick
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            Cargar_Grid_Gastos();
            Cargar_Chart();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form14")
                {
                    Application.OpenForms["Form14"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form14();
                frm.ShowDialog();
                Cargar_Grid_Gastos();
                Cargar_Chart();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cargar_Grid_Gastos()
        {
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM gastos ORDER BY COD_GASTOS");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
        }

        List<string> Obras_nombre = new List<string>();
        Series series;
        private void Cargar_Chart()
        {
            //String SQL = "SELECT YEAR(Fecha) AS yyyy, MONTHNAME(Fecha) as mm, SUM(Importe) AS Su FROM gastos " +
            //    "GROUP BY YEAR(Fecha), MONTH(Fecha)";

            String SQL = "SELECT TITULO, SUM(Importe) AS Su FROM gastos GROUP BY TITULO";
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
