using System;
using System.Collections.Generic;


namespace Projeto_Start_GFT.Questao4
{
    class Vip: Ingresso
    {
        public double ValorAdicional { get; set; }

        public double valorDoIngressoVIp()
        {
            return Valor + ValorAdicional;
        }
    }
}
