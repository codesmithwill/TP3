/*

Prof, apenas algumas observações:

Além do que é requisitado no TP quis fazer algo mais organizado e por isso você vai ver algumas diferenças como:

    Program.cs (Main):
        - Segui a mesma ideia do TP anterior, fiz um menu para selecionar o exercício desejado (acredito que seja mais fácil)

    /Utils/FormatoMoeda:
        - Fiz a classe para alterar a maneira escrita de valores para a forma PT-BR (brasileira) econômica.
        - Exemplo: 
            double valor = 1000.22;         --> retorna "1000.22"
            FormatoMoeda.Converter(valor);  --> retorna "R$ 1.000,22"

    /Utils/Validação:
        - Diferentemente do TP anterior, ao invés de fazer um Contador para voltar ao menu principal, o usuário que escolhe quando quer ir.
        - Basta o usuário digitar sair, ele possui um simples método while para forçar o usuário a digitar o que é exigido.

    /Utils/LimpaConsole:
        - Segui o mesmo padrão do TP anterior também, fiz apenas uma classe para ficar chamando e limpar o console.
        - Fiz isso pois ao ir para vários exercícios pode-se ter uma poluição visual muito grande, então dessa forma fica organizado.

Além disso fiz uma pasta: TP3/Exercicios
Essa pasta contem duas divisões:

    /Exercicios
        - São as classes de teste (main) de cada classe/exercício do TP.

    /Exercicos/Classes:
        - São as classes que é necessário elaborar ao decorrer do TP.
        - Em alguns exercícios, é solicitado que informe justificativas/explicações de uso, então coloquei comentado dentro da classe.

    - Na parte de exercícios, alguns não dizem sobre métodos construtores, então andei pelos dois.
    - Alguns irão possuir construtores, e outros não como é o caso da classe "Matrícula".

Espero que tenha ficado simples de entender prof.
Se puder dar uma sugestão que eu possa melhorar/fazer no meu próximo exercício agradeço!

Obrigado pela atenção!

 */