using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huella
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnregistrar_Click(object sender, EventArgs e)
        {


          
                Inicio r = new Inicio();
                r.Show();
                this.Hide();


            }


        


    
    }
}
