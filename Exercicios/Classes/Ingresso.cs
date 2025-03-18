using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Utils;

namespace TP3.Exercicios.Classes
{
    class Ingresso
    {
        // Exercício 2
        // É necessários os atributos abaixo pois sem eles definidos não seria possível realizar a venda de ingressos.
        // Informações como as abaixo, são importantes para o sistema entender de que show se trata, o preço do ingresso e quantidade de ingresso ao financeiro.
        
        public string nomeDoShow;
        public double preco;
        public int quantidadeDisponivel; 

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        // Exercício 3
        public void AlterarPreco(double novoPreco)
        {
            Console.WriteLine($"\nPreço de ingresso para '{nomeDoShow}' alterado de {FormatoMoeda.Converter(preco)} para {FormatoMoeda.Converter(novoPreco)}");
            preco = novoPreco;
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            Console.WriteLine($"\nQuantidade de ingressos para '{nomeDoShow}' de {quantidadeDisponivel} para {novaQuantidade} ingressos.");
            quantidadeDisponivel = novaQuantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nNome do Show: {nomeDoShow}");
            Console.WriteLine($"Preço do Show: {FormatoMoeda.Converter(preco)}");
            Console.WriteLine($"Quantidade disponível: {quantidadeDisponivel} ingressos.");
        }

        // Exercício 5
        public string GetNomeDoShow()
        {
            Console.WriteLine($"O nome do show é: '{nomeDoShow}'.");
            return nomeDoShow;
        }

        public double GetPreco()
        {
            Console.WriteLine($"O preço do show é de: {FormatoMoeda.Converter(preco)}");
            return preco;
        }

        public int GetQuantidadeDisponivel()
        {
            Console.WriteLine($"A quantidade de ingressos disponível é de {quantidadeDisponivel} ingressos.");
            return quantidadeDisponivel;
        }

        public string SetNomeDoShow(string novoNome)
        {
            Console.WriteLine($"O nome do show '{nomeDoShow}' foi alterado para '{novoNome}'.");
            nomeDoShow = novoNome;
            return nomeDoShow;
        }

        public double SetPreco(double novoPreco)
        {
            Console.WriteLine($"O preço foi alterado de {FormatoMoeda.Converter(preco)} para {FormatoMoeda.Converter(novoPreco)}.");
            preco = novoPreco;
            return preco;
        }

        public int SetQuantidadeDisponivel(int novaQtd)
        {
            Console.WriteLine($"A quantidade foi atualizada de '{quantidadeDisponivel}' para {novaQtd}.");
            quantidadeDisponivel = novaQtd;
            return quantidadeDisponivel;
        }
    }
}
