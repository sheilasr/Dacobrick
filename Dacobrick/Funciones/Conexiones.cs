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
        //public static void ConnectarBBDD()
        //{
        //    //SqlConnection conexion = new SqlConnection("server=LAPTOP-TVSLTJ8L ; database=dacobrick ; integrated security = true");
        //    //conexion.Open();
        //    //MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
        //    //conexion.Close();
        //    //MessageBox.Show("Se cerró la conexión.");
        //    //string MyConString = "DRIVER={MySQL ODBC 3.51 Driver};" +
        //    //                      "SERVER=localhost;" +
        //    //                      "DATABASE=dacobrick;" +
        //    //                      "UID=root;" +
        //    //                      "PASSWORD=toor;" +
        //    //                      "OPTION=3";

        //    ////Connect to MySQL using Connector/ODBC
        //    //OdbcConnection MyConnection = new OdbcConnection(MyConString);
        //    //MyConnection.Open();


        //    ////Create a sample table
        //    //OdbcCommand MyCommand =
        //    //  new OdbcCommand("DROP TABLE IF EXISTS my_odbc_net",
        //    //                  MyConnection);
        //    //MyCommand.ExecuteNonQuery();
        //    //MyCommand.CommandText =
        //    //  "CREATE TABLE my_odbc_net(id int, name varchar(20), idb bigint)";
        //    //MyCommand.ExecuteNonQuery();

        //    ////Insert
        //    //MyCommand.CommandText =
        //    //  "INSERT INTO my_odbc_net VALUES(10,'venu', 300)";
        //    //Console.WriteLine("INSERT, Total rows affected:" +
        //    //                  MyCommand.ExecuteNonQuery()); ;


        //    //OdbcDataReader MyDataReader;
        //    //MyDataReader = MyCommand.ExecuteReader();
        //    //while (MyDataReader.Read())
        //    //{
        //    //    if (string.Compare(MyConnection.Driver, "myodbc3.dll") == 0)
        //    //    {
        //    //        //Supported only by Connector/ODBC 3.51
        //    //        Console.WriteLine("Data:" + MyDataReader.GetInt32(0) + " " +
        //    //                          MyDataReader.GetString(1) + " " +
        //    //                          MyDataReader.GetInt64(2));
        //    //    }
        //    //    else
        //    //    {
        //    //        //BIGINTs not supported by Connector/ODBC
        //    //        Console.WriteLine("Data:" + MyDataReader.GetInt32(0) + " " +
        //    //                          MyDataReader.GetString(1) + " " +
        //    //                          MyDataReader.GetInt32(2));
        //    //    }
        //    //}

        //    ////Close all resources
        //    //MyDataReader.Close();
        //    //MyConnection.Close();

        //    MySql.Data.MySqlClient.MySqlConnection conn;
        //    string myConnectionString;

        //    myConnectionString = "server=localhost;uid=root;pwd=toor;database=dacobrick;";

        //    try
        //    {
        //        conn = new MySql.Data.MySqlClient.MySqlConnection();
        //        conn.ConnectionString = myConnectionString;
        //        conn.Open();
        //        MySqlConnection MyConn2 = new MySqlConnection();

        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
        //        MySqlDataReader MyReader2;
        //        MyConn2.Open();
        //        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
        //        MessageBox.Show("Save Data");
        //        while (MyReader2.Read())
        //        {
        //        }
        //        MyConn2.Close();

        //    }
        //    catch (MySql.Data.MySqlClient.MySqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

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
