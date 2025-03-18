using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Exercicios.Classes;
using TP3.Utils;

namespace TP3.Exercicios
{
    class Exercicio2ao6
    {
        // Exercícios 2 ao 5 se encontram na classe "Ingresso".
        public static void EX4_Executar() {
            LimpaConsole.Limpar();

            Console.WriteLine("-------- EXERCÍCIO 4 ---------");
            Ingresso ingresso = new Ingresso("Show de The Weeknd", 359.99, 150);
            ingresso.AlterarPreco(259);
            ingresso.AlterarQuantidade(35);
            ingresso.ExibirInformacoes();
            Console.WriteLine("------------------------------\n");
            Validacao.Validar();
        }

        public static void EX5_Executar()
        {
            LimpaConsole.Limpar();
            Ingresso ingresso = new Ingresso("Show de The Weeknd", 359.99, 150);
            Console.WriteLine("-------- EXERCÍCIO 5 ---------\n");

            Console.WriteLine("- Setando novas atribuções (set):");
            // Setamos novas atribuições á classe "ingresso".
            ingresso.SetNomeDoShow("Show do David Guetta");
            ingresso.SetPreco(220);
            ingresso.SetQuantidadeDisponivel(500);
            Console.WriteLine("");

            // Coletamos as atribuições atuais da classe "ingresso".
            Console.WriteLine("- Confirmando atribuções (get):");
            ingresso.GetNomeDoShow();
            ingresso.GetPreco();
            ingresso.GetQuantidadeDisponivel();
            Console.WriteLine("");

            // Por fim, exibimos as informações referente a classe.
            Console.Write("- Informações do ingresso:");
            ingresso.ExibirInformacoes();
            Console.WriteLine("");
            
            Console.WriteLine("------------------------------\n");
            Validacao.Validar();
        }
        public static void EX6_Executar() 
        {
            LimpaConsole.Limpar();
            Console.WriteLine("-------- EXERCÍCIO 6 ---------");
            Ingresso ingresso = new Ingresso("Show da Lady Gaga", 599, 25);
            ingresso.ExibirInformacoes();

            // Apesar que eu havia já criado o método construtor, é importante indicar a importância dele:
            // O construtor especifica como o objeto deve ser criado e de que informações necessita.
            // Além disso, evita código repetitivo (utilizando get/set a todo momento).
            Console.WriteLine("\n------------------------------\n");

            Validacao.Validar();
        }
    }
}
