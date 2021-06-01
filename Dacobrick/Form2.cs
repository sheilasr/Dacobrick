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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form3")
                {
                    Application.OpenForms["Form3"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form3();
                frm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form5")
                {
                    Application.OpenForms["Form5"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form5();
                frm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form8")
                {
                    Application.OpenForms["Form8"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form8();
                frm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form9")
                {
                    Application.OpenForms["Form9"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form9();
                frm.Show();
            }
        }


    }
}
