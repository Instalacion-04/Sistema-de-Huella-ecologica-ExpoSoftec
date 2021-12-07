using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huella
{
   public  class Campos
    {

  
       public int id_persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public int Edad { get; set; }
        public double Puntaje { get; set; }
   

        public Campos() { }
        public Campos( int pid_persona,string pNombre, string pApellido_Paterno, string pApellido_Materno,int  pEdad,double pPuntaje)
        {
            this.id_persona = pid_persona;
            this.Nombre = pNombre;
            this.Apellido_Paterno = pApellido_Paterno;
            this.Apellido_Materno = pApellido_Materno;
            this.Edad = pEdad;
            this.Puntaje = pPuntaje;

        }



    }
}
