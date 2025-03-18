using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Exercicios.Classes;
using TP3.Utils;

namespace TP3.Exercicios
{
    class Exercicio1
    {
        public static void Executar() { 
            LimpaConsole.Limpar();

            Carro carro = new Carro("Fusca", "Volkswagen", "Azul", 1974, "ZXT21T3"); // EX1: Criado o objeto com base no método e informações.
            carro.exibirInformacoes();

            Validacao.Validar();
        }
    }
}
