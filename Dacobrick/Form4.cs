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
        //public Form4(string id, string expediente, string titulo)
        {
            //Id = id;
            //Expediente = expediente;
            //Titulo = titulo;

            InitializeComponent();

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (Variables_Globales.Form4_Desde == "FORM3")
            {
                textBox15.Text = Variables_Globales.id;
                textBox16.Text = Variables_Globales.expediente;
                textBox17.Text = Variables_Globales.titulo;

                Cargar_Obra();
                Cargar_Grid_Planificacion();
                Cargar_Grid_Compras();
                Cargar_Inicio();
                Cargar_Durante();
                Cargar_Fin();
                Cargar_Grid_Trabajadores();
            }
            else
            {
                Buscar_ID();
                Cargar_Grid_Planificacion();
                Cargar_Grid_Compras();
                Cargar_Grid_Trabajadores();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string ID = "";
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

            ID = textBox1.Text;
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

            if (textBox2.Text != "" && textBox3.Text != "" && listBox2.Text != "" && listBox1.Text != "")
            {
                string SQL = "INSERT INTO obras (ID, Expediente, Titulo, Direccion, Poblacion, CP, Estado, Importe, IVA, Total, Promotor, Fecha_inicio, Fecha_fin, Duracion) " +
                    "VALUES ('" + ID + "', '" + Expediente + "', '" + Titulo + "', '" + Direccion + "', '" + Poblacion + "', '" + CP + "', '" + Estado + "', '" + Importe + "', '" + IVA + "', '" + Total + "', '" + Promotor + "', '" + Fecha_inicio + "', '" + Fecha_fin + "', '" + Duracion + "')";

                Conexiones.Ejecuta_Consulta("INSERT INTO obras (ID, Expediente, Titulo, Direccion, Poblacion, CP, Estado, Importe, IVA, Total, Promotor, Fecha_inicio, Fecha_fin, Duracion) " +
                    "VALUES ('" + ID + "', '" + Expediente + "', '" + Titulo + "', '" + Direccion + "', '" + Poblacion + "', '" + CP + "', '" + Estado + "', '" + Importe + "', '" + IVA + "', '" + Total + "', '" + Promotor + "', '" + Fecha_inicio + "', '" + Fecha_fin + "', '" + Duracion + "')");

                textBox15.Text = ID;
                textBox16.Text = Expediente;
                textBox17.Text = Titulo;

                MessageBox.Show("Registro guardado correctamente.");

                tabControl1.SelectedIndex = 1;
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Es obligatorio completar el EXPEDIENTE.");
                }

                if (textBox3.Text == "")
                {
                    MessageBox.Show("Es obligatorio completar el TÍTULO.");
                }

                if (listBox1.Text == "")
                {
                    MessageBox.Show("Es obligatorio completar el ESTADO.");
                }

                if (listBox2.Text == "")
                {
                    MessageBox.Show("Es obligatorio completar el IVA.");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guardar_Inicio();
            Guardar_Durante();
            Guardar_Final();
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
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form11")
                {
                    Application.OpenForms["Form11"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form11();
                frm.ShowDialog();
                Cargar_Grid_Planificacion();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form12")
                {
                    Application.OpenForms["Form12"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form12();
                frm.ShowDialog();
                Cargar_Grid_Trabajadores();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool Abierto = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "Form13")
                {
                    Application.OpenForms["Form13"].Close();
                }
            }
            if (Abierto == false)
            {
                Form frm = new Form13();
                frm.Show();
                Cargar_Grid_Compras();
            }
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
                    textBox1.Text = "1";
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
            Variables_Globales.id = textBox15.Text;
            string SQL = "SELECT * FROM planificacion where ID_OBRA = '" + Variables_Globales.id + "'";
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM planificacion where ID_obra = '" + Variables_Globales.id + "' ORDER BY ID");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void Cargar_Grid_Trabajadores()
        {
            Variables_Globales.id = textBox15.Text;
            string SQL = "SELECT * FROM trabajadores_obra where Obra_asignada = '" + Variables_Globales.id + "'";
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM trabajadores_obra where Obra_asignada = '" + Variables_Globales.id + "' ORDER BY CODI");
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = ds.Tables[0];
        }
        //private void Refrescar_Planificacion(Object sender, FormClosingEventArgs form11)
        //{
        //    if(Form11.FormClo)
        //    dataGridView1.Refresh();
        //}

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        private void Guardar_Inicio()
        {
            Variables_Globales.id = textBox15.Text;

            String SQL = "SELECT * from doc_inicio where ID = '" + Variables_Globales.id + "' ORDER BY CODIGO ";
            DataSet ds = Conexiones.Retorna_Datos(SQL);

            string ID = "";
            string CF = "";
            string PC = "";
            string EG = "";
            string LO = "";
            string AP = "";
            string NP = "";
            string LD = "";
            string PSS = "";
            string LC = "";
            string AC = "";
            string LI = "";
            string PGR = "";
            string LS = "";
            string PG = "";
            string AR = "";

            ID = Convert.ToString(textBox15.Text);
            CF = checkBox1.Checked.ToString();
            PC = checkBox2.Checked.ToString();
            EG = checkBox3.Checked.ToString();
            LO = checkBox4.Checked.ToString();
            AP = checkBox5.Checked.ToString();
            NP = checkBox6.Checked.ToString();
            LD = checkBox7.Checked.ToString();
            PSS = checkBox8.Checked.ToString();
            LC = checkBox9.Checked.ToString();
            AC = checkBox10.Checked.ToString();
            LI = checkBox11.Checked.ToString();
            PGR = checkBox12.Checked.ToString();
            LS = checkBox13.Checked.ToString();
            PG = checkBox14.Checked.ToString();
            AR = checkBox15.Checked.ToString();

            string SQL2 = "INSERT INTO doc_inicio (ID, CF, PC, EG, LO, AP, NP, LD, PSS, LC, AC, LI, PGR, LS, PG, AR) " +
                "VALUES ('" + ID + "', '" + CF + "', '" + PC + "', '" + EG + "','" + LO + "', '" + AP + "', '" + NP + "', '" + LD + "', '" + PSS + "', '" + LC + "', '" + AC + "', '" + LI + "','" + PGR + "', '" + LS + "', '" + PG + "', '" + AR + "')";

            if(ds.Tables[0].Rows.Count > 0)
            {
                Conexiones.Ejecuta_Consulta("UPDATE doc_inicio set CF = '" + CF + "', PC = '" + PC + "', EG = '" + EG + "', LO = '" + LO + "'," +
                    " AP = '" + AP + "', NP = '" + NP + "', LD = '" + LD + "', PSS = '" + PSS + "', LC = '" + LC + "', AC = '" + AC + "', " +
                    "LI = '" + LI + "', PGR = '" + PGR + "', LS = '" + LS + "', PG = '" + PG + "', AR =  '" + AR + "' where ID = '"+ Variables_Globales.id +"'");

            }
            else
            {
                Conexiones.Ejecuta_Consulta("INSERT INTO doc_inicio (ID, CF, PC, EG, LO, AP, NP, LD, PSS, LC, AC, LI, PGR, LS, PG, AR) " +
                    "VALUES ('" + ID + "', '" + CF + "', '" + PC + "', '" + EG + "','" + LO + "', '" + AP + "', '" + NP + "', '" + LD + "', '" + PSS + "', '" + LC + "', '" + AC + "', '" + LI + "','" + PGR + "', '" + LS + "', '" + PG + "', '" + AR + "')");

            }
            //Conexiones.Ejecuta_Consulta("INSERT INTO doc_inicio (ID, CF, PC, EG, LO, AP, NP, LD, PSS, LC, AC, LI, PGR, LS, PG, AR) " +
            //    "VALUES ('" + ID + "', '" + CF + "', '" + PC + "', '" + EG + "','" + LO + "', '" + AP + "', '" + NP + "', '" + LD + "', '" + PSS + "', '" + LC + "', '" + AC + "', '" + LI + "','" + PGR + "', '" + LS + "', '" + PG + "', '" + AR + "')");

        }

        private void Guardar_Durante()
        {
            Variables_Globales.id = textBox15.Text;

            String SQL = "SELECT * from doc_durante where ID = '" + Variables_Globales.id + "'";
            DataSet ds = Conexiones.Retorna_Datos(SQL);

            string ID = "";
            string DC = "";
            string DE = "";
            string DF = "";
            string DP = "";
            string DCARP = "";
            string DA = "";
            string DI = "";
            string DINS = "";
            string DR = "";
            string DEQ = "";

            ID = Convert.ToString(textBox15.Text);
            DC = checkBox16.Checked.ToString();
            DE = checkBox17.Checked.ToString();
            DF = checkBox18.Checked.ToString();
            DP = checkBox19.Checked.ToString();
            DCARP = checkBox20.Checked.ToString();
            DA = checkBox21.Checked.ToString();
            DI = checkBox22.Checked.ToString();
            DINS = checkBox23.Checked.ToString();
            DR = checkBox24.Checked.ToString();
            DEQ = checkBox25.Checked.ToString();

            if (ds.Tables[0].Rows.Count > 0)
            {
                Conexiones.Ejecuta_Consulta("UPDATE doc_durante set DC = '" + DC + "', DE = '" + DE + "', DF = '" + DF + "', DP = '" + DP + "'," +
                    " DCARP = '" + DCARP + "', DA = '" + DA + "', DI = '" + DI + "', DINS = '" + DINS + "', DR = '" + DR + "', DEQ = '" + DEQ + "'" +
                    " where ID = '" + Variables_Globales.id + "'");

            }else {
                Conexiones.Ejecuta_Consulta("INSERT INTO doc_durante (ID, DC, DE, DF, DP, DCARP, DA, DI, DINS, DR, DEQ) " +
                    "VALUES ('" + ID + "', '" + DC + "', '" + DE + "', '" + DF + "','" + DP + "', '" + DCARP + "', '" + DA + "', '" + DI + "', '" + DINS + "', '" + DR + "', '" + DEQ + "')");
            }

        }

        private void Guardar_Final()
        {
            Variables_Globales.id = textBox15.Text;

            String SQL = "SELECT * from doc_fin where ID = '" + Variables_Globales.id + "'";
            DataSet ds = Conexiones.Retorna_Datos(SQL);

            string ID = "";
            string LF = "";
            string CF = "";
            string AREC = "";
            string CEE = "";

            ID = Convert.ToString(textBox15.Text);
            LF = checkBox26.Checked.ToString();
            CF = checkBox27.Checked.ToString();
            AREC = checkBox28.Checked.ToString();
            CEE = checkBox29.Checked.ToString();

            if (ds.Tables[0].Rows.Count > 0)
            {
                Conexiones.Ejecuta_Consulta("UPDATE doc_fin set LF = '" + LF + "', CF = '" + CF + "', AREC = '" + AREC + "', CEE = '" + CEE + "' where ID = '" + Variables_Globales.id + "'");

            }
            else
            {
                Conexiones.Ejecuta_Consulta("INSERT INTO doc_fin (ID, LF, CF, AREC, CEE) " +
                    "VALUES ('" + ID + "', '" + LF + "', '" + CF + "', '" + AREC + "','" + CEE + "')");

            }

        }

        private void Cargar_Grid_Compras()
        {
            Variables_Globales.Identificador_obra = textBox1.Text;
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM facturas where ID_OBRA = '" + Variables_Globales.Identificador_obra + "'");
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = ds.Tables[0];
        }


        private void Cargar_Obra()
        {
            Variables_Globales.id = textBox15.Text;
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM obras where ID = '"+ Variables_Globales.id +"'");
            textBox1.Text = Convert.ToString(ds.Tables[0].Rows[0]["ID"]);
            textBox2.Text = Convert.ToString(ds.Tables[0].Rows[0]["Expediente"]);
            textBox3.Text = Convert.ToString(ds.Tables[0].Rows[0]["Titulo"]);
            textBox4.Text = Convert.ToString(ds.Tables[0].Rows[0]["Direccion"]);
            textBox5.Text = Convert.ToString(ds.Tables[0].Rows[0]["Poblacion"]);
            textBox6.Text = Convert.ToString(ds.Tables[0].Rows[0]["CP"]);
            listBox1.Text = Convert.ToString(ds.Tables[0].Rows[0]["Estado"]);
            textBox8.Text = Convert.ToString(ds.Tables[0].Rows[0]["Importe"]);
            listBox2.Text = Convert.ToString(ds.Tables[0].Rows[0]["IVA"]);
            textBox10.Text = Convert.ToString(ds.Tables[0].Rows[0]["Total"]);
            textBox11.Text = Convert.ToString(ds.Tables[0].Rows[0]["Promotor"]);
            dateTimePicker1.Text = Convert.ToString(ds.Tables[0].Rows[0]["Fecha_inicio"]);
            dateTimePicker2.Text = Convert.ToString(ds.Tables[0].Rows[0]["Fecha_fin"]);
            textBox14.Text = Convert.ToString(ds.Tables[0].Rows[0]["Duracion"]);

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            listBox1.Enabled = true;
            textBox8.Enabled = true;
            listBox2.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = false;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            textBox14.Enabled = true;
        }

        private void Cargar_Inicio()
        {
            Variables_Globales.id = textBox15.Text;
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM doc_inicio where ID = '" + Variables_Globales.id + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {
                string CF = Convert.ToString(ds.Tables[0].Rows[0]["CF"]);
                string PC = Convert.ToString(ds.Tables[0].Rows[0]["PC"]);
                string EG = Convert.ToString(ds.Tables[0].Rows[0]["EG"]);
                string LO = Convert.ToString(ds.Tables[0].Rows[0]["LO"]);
                string AP = Convert.ToString(ds.Tables[0].Rows[0]["AP"]);
                string NP = Convert.ToString(ds.Tables[0].Rows[0]["NP"]);
                string LD = Convert.ToString(ds.Tables[0].Rows[0]["LD"]);
                string PSS = Convert.ToString(ds.Tables[0].Rows[0]["PSS"]);
                string LC = Convert.ToString(ds.Tables[0].Rows[0]["LC"]);
                string AC = Convert.ToString(ds.Tables[0].Rows[0]["AC"]);
                string LI = Convert.ToString(ds.Tables[0].Rows[0]["LI"]);
                string PGR = Convert.ToString(ds.Tables[0].Rows[0]["PGR"]);
                string LS = Convert.ToString(ds.Tables[0].Rows[0]["LS"]);
                string PG = Convert.ToString(ds.Tables[0].Rows[0]["PG"]);
                string AR = Convert.ToString(ds.Tables[0].Rows[0]["AR"]);

                if (CF == "True")
                {
                    checkBox1.Checked = true;
                }
                if (PC == "True")
                {
                    checkBox2.Checked = true;
                }
                if (EG == "True")
                {
                    checkBox3.Checked = true;
                }
                if (LO == "True")
                {
                    checkBox4.Checked = true;
                }
                if (AP == "True")
                {
                    checkBox5.Checked = true;
                }
                if (NP == "True")
                {
                    checkBox6.Checked = true;
                }
                if (LD == "True")
                {
                    checkBox7.Checked = true;
                }
                if (PSS == "True")
                {
                    checkBox8.Checked = true;
                }
                if (LC == "True")
                {
                    checkBox9.Checked = true;
                }
                if (AC == "True")
                {
                    checkBox10.Checked = true;
                }
                if (LI == "True")
                {
                    checkBox11.Checked = true;
                }
                if (PGR == "True")
                {
                    checkBox12.Checked = true;
                }
                if (LS == "True")
                {
                    checkBox13.Checked = true;
                }
                if (PG == "True")
                {
                    checkBox14.Checked = true;
                }
                if (AR == "True")
                {
                    checkBox15.Checked = true;
                }
            }
        }

        private void Cargar_Durante()
        {
            Variables_Globales.id = textBox15.Text;
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM doc_durante where ID = '" + Variables_Globales.id + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {
                string DC = Convert.ToString(ds.Tables[0].Rows[0]["DC"]);
                string DE = Convert.ToString(ds.Tables[0].Rows[0]["DE"]);
                string DF = Convert.ToString(ds.Tables[0].Rows[0]["DF"]);
                string DP = Convert.ToString(ds.Tables[0].Rows[0]["DP"]);
                string DCARP = Convert.ToString(ds.Tables[0].Rows[0]["DCARP"]);
                string DA = Convert.ToString(ds.Tables[0].Rows[0]["DA"]);
                string DI = Convert.ToString(ds.Tables[0].Rows[0]["DI"]);
                string DINS = Convert.ToString(ds.Tables[0].Rows[0]["DINS"]);
                string DR = Convert.ToString(ds.Tables[0].Rows[0]["DR"]);
                string DEQ = Convert.ToString(ds.Tables[0].Rows[0]["DEQ"]);

                if (DC == "True")
                {
                    checkBox16.Checked = true;
                }
                if (DE == "True")
                {
                    checkBox17.Checked = true;
                }
                if (DF == "True")
                {
                    checkBox18.Checked = true;
                }
                if (DP == "True")
                {
                    checkBox19.Checked = true;
                }
                if (DCARP == "True")
                {
                    checkBox20.Checked = true;
                }
                if (DA == "True")
                {
                    checkBox21.Checked = true;
                }
                if (DI == "True")
                {
                    checkBox22.Checked = true;
                }
                if (DINS == "True")
                {
                    checkBox23.Checked = true;
                }
                if (DR == "True")
                {
                    checkBox24.Checked = true;
                }
                if (DEQ == "True")
                {
                    checkBox25.Checked = true;
                }
            }
          
        }

        private void Cargar_Fin()
        {
            Variables_Globales.id = textBox15.Text;
            DataSet ds = Conexiones.Retorna_Datos("SELECT * FROM doc_fin where ID = '" + Variables_Globales.id + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {

                string LF = Convert.ToString(ds.Tables[0].Rows[0]["LF"]);
                string CF = Convert.ToString(ds.Tables[0].Rows[0]["CF"]);
                string AREC = Convert.ToString(ds.Tables[0].Rows[0]["AREC"]);
                string CEE = Convert.ToString(ds.Tables[0].Rows[0]["CEE"]);


                if (LF == "True")
                {
                    checkBox26.Checked = true;
                }
                if (CF == "True")
                {
                    checkBox27.Checked = true;
                }
                if (AREC == "True")
                {
                    checkBox28.Checked = true;
                }
                if (CEE == "True")
                {
                    checkBox29.Checked = true;
                }
            }
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

        int NumFila = 0;
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    if (e.ColumnIndex == 5)
                    {
                        DialogResult resp = MessageBox.Show("¿Seguro que deseas eliminar al trabajador de esta obra?", "¡ALERTA!", MessageBoxButtons.YesNo);

                        if (resp == DialogResult.Yes)
                        {
                            string SQL = "UPDATE trabajadores_obra SET Libre = 'SI', Obra_asignada = '00' where CODI = '" + ID_Eliminar + "'";
                            Conexiones.Ejecuta_Consulta("UPDATE trabajadores_obra SET Libre = 'SI', Obra_asignada = '00' where CODI = '" + ID_Eliminar + "'");

                            MessageBox.Show("El trabador quedado LIBRE.");
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
