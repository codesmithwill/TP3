using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios.Classes
{
    class Matricula
    {
        // Exercício 7
        public string NomeDoAluno;
        public string Curso;
        public int NumeroMatricula;
        public string Situacao;
        public string DataInicial;

        // Exercício 8
        public void Trancar()
        {
            Situacao = "Trancada";
            Console.WriteLine($"A matrícula de {NomeDoAluno} foi trancada.\n");
        }

        public void Reativar()
        {
            Situacao = "Ativa";
            Console.WriteLine($"A matrícula de {NomeDoAluno} foi reativa.\n");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do aluno: {NomeDoAluno}.");
            Console.WriteLine($"Curso: {Curso}.");
            Console.WriteLine($"Situação da Matrícula: {Situacao}.");
            Console.WriteLine($"Data inicial da matrícula: {DataInicial}.");
        }
    }
}
