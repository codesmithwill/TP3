using TP3.Exercicios;
using TP3.Utils;

namespace TP3
{
    class Program
    {
        public static void Alerta()
        {
            LimpaConsole.Limpar();
            Console.WriteLine("ERRO: Não possui código! Veja os arquivos do projeto.");
            Validacao.Validar();
        }

        public static void Main(string[] args)
        {
            string opcao = "";
            
            while(opcao != "sair") {
                Console.WriteLine("/---------------------- TP3 - C# ----------------------/");
                Console.WriteLine("/");
                Console.WriteLine("/ 1  - Exercício 1        (Exemplo de Classe - Carro)");
                Console.WriteLine("/ 2  - Exercício 2        (Criação Ingresso          - NÃO POSSUI CÓDIGO - VEJA A CLASSE!)");
                Console.WriteLine("/ 3  - Exercício 3        (Métodos Básicos           - NÃO POSSUI CÓDIGO - VEJA A CLASSE!)");
                Console.WriteLine("/ 4  - Exercício 4        (Teste Ingresso)");
                Console.WriteLine("/ 5  - Exercício 5        (Métodos de Propriedade - Get e Set)");
                Console.WriteLine("/ 6  - Exercício 6        (Adicionado Construtores)");
                Console.WriteLine("/ 7  - Exercício 7        (Criação Matricula         - NÃO POSSUI CÓDIGO - VEJA A CLASSE!)");
                Console.WriteLine("/ 8  - Exercício 8        (Métodos Básicos           - NÃO POSSUI CÓDIGO - VEJA A CLASSE!)");
                Console.WriteLine("/ 9  - Exercício 9        (Teste Matrícula)");
                Console.WriteLine("/ 10 - Exercício 10       (Criação Circulo/Esfera    - NÃO POSSUI CÓDIGO - VEJA A CLASSE!)");
                Console.WriteLine("/ 11 - Exercício 11       (Métodos de Cálculo        - NÃO POSSUI CÓDIGO - VEJA A CLASSE!)");
                Console.WriteLine("/ 12 - Exercício 12       (Teste Esfera/Círculo      - NÃO POSSUI CÓDIGO - VEJA A CLASSE!)");
                Console.WriteLine("/");
                Console.WriteLine("/------------------------------------------------------/\n");
                Console.WriteLine("sair - para sair da aplicação\n");
                Console.Write("Digite a opção desejada: ");
                opcao = Console.ReadLine().ToLower();
            
            switch (opcao)
                {
                    case "1":
                        Exercicio1.Executar();
                        break;
                    case "2":
                        Alerta();
                        break;
                    case "3":
                        Alerta();
                        break;
                    case "4":
                        Exercicio2ao6.EX4_Executar();
                        break;
                    case "5":
                        Exercicio2ao6.EX5_Executar();
                        break;
                    case "6":
                        Exercicio2ao6.EX6_Executar();
                        break;
                    case "7":
                        Alerta();
                        break;
                    case "8":
                        Alerta();
                        break;
                    case "9":
                        Exercicio7ao9.EX9_Executar();
                        break;
                    case "10":
                        Alerta();
                        break;
                    case "11":
                        Alerta();
                        break;
                    case "12":
                        Exercicio10ao12.EX12_Executar();
                        break;
                    case "sair":
                        LimpaConsole.Limpar();
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        LimpaConsole.Limpar();
                        Console.WriteLine("Opção inválida.\n");
                        break;
                }

            }
        }
    }
}