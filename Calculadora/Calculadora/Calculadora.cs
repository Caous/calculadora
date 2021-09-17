using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        calc calcula = new calc();
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (!calcula.operacao)
                calcula.primeiroValor = calcula.primeiroValor + btnOne.Text;
            else
                calcula.segundoValor = calcula.segundoValor + btnOne.Text;

            calcula.valorAtual = calcula.primeiroValor + " " + calcula.operacaoString + " " + calcula.segundoValor;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (!calcula.operacao)
                calcula.primeiroValor = calcula.primeiroValor + btnTwo.Text;
            else
                calcula.segundoValor = calcula.segundoValor + btnTwo.Text;

            calcula.valorAtual = calcula.primeiroValor + " " + calcula.operacaoString + " " + calcula.segundoValor;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            if (!calcula.operacao)
                calcula.primeiroValor = calcula.primeiroValor + btnTree.Text;
            else
                calcula.segundoValor = calcula.segundoValor + btnTree.Text;

            calcula.valorAtual = calcula.primeiroValor + " " + calcula.operacaoString + " " + calcula.segundoValor;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (!calcula.operacao)
                calcula.primeiroValor = calcula.primeiroValor + btnFour.Text;
            else
                calcula.segundoValor = calcula.segundoValor + btnFour.Text;

            calcula.valorAtual = calcula.primeiroValor + " " + calcula.operacaoString + " " + calcula.segundoValor;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (!calcula.operacao)
                calcula.primeiroValor = calcula.primeiroValor + btnFive.Text;
            else
                calcula.segundoValor = calcula.segundoValor + btnFive.Text;

            calcula.valorAtual = calcula.primeiroValor + " " + calcula.operacaoString + " " + calcula.segundoValor;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (!calcula.operacao)
                calcula.primeiroValor = calcula.primeiroValor + btnSix.Text;
            else
                calcula.segundoValor = calcula.segundoValor + btnSix.Text;

            calcula.valorAtual = calcula.primeiroValor + " " + calcula.operacaoString + " " + calcula.segundoValor;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (!calcula.operacao)
                calcula.primeiroValor = calcula.primeiroValor + btnSeven.Text;
            else
                calcula.segundoValor = calcula.segundoValor + btnSeven.Text;

            calcula.valorAtual = calcula.primeiroValor + " " + calcula.operacaoString + " " + calcula.segundoValor;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (!calcula.operacao)
                calcula.primeiroValor = calcula.primeiroValor + btnEight.Text;
            else
                calcula.segundoValor = calcula.segundoValor + btnEight.Text;

            calcula.valorAtual = calcula.primeiroValor + " " + calcula.operacaoString + " " + calcula.segundoValor;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (!calcula.operacao)
                calcula.primeiroValor = calcula.primeiroValor + btnNine.Text;
            else
                calcula.segundoValor = calcula.segundoValor + btnNine.Text;

            calcula.valorAtual = calcula.primeiroValor + " " + calcula.operacaoString + " " + calcula.segundoValor;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (!calcula.operacao)
                calcula.primeiroValor = calcula.primeiroValor + btnZero.Text;
            else
                calcula.segundoValor = calcula.segundoValor + btnZero.Text;

            calcula.valorAtual = calcula.primeiroValor + " " + calcula.operacaoString + " " + calcula.segundoValor;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            calcula.operacao = true;
            calcula.tipoOperacao = 1;
            calcula.setOperacao(1);
            calcula.valorAtual = calcula.valorAtual + calcula.operacaoString;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            calcula.operacao = true;
            calcula.tipoOperacao = 2;
            calcula.setOperacao(2);
            calcula.valorAtual = calcula.valorAtual + calcula.operacaoString;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            calcula.operacao = true;
            calcula.tipoOperacao = 3;
            calcula.setOperacao(3);
            calcula.valorAtual = calcula.valorAtual + calcula.operacaoString;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            calcula.operacao = true;
            calcula.tipoOperacao = 4;
            calcula.setOperacao(4);
            calcula.valorAtual = calcula.valorAtual + calcula.operacaoString;

            txtResultado.Text = calcula.valorAtual;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            calcula.valorAtual = string.Empty;
            switch (calcula.tipoOperacao)
            {
                case 1:
                    calcula.valorFinal = int.Parse(calcula.primeiroValor) + int.Parse(calcula.segundoValor);
                    calcula.valorAtual = calcula.primeiroValor.ToString() + " " + calcula.operacaoString + " " + calcula.segundoValor.ToString() + " = " + calcula.valorFinal.ToString();
                    txtResultado.Text = calcula.valorAtual;
                    break;
                case 2:
                    calcula.valorFinal = int.Parse(calcula.primeiroValor) - int.Parse(calcula.segundoValor);
                    calcula.valorAtual = calcula.primeiroValor.ToString() + " " + calcula.operacaoString + " " + calcula.segundoValor.ToString() + " = " + calcula.valorFinal.ToString();
                    txtResultado.Text = calcula.valorAtual;
                    break;
                case 3:
                    calcula.valorFinal = int.Parse(calcula.primeiroValor) * int.Parse(calcula.segundoValor);
                    calcula.valorAtual = calcula.primeiroValor.ToString() + " " + calcula.operacaoString + " " + calcula.segundoValor.ToString() + " = " + calcula.valorFinal.ToString();
                    txtResultado.Text = calcula.valorAtual;
                    break;
                case 4:
                    calcula.valorFinal = int.Parse(calcula.primeiroValor) / int.Parse(calcula.segundoValor);
                    calcula.valorAtual = calcula.primeiroValor.ToString() + " " + calcula.operacaoString + " " + calcula.segundoValor.ToString() + " = " + calcula.valorFinal.ToString();
                    txtResultado.Text = calcula.valorAtual;
                    break;
            }
            calcula.operacao = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calcula = new calc();
            txtResultado.Text = "";
        }
    }
}
