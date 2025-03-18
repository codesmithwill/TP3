using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios.Classes
{
    // A classe é a base para as informações que iremos fornecer posteriormente, sem ela definida não podemos atribuir características e ações para ela.

    // No exemplo de uma pessoa, precisamos definir "Pessoa" para posteriormente incluirmos:
    // Características: corDoCabelo, altura, peso, idade, dataDeNascimento, etc..
    // Ãções: andar, caminhar, correr, comer, beber, etc..

    class Carro // EX1: Prof, aqui inicio a declaração da classe "Carro"
    {
        // EX1: Abaixo defino os campos no qual chamamos de atributos que são: modelo, marca, cor, placa e ano da classe Carro.
        // Os atributos são como características da nossa classe, onde precisamos alimentar ela para então podermos realizar as ações com o que for repassado.
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }


        public Carro(string modelo, string marca, string cor, int ano, string placa) // EX1: Esse seria o construtor, mas também um método utilizando os campos.
        {
            Modelo = modelo;
            Marca = marca;
            Cor = cor;
            Ano = ano;
            Placa = placa;
        }

        public void exibirInformacoes() // EX1: Aqui fiz o método exibirInformações que seria a exibição das informações do carro.
                                        // Os métodos são ações, utilizamos os campos e fornecemos informações e então decidimos o que fazemos com ela a partir dos métodos.
        {
            Console.WriteLine($"Modelo do Carro: {Modelo}");
            Console.WriteLine($"Marca do Carro: {Marca}");
            Console.WriteLine($"Cor do Carro: {Modelo}");
            Console.WriteLine($"Modelo do Carro: {Modelo}");
            Console.WriteLine($"Placa: {Placa}");
        }
    }
}
