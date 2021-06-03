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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            Cargar_Grid_Trabajadores();
        }

        private void Cargar_Grid_Trabajadores()
        {
            string SQL = "SELECT * FROM trabajadores_obra where Libre = 'SI'";
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM trabajadores_obra where Libre = 'SI'");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
        }

        int NumFila = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            try
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                {
                    NumFila = e.RowIndex;

                    dataGridView1.CurrentCell = dataGridView1[0, NumFila];
                    string Trabajador = Convert.ToString(dataGridView1.Rows[NumFila].Cells[0].Value);
                    //Seleccionar
                    if (e.ColumnIndex == 3)
                    {
                        DialogResult resp = MessageBox.Show("¿Quieres añadir al trabajador a la obra " + Variables_Globales.id+ "?", "¡ALERTA!", MessageBoxButtons.YesNo);

                        if (resp == DialogResult.Yes)
                        {
                            string SQL = "UPDATE trabajadores_obra SET Libre = 'NO', Obra_asignada = '"+ Variables_Globales.id+ "' WHERE CODI =  '" + Trabajador + "'";
                            Conexiones.Ejecuta_Consulta("UPDATE trabajadores_obra SET Libre = 'NO', Obra_asignada = '" + Variables_Globales.id + "' WHERE CODI =  '" + Trabajador + "'");

                            MessageBox.Show("Añadido correctamente.");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modificando el registro indicado.");
            }
        }
    }
}
