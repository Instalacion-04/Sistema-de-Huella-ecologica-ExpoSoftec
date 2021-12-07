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
    public partial class Inicio : Form
    {


        Bdcomun.Vizualizadordatagrid obje = new Bdcomun.Vizualizadordatagrid();

        public Inicio()
        {
            InitializeComponent();
        }

        double punto1;
        double punto2;
        double punto3;
        double punto4;
        double punto5;
        double punto6;
        double punto7;
        double punto8;
        double punto9;
        double punto10;
        double punto11;
        double punto12;
        double punto13;

        double puntof;




      
        private void button1_Click_1(object sender, EventArgs e)
        {



            Datos llamar = new Datos();

            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text) || String.IsNullOrWhiteSpace(textBox4.Text) || String.IsNullOrWhiteSpace(textBox5.Text) || String.IsNullOrWhiteSpace(textBox6.Text) || String.IsNullOrWhiteSpace(textBox7.Text) || String.IsNullOrWhiteSpace(textBox8.Text) || String.IsNullOrWhiteSpace(textBox9.Text) || String.IsNullOrWhiteSpace(textBox10.Text) || String.IsNullOrWhiteSpace(textBox11.Text) || String.IsNullOrWhiteSpace(textBox12.Text) || String.IsNullOrWhiteSpace(textBox13.Text) || String.IsNullOrWhiteSpace(textBox14.Text))
            {
                MessageBox.Show("Uno o mas Campos Vacios", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                llamar.minutos = Convert.ToDouble(textBox1.Text);

                punto1 = llamar.minutos * 2.13671 / 6000;



                llamar.costo = Convert.ToDouble(textBox2.Text);
                punto2 = llamar.costo / 0.976 * 0.41 / 6000;


                llamar.numfocos = Convert.ToInt32(textBox3.Text);
                punto3 = llamar.numfocos * 0.03042 / 6000;


                llamar.basura = Convert.ToDouble(textBox4.Text);
                punto4 = llamar.basura * 0.608333 / 6000;


                llamar.tamañotanque = Convert.ToDouble(textBox5.Text);

                llamar.tiempo = Convert.ToDouble(textBox6.Text);
                punto5 = (llamar.tamañotanque * llamar.tiempo) * 0.003 / 6000;

                llamar.papel = Convert.ToDouble(textBox7.Text);
                punto6 = llamar.papel * 0.414 / 6000;

                llamar.carton = Convert.ToDouble(textBox8.Text);
                punto7 = llamar.carton * 0.414 / 6000;

                llamar.televisor = Convert.ToDouble(textBox9.Text);
                punto8 = llamar.televisor * 0.0540 / 6000;

                llamar.persona = Convert.ToDouble(textBox10.Text);
                punto9 = llamar.persona * 3.700 / 6000;

                llamar.compu = Convert.ToDouble(textBox11.Text);
                punto10 = llamar.compu * 0.0193 / 6000;

                llamar.tortilla = Convert.ToDouble(textBox12.Text);
                punto11 = llamar.tortilla * 2.104 / 6000;

                llamar.lavadora = Convert.ToDouble(textBox13.Text);
                punto12 = llamar.lavadora * 5.41 / 6000;

                llamar.microonda = Convert.ToDouble(textBox14.Text);
                punto13 = llamar.microonda * 7.58 / 6000;


                puntof = punto1 + punto2 + punto3 + punto4 + punto5 + punto6 + punto7 + punto8 + punto9 + punto10 + punto11 + punto12 + punto13;

                txthuellae.Text = puntof.ToString();






                if (  String.IsNullOrWhiteSpace(txtnombre.Text) || String.IsNullOrWhiteSpace(txtapat.Text) || String.IsNullOrWhiteSpace(txtapmat.Text))
                {
                    MessageBox.Show("Uno o mas Campos Vacios", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {

                    Campos camp = new Campos();

                    
                    camp.Nombre = txtnombre.Text;
                    camp.Apellido_Paterno = txtapat.Text;
                    camp.Apellido_Materno = txtapmat.Text;
                    camp.Edad =Convert.ToInt32( txtedad.Text);
                   camp.Puntaje = Convert.ToDouble(txthuellae.Text);
              


                    if (CamposDAL.Agre(camp) > 0)
                    {
                        MessageBox.Show("Datos Guardados", "Guardado!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(camp.Puntaje>=1)
                        {
                            MessageBox.Show("SU HUELLA ECOLOGICA ES: " + camp.Puntaje);
                            MessageBox.Show("INDICADOR ALTO.ES MOMENTO DE PENSAR UN POCO )-:");

                        }
                        else
                        {
                            MessageBox.Show("SU HUELLA ECOLOGICA ES: " + camp.Puntaje);
                            MessageBox.Show("INDICADOR BAJO.USA RECURSOS MODERADAMENTE ..SIGA ASI (-:");
                        }
                    

                        limpiar();
                    }


                 txthuellae.Text = puntof.ToString();
                    limpiar();

                }

            }
        }




        void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            txtnombre.Clear();
            txtapat.Clear();
            txtapmat.Clear();
            txtedad.Clear();
            txthuellae.Clear();



        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);

        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.NumerosDecimales(e);
        }


        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.SoloLetras(e);
        }

        private void txtapat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.SoloLetras(e);
        }

        private void txtapmat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bloqueartextboxs.SoloLetras(e);
        }



        private void modulo3_Click(object sender, EventArgs e)
        {

            dataGrid.DataSource = obje.VistaTabla();
        }
    }


   





}

