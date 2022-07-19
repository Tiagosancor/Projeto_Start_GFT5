using System;

namespace Projeto_Start_GFT
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 1; i < 4000; i++)
            {
                int numero = i;
                string[] romanos = {"I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
                int[] numerosNarurais = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

                int indice = (numerosNarurais.Length / numerosNarurais[0]) - 1;
                while (numero > 0)
                {
                    if (numero >= numerosNarurais[indice])
                    {
                        Console.WriteLine(romanos[indice]);
                        numero -= numerosNarurais[indice];
                    }
                    else
                    {
                        indice--;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
