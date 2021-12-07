using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Huella
{
    public class puntajeDAl
    {



        public static int Agre(puntaje ppuntaje) 
        {
            int retorno = 0;
            using (MySqlConnection Conn = Bdcomun.realiazarconexion())
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into datos(Puntaje) values('{-1}')",
                    ppuntaje.Puntaje), Conn);

                retorno = comando.ExecuteNonQuery();

                Conn.Close();

            }
            return retorno;
        }




    }
}
