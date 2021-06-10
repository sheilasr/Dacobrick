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
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
            Cargar_Grid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form4")
                {
                    Application.OpenForms["Form4"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form4();
                frm.ShowDialog();
                Cargar_Grid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cargar_Grid()
        {
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM obras ORDER BY ID");
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
                    string ID_Eliminar = Convert.ToString(dataGridView1.Rows[NumFila].Cells[0].Value);
                    //Eliminar
                    if (e.ColumnIndex == 9)
                    {
                        DialogResult resp = MessageBox.Show("¿Seguro que deseas eliminar el registro?", "¡ALERTA!", MessageBoxButtons.YesNo);

                        if (resp == DialogResult.Yes)
                        {
                            string SQL = "DELETE FROM obras where ID = '" + ID_Eliminar + "'";
                            Conexiones.Ejecuta_Consulta("DELETE FROM obras where ID = '" + ID_Eliminar + "'");

                            MessageBox.Show("Eliminado correctamente.");
                            this.Close();
                        }
                    }
                    //Editar
                    if (e.ColumnIndex == 8)
                    {
                        string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string expediente = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string titulo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                        Variables_Globales.id = id;
                        Variables_Globales.expediente = expediente;
                        Variables_Globales.titulo = titulo;
                        Variables_Globales.Form4_Desde = "FORM3";

                        Form4 frm = new Form4();
                        frm.ShowDialog();
                        Cargar_Grid();

                        Variables_Globales.Form4_Desde = "";

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
