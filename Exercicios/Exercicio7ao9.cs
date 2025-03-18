using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Exercicios.Classes;
using TP3.Utils;

namespace TP3.Exercicios
{
    class Exercicio7ao9
    {
        // Exercícios 7 ao 8 se encontram na classe "Matricula".

        // Exercício 9
        public static void EX9_Executar()
        {
            LimpaConsole.Limpar();

            Matricula willian = new Matricula();
            willian.NomeDoAluno = "Willian";
            willian.Curso = "ADS";
            willian.NumeroMatricula = 2315181;
            willian.DataInicial = "17/03/2025";
            willian.Trancar();
            willian.Reativar();
            willian.ExibirInformacoes();

            Validacao.Validar();
        }
    }
}
