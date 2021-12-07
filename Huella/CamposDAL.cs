using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Huella
{
    public class CamposDAL
    {



        public static int Agre(Campos pcampos) //agregar un id de empleado en el from de depilacion
        {
            int retorno = 0;
            using (MySqlConnection Conn = Bdcomun.realiazarconexion())
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into datos(Nombre,Apellido_Paterno,Apellido_Materno,Edad,Puntaje) values ('{0}','{1}','{2}','{3}','{4}')",
                    pcampos.Nombre,pcampos.Apellido_Paterno,pcampos.Apellido_Materno,pcampos.Edad,pcampos.Puntaje), Conn);

                retorno = comando.ExecuteNonQuery();

                Conn.Close();

            }
            return retorno;
        }






    }
}
