using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Huella.Properties;
using System.Configuration;
using System.Data;


namespace Huella
{
   public class Bdcomun
    {


        public static string Obtenerstring()
        {
            return Settings.Default.encuestaConnectionString;
        }


        public static MySqlConnection realiazarconexion()
        {
            MySqlConnection conn = new MySqlConnection(Obtenerstring());
            conn.Open();
            return conn;
        }


        public class Vizualizadordatagrid //instruccion de vizualizacion en el data grid
        {

            // clase de instancia para ver los datos del data grid 
            string instruccion;
            public DataTable VistaTabla()
            {


                instruccion = "Select * from datos";
                MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, Bdcomun.realiazarconexion());
                DataTable COnsulta = new DataTable();
                adp.Fill(COnsulta);
                return COnsulta;

            }


        }



    }
}
