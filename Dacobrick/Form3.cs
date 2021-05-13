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
            Conexiones.Ejecuta_Consulta("INSERT INTO obras (ID, Expediente, Titulo) VALUES ('2', '1', '1')");

            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM obras");

        }
    }
}
