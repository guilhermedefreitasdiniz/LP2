using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(mboNomeFuncionario.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("O campo nome deve conter apenas letras e/ou espaços.");
                mboNomeFuncionario.Focus();

            }


            double AliquotaINSS, AliquotaIRPF, SalFamilia, descontoINSS, descontoIRPF, SalLiquido;

            double.TryParse(mboSalarioBruto.Text, out double SalBruto);
            int.TryParse(nupDFilhos.Text, out int numFilhos);

       //     label1.Text = SalBruto.ToString();
       //     label2.Text = numFilhos.ToString();

            AliquotaIRPF = 0.0;
            AliquotaINSS = 0.0;
            SalFamilia = 0.0;
            descontoINSS = 0.0;
            descontoIRPF = 0.0;

            if (SalBruto <= 800.47)
            {
                txtINSS.Text = "7,65%";
                descontoINSS = 0.765 * SalBruto;
            }
            else if (SalBruto <= 1050)
            {
                txtINSS.Text = "8,65%";
                descontoINSS = (8.65 / 100 * SalBruto);
            }

            else if (SalBruto <= 1400.77)
            {
                txtINSS.Text = "9,00%";
                descontoINSS = (9 / 100 * SalBruto);
            }

            else if (SalBruto <= 2801.56)
            {
                txtINSS.Text = "11,00%";
                descontoINSS = (11 / 100 * SalBruto);
            }
            else
            {
                txtINSS.Text = "00,00%";
            }

            if (SalBruto < 1257.12)
            {
                AliquotaIRPF = 0.00;

            }

            if (SalBruto >= 1257.13 && SalBruto <= 2512.08)
            {
                AliquotaIRPF = 0.15;

            }

            else if(SalBruto > 2518.08)
            {
                AliquotaIRPF = 0.275;

            }

            if (SalBruto <= 435.52)
            {
                SalFamilia = 22.33 * numFilhos;
            }
            if (SalBruto > 435.52 && SalBruto <= 654.61)
            {
                SalFamilia = 15.74 * numFilhos;
            }
            if (SalBruto > 654.61)
            {
                SalFamilia = 0 * numFilhos;
            }

            double deducaoIRPF = SalBruto * AliquotaIRPF;

           
            double deducaoINSS = SalBruto * AliquotaINSS;

           
            SalLiquido = SalBruto - deducaoIRPF - deducaoINSS + SalFamilia;

            AliquotaIRPF = AliquotaIRPF * 100;
            AliquotaINSS = AliquotaINSS * 100;

            txtINSS.Text = AliquotaINSS.ToString();
            txtIRPF.Text = AliquotaIRPF.ToString();
            txtSalarioFamilia.Text = SalFamilia.ToString();
            txtSalarioLiquido.Text = SalLiquido.ToString();
            txtDescontoINSS.Text = descontoINSS.ToString();
            txtDescontoIRPF.Text = descontoIRPF.ToString();
        }

    }
}
