using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo2
{
    public partial class Form1 : Form
    {

        double A, B, C;

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLadoA.Text, out A) &&
                double.TryParse(txtLadoB.Text, out B) &&
                double.TryParse(txtLadoC.Text, out C) &&
                A > 0 && B > 0 && C > 0)
            {
                if (A + B > C && A + C > B && B + C > A)
                {
                    if (A == B && B == C)
                    {
                        txtInformativo.Text = "O triângulo informado é equilátero";
                    }
                    else if (A != B && B != C && A != C)
                    {
                        txtInformativo.Text = "O triângulo informado é escaleno";
                    }
                    else
                    {
                        txtInformativo.Text = "O triângulo informado é isósceles";
                    }
                }
                else
                {
                    txtInformativo.Text = "As retas quando juntas não formam um triângulo.";
                }
            }
            else
            {
                MessageBox.Show("Não pode ser menor que 0, ou negativo.");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtInformativo.Text = "";
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";
        }
    }
}
