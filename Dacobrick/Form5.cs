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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form6")
                {
                    Application.OpenForms["Form6"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form6();
                frm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form7")
                {
                    Application.OpenForms["Form7"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form7();
                frm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
