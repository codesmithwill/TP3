using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios.Classes
{
    class Circulo
    {
        // Exercício 10
        // Sem o Raio não seria possível realizar o cálculo desejado da fórmula.
        // Além de ser chamada uma classe podemos ter um método simples para realizar de maneira eficiente o cálculo.
        public double Raio;

        // Exercício 11
        public double CalcularArea()
        {
            double calculo = Math.PI * Math.Pow(Raio, 2);
            Console.WriteLine($"Raio informado: {Raio}");
            Console.WriteLine($"Área: {calculo:F2}");
            return calculo;
        }
    }
}
