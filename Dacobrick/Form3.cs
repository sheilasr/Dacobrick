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
            Form frm = new Form4();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cargar_Grid()
        {
            //Conexiones.Ejecuta_Consulta("INSERT INTO obras (ID, Expediente, Titulo) VALUES ('2', '1', '1')");

            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM obras");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
        }

        int NumFila = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            //try
            //{
            //    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            //    {
            //        NumFila = e.RowIndex;

            //        dataGridView1.CurrentCell = dataGridView1[0, NumFila];

            //        // Editar
            //        if (e.ColumnIndex == 8)
            //        {
            //            Enlazar_Datos();

            //            Barra_Txt_Estado.Text = "MODIFICAR";
            //            Bloquear_Controles(false);
            //            Activar_Botones_Barra("MODIFICAR");

            //            Txt_Nombre.Focus();
            //            Txt_Codigo.Enabled = false;
            //            Ficha.SelectedIndex = 1;
            //        }

            //        //Eliminar
            //        if (e.ColumnIndex == 9)
            //        {
            //            return;

            //            int ID = 
            //            List<ColumnaSQL> Valores = new List<ColumnaSQL>();
            //            List<ColumnaSQL> Condicion = new List<ColumnaSQL>();

            //            DialogResult resp = MessageBox.Show("¿Seguro que desea elimnar el registro?", "IT&P ERP", MessageBoxButtons.YesNo);

            //            if (resp == DialogResult.Yes)
            //            {
            //                DataSet ds = Funciones.Retorna_Datos("SELECT * FROM ARTIC WHERE CodTipo = '" + GridView_Lista[0, e.RowIndex].Value + "'", false, "");

            //                if (ds == null)
            //                    return;

            //                if (ds.Tables[0].Rows.Count > 0)
            //                {
            //                    if (Comprobar_Si_Puede_Eliminar(ds.Tables[0].Rows[0]["CodTipo"].ToString()) == false)
            //                    {
            //                        MessageBox.Show("El registro no se puede eliminar porque está siendo utilizado.", "IT&P ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                        return;
            //                    }

            //                    Valores.Clear();
            //                    Valores.Add(new ColumnaSQL("CodTipo", Convert.ToInt32(ds.Tables[0].Rows[0]["CodTipo"].ToString()), OdbcType.Int));

            //                    Funciones.Ejecuta_Consulta_Delete("ARTIC", Valores);

            //                    Funciones.Insertar_Accion_En_Control_Usuario("ELIMINAR", this.Text, Txt_Codigo.Text, Txt_Nombre.Text, "");
            //                }
            //            }

            //            Buscar("", "");
            //            Vaciar_Campos();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show ("Se ha producido un error al editar/borrar la obra seleccionada.")
            //}
        }
    }
}
