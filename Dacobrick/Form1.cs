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
    public partial class Form1 : Form
    {

        Label ppal;
        Label secun;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Label DACOBRICK
            //ppal = new Label();
            //ppal.Name = "DACOBRICK";
            //ppal.Text = "DACOBRICK ";
            //ppal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //ppal.AutoSize = true;
            //ppal.Location = new Point(((panel1.Width - ppal.Width) / 2) - (ppal.Width), panel1.Height - 200);
            //ppal.BackColor = Color.Green;
            //ppal.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //ppal.ForeColor = System.Drawing.Color.Orange;
            //ppal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            //| System.Windows.Forms.AnchorStyles.Left)
            //| System.Windows.Forms.AnchorStyles.Right)));
            //panel1.Controls.Add(ppal);

            //Label Construye
            //secun = new Label();
            //secun.Name = "Construye";
            //secun.Text = "  ¡Construye tu mundo!  ";
            //secun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //secun.AutoSize = true;
            //secun.Location = new Point(((panel1.Width - secun.Width) / 2) - (secun.Width), panel1.Height - 100);
            //secun.BackColor = Color.Red;
            //secun.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //secun.ForeColor = System.Drawing.Color.Black;
            //secun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            //| System.Windows.Forms.AnchorStyles.Left)
            //| System.Windows.Forms.AnchorStyles.Right)));
            //panel1.Controls.Add(secun);
        }

        public void Diseño_ppal()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.Show();
        }
    }
}
