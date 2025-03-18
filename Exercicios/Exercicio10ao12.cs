using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Exercicios.Classes;
using TP3.Utils;

namespace TP3.Exercicios
{
    class Exercicio10ao12
    {
        // Exercícios 10 ao 11 se encontram na classe "Esfera" e "Circulo".

        // Exercício 12
        public static void EX12_Executar()
        {
            LimpaConsole.Limpar();

            Circulo circulo = new Circulo();
            circulo.Raio = 3;
            circulo.CalcularArea();

            Esfera esfera = new Esfera();
            esfera.Raio = 5;
            esfera.CalcularVolume();

            Validacao.Validar();
        }
    }
}
