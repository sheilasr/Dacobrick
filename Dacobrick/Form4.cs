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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Buscar_ID();
            Cargar_Grid_Planificacion();
            Cargar_Grid_Compras();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comprobar_Exp_Tit();
            Comprobar_Est();
            Comprobar_IVA();

            int ID;
            string Expediente = "";
            string Titulo = "";
            string Direccion = "";
            string Poblacion = "";
            string CP;
            string Estado = "";
            string Importe = "";
            string IVA = "";
            string Total = "";
            string Promotor = "";
            string Fecha_inicio = "";
            string Fecha_fin = "";
            string Duracion = "";
           
            ID = Convert.ToInt32(textBox1.Text);
            Expediente = textBox2.Text;
            Titulo = textBox3.Text;
            Direccion = textBox4.Text;
            Poblacion = textBox5.Text;
            CP = textBox6.Text;
            Estado = listBox1.Text;
            Importe = textBox8.Text;
            IVA = listBox2.Text;
            Total = textBox10.Text;
            Promotor = textBox11.Text;
            Fecha_inicio = dateTimePicker1.Text;
            Fecha_fin = dateTimePicker2.Text;
            Duracion = textBox14.Text;

            if(textBox2.Text != "" && textBox3.Text != "")
            {

                Conexiones.Ejecuta_Consulta("INSERT INTO obras (ID, Expediente, Titulo, Direccion, Poblacion, CP, Estado, Importe, IVA, Total, Promotor, Fecha_inicio, Fecha_fin, Duracion) " +
                    "VALUES ('" + ID + "', '" + Expediente + "', '" + Titulo + "', '" + Direccion + "', '" + Poblacion + "', '" + CP + "', '" + Estado + "', '" + Importe + "', '" + IVA + "', '" + Total + "', '" + Promotor + "', '" + Fecha_inicio + "', '" + Fecha_fin + "', '" + Duracion + "')");

                textBox15.Text = Convert.ToString(ID);
                textBox16.Text = Expediente;
                textBox17.Text = Titulo;

                MessageBox.Show("Registro guardado correctamente.");

                tabControl1.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Recuerda completar el EXPEDIENTE y el TÍTULO.");
            }

        }

        private void Comprobar_Exp_Tit()
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Es obligatorio completar el EXPEDIENTE.");
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Es obligatorio completar el TÍTULO.");
            }

        }

        private void Comprobar_Est()
        {
            if (listBox1.Text == "")
            {
                string mensaje = "¿Quieres guardar la obra sin especificar su ESTADO?";
                string alerta = "ALERTA";
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(this, mensaje, alerta, botones, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("OK");
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Complete el ESTADO.");
                        this.ActiveControl = listBox1;
                        break;
                }
            }
        }

        private void Comprobar_IVA()
        {
            if (listBox2.Text == "")
            {
                string mensaje = "¿Quieres guardar la obra sin especificar su IVA?";
                string alerta = "ALERTA";
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(this, mensaje, alerta, botones, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("OK");
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Complete el IVA.");
                        this.ActiveControl = listBox2;
                        break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            findListaInicio(groupBox1);
            findListaDurante(groupBox2);
            findListaFin(groupBox3);
            tabControl1.SelectedIndex = 3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Form11();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Form12();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form frm = new Form13();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar_ID()
        {
            string maximo = "";
            try
            {
                String SQL = "SELECT MAX(ID) as ID FROM obras";
                DataSet ds = Conexiones.Retorna_Datos(SQL);
                maximo = Convert.ToString(ds.Tables[0].Rows[0]["ID"]);

                if (maximo == "")
                {
                    textBox1.Text = "0";
                }

                if (maximo != "" && ds.Tables[0].Rows.Count > 0)
                {
                    textBox1.Text = (Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]) + 1).ToString();
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Todavía no existían registros.");
            }
        }

        private void Cargar_Grid_Planificacion()
        {
            Variables_Globales.Identificador_obra = textBox1.Text;
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM planificacion where ID_OBRA = '" + Variables_Globales.Identificador_obra + "'");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
        }

        //private void Refrescar_Planificacion(Object sender, FormClosingEventArgs form11)
        //{
        //    if(Form11.FormClo)
        //    dataGridView1.Refresh();
        //}

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        List<CheckBoxInicio> Lista_Doc_Inicio;
        public void findListaInicio(GroupBox group)
        {
            Lista_Doc_Inicio = new List<CheckBoxInicio>();
            foreach (Control control in group.Controls)
            {
                CheckBoxInicio box = new CheckBoxInicio();
                if (control.GetType() == typeof(CheckBox))
                {
                    box.name = control.Name;
                    box.status = ((CheckBox)control).Checked ? 1 : 0;
                    Lista_Doc_Inicio.Add(box);
                }

                for (int i = 0; i < Lista_Doc_Inicio.Count; i++)
                {
                    string name = box.name;
                    int status = box.status;
                    //Conexiones.Ejecuta_Consulta("INSERT INTO doc_inicio (IDM Expediente, Titulo, Direccion, Poblacion, CP, Estado, Importe, IVA, Total, Promotor, Fecha_inicio, Fecha_fin, Duracion) " +
                    //    "VALUES ('" + ID + "', '" + Expediente + "', '" + Titulo + "', '" + Direccion + "', '" + Poblacion + "', '" + CP + "', '" + Estado + "', '" + Importe + "', '" + IVA + "', '" + Total + "', '" + Promotor + "', '" + Fecha_inicio + "', '" + Fecha_fin + "', '" + Duracion + "')");

                }
            }


            //if (Lista_Doc_Inicio.Count > 0)
            //{
            //    Conexiones.Ejecuta_Consulta("INSERT INTO doc_inicio (IDM Expediente, Titulo, Direccion, Poblacion, CP, Estado, Importe, IVA, Total, Promotor, Fecha_inicio, Fecha_fin, Duracion) " +
            //        "VALUES ('" + ID + "', '" + Expediente + "', '" + Titulo + "', '" + Direccion + "', '" + Poblacion + "', '" + CP + "', '" + Estado + "', '" + Importe + "', '" + IVA + "', '" + Total + "', '" + Promotor + "', '" + Fecha_inicio + "', '" + Fecha_fin + "', '" + Duracion + "')");

            //    tabControl1.SelectedIndex = 1;
            //}

        }

        List<CheckBoxInicio> Lista_Doc_Durante;
        public void findListaDurante(GroupBox group)
        {
            Lista_Doc_Durante = new List<CheckBoxInicio>();
            foreach (Control control in group.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    CheckBoxInicio box = new CheckBoxInicio();
                    box.name = control.Name;
                    box.status = ((CheckBox)control).Checked ? 1 : 0;
                    Lista_Doc_Durante.Add(box);
                }
            }
        }

        List<CheckBoxInicio> Lista_Doc_Fin;
        public void findListaFin(GroupBox group)
        {
            Lista_Doc_Fin = new List<CheckBoxInicio>();
            foreach (Control control in group.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    CheckBoxInicio box = new CheckBoxInicio();
                    box.name = control.Name;
                    box.status = ((CheckBox)control).Checked ? 1 : 0;
                    Lista_Doc_Fin.Add(box);
                }
            }
        }

        private void Cargar_Grid_Compras()
        {
            Variables_Globales.Identificador_obra = textBox1.Text;
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM facturas where ID_OBRA = '" + Variables_Globales.Identificador_obra + "'");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conexiones.KeyPress_Entero((TextBox)textBox6, e, false);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conexiones.KeyPress_Entero((TextBox)textBox14, e, false);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conexiones.KeyPress_Decimal((TextBox)textBox8, e, false);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conexiones.KeyPress_Decimal((TextBox)textBox10, e, false);
        }
    }
}
