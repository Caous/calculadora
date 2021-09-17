using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class calc
    {
        public calc()
        {

        }
        public int valorFinal { get; set; }
        public string primeiroValor { get; set; }
        public string segundoValor { get; set; }
        public bool operacao { get; set; } = false;
        public int tipoOperacao { get; set; }
        public string valorAtual { get; set; }
        public string operacaoString { get; set; }

        public void setOperacao(int x)
        {

            switch (x)
            {
                case 1:
                    operacaoString = "+";
                    break;
                case 2:
                    operacaoString = "-";
                    break;
                case 3:
                    operacaoString = "*";
                    break;
                case 4:
                    operacaoString = "/";
                    break;
            }

        }
    }
}
