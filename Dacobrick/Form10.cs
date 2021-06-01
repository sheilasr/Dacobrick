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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            Cargar_Grid_Trabajadores();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form16")
                {
                    Application.OpenForms["Form16"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form16();
                frm.ShowDialog();
                Cargar_Grid_Trabajadores();
            }
        }
        private void Cargar_Grid_Trabajadores()
        {
            //Conexiones.Ejecuta_Consulta("INSERT INTO obras (ID, Expediente, Titulo) VALUES ('2', '1', '1')");

            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM trabajadores_obra ORDER BY CODI");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    string ID_Eliminar = Convert.ToString(dataGridView1.Rows[NumFila].Cells[0].Value);
                    //Eliminar
                    if (e.ColumnIndex == 18)
                    {
                        DialogResult resp = MessageBox.Show("¿Seguro que deseas eliminar el registro?", "¡ALERTA!", MessageBoxButtons.YesNo);

                        if (resp == DialogResult.Yes)
                        {
                            string SQL = "DELETE FROM trabajadores_obra where CODI = '"+ID_Eliminar+"'";
                            Conexiones.Ejecuta_Consulta("DELETE FROM trabajadores_obra where CODI = '"+ ID_Eliminar+"'");

                            MessageBox.Show("Eliminado correctamente.");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando el registro indicado.");
            }
        }
    }
}
