using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Start_GFT.Questao4
{
    class Ingresso
    {
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public Ingresso()
        {
        }

        public Ingresso(double valor, int quantidade)
        {
            Valor = valor;
            Quantidade = quantidade;
        }

        public double impremeValor(double valor)
        {
            return Valor = Valor * Quantidade;
        }
    }
}
