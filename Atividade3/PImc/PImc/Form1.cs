using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PImc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
  
            Close();
        }

        private void MskPeso_Validated(object sender, EventArgs e)
        {
            double peso;
            errorProvider1.SetError(mskbxPeso, "");

            if (!double.TryParse(mskbxPeso.Text, out peso) || (peso <= 0)){ 
             
          //    MessageBox.Show("Peso Inválido!");                  ///////////// teoricamente tem que por o negocio normal aqui, mas to testando a msg de erro
             errorProvider1.SetError(mskbxPeso, "peso inválido");
                }

        }

        private void MskbxAltura_Validated(object sender, EventArgs e)
        {
            double altura;
            errorProvider2.SetError(mskbxAltura, "");
            
            if (!double.TryParse(mskbxAltura.Text, out altura) || (altura <= 0)){

                MessageBox.Show("Altura Inválida!");
                errorProvider2.SetError(mskbxAltura, "altura inválida");
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double altura = 0;
            double peso = 0;
            double imc = 0;
            if (Double.TryParse(mskbxAltura.Text, out altura) && (Double.TryParse(mskbxPeso.Text, out peso))){

                if ((altura <= 0) || (peso <= 0))
                    MessageBox.Show("valores devem ser maiores que zero!");
                else
                {
                    imc = peso / (Math.Pow(altura, 2));

                    imc = Math.Round(imc, 1); // ARREDONDANDO


                    txtImc.Text = imc.ToString("N1");


                    if (imc < 18.5)
                        MessageBox.Show("Magreza");

                    else if (imc <= 24.9)
                        MessageBox.Show("Normal");

                    else if (imc <= 29.9)
                        MessageBox.Show("Sobrepeso");

                    else if (imc <= 39.9)
                        MessageBox.Show("Obesidade");
                    else
                        MessageBox.Show("Obesidade grave");

                }


            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            mskbxAltura.Text = "";
            mskbxPeso.Text = "";
        }
    }
}
