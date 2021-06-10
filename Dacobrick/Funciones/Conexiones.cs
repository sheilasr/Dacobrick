using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dacobrick
{
    class Conexiones
    {

        public static void Ejecuta_Consulta(string SQL)
        {
            OdbcConnection cn = new OdbcConnection("dsn=DACO;uid=sheila;pwd=toor");

            try
            {
                OdbcCommand Cmd = new OdbcCommand(SQL, cn);

                if(cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }

                Cmd.CommandText = SQL;
                Cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch(Exception ex)
            {
               cn.Close();
            }
        }

        public static DataSet Retorna_Datos(string SQL)
        {
            OdbcConnection cn = new OdbcConnection("dsn=DACO;uid=sheila;pwd=toor");

            try
            {
                OdbcDataAdapter DA = new OdbcDataAdapter();
                DataSet ds = new DataSet();

                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }

                DA.SelectCommand = new OdbcCommand(SQL, cn);
                DA.Fill(ds, "0");
                cn.Close();

                return ds;
            }
            catch (Exception ex)
            {
                cn.Close();
                return null;
            }
        }

        public static void KeyPress_Entero(TextBox Caja, KeyPressEventArgs Arg, bool Negativo)
        {

            if (Negativo == true)
            {
                if (!char.IsControl(Arg.KeyChar) && !char.IsDigit(Arg.KeyChar) && (Arg.KeyChar != '-'))
                {
                    Arg.Handled = true;
                }

                // Solo un simbolo negativo y que sea el primero
                if ((Arg.KeyChar == '-') && ((Caja).Text.IndexOf('-') > -1))
                {
                    Arg.Handled = true;
                }
                else
                {
                    if ((Arg.KeyChar == '-') && (Caja).Text.Length > 0)
                    {
                        Arg.Handled = false;
                    }
                }
            }
            else
            {
                if (!char.IsControl(Arg.KeyChar) && !char.IsDigit(Arg.KeyChar))
                {
                    Arg.Handled = true;
                }
            }

            if (Arg.KeyChar == 13)
            {
                Arg.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        public static void KeyPress_Decimal(TextBox Caja, KeyPressEventArgs Arg, bool Negativo)
        {
            // Convierte puntos en comas
            if (Arg.KeyChar == 46)
            {
                Arg.KeyChar = Convert.ToChar(",");
            }

            if (Negativo == true)
            {
                // Solo números, coma o negativo
                if (!char.IsControl(Arg.KeyChar) && !char.IsDigit(Arg.KeyChar) && (Arg.KeyChar != ',') && (Arg.KeyChar != '-'))
                {
                    Arg.Handled = true;
                }

                // solo 1 punto decimal
                if ((Arg.KeyChar == ',') && ((Caja).Text.IndexOf(',') > -1))
                {
                    Arg.Handled = true;
                }

                // Solo un simbolo negativo y que sea el primero
                if ((Arg.KeyChar == '-') && ((Caja).Text.IndexOf('-') > -1))
                {
                    Arg.Handled = true;
                }
                else
                {
                    if ((Arg.KeyChar == '-') && (Caja).Text.Length > 0)
                    {
                        Arg.Handled = false;
                    }
                }
            }
            else
            {
                // Solo números, coma o negativo
                if (!char.IsControl(Arg.KeyChar) && !char.IsDigit(Arg.KeyChar) && (Arg.KeyChar != ','))
                {
                    Arg.Handled = true;
                }

                // solo 1 punto decimal
                if ((Arg.KeyChar == ',') && ((Caja).Text.IndexOf(',') > -1))
                {
                    Arg.Handled = true;
                }
            }

            if (Arg.KeyChar == 13)
            {
                Arg.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
