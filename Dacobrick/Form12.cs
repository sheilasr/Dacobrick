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
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM trabajadores_obra where libre = 'SI'");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
