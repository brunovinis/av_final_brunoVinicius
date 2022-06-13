using System;
using System.Globalization;

namespace quartoAluguel
{

    class Programa
    {
        static void Main(string[] args)
        {
            int numeroPessoas;

            Console.WriteLine("Quantas pessoas alugaram quartos: ");
            numeroPessoas = int.Parse(Console.ReadLine());
            //Pergunta o numero de pessoas
            DadosAluguel[] dados = new DadosAluguel[numeroPessoas];
            //Pega o vetor e as variaveis da classe
            for(int i = 0; i < numeroPessoas; i++)
            //Repete as perguntas dos dados referente ao quantidade de pessoas
            {
                Console.WriteLine("Informe o nome da pessoa que vai alugar o quarto: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual a idade da pessoa: ");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a data de nascimento: ");
                string nascimento = Console.ReadLine();

                Console.WriteLine("Informe o numero de telefone da pessoa: ");
                string numero = Console.ReadLine();

                Console.WriteLine("Imforme o seu endereço: ");
                string endereco = Console.ReadLine();

                Console.WriteLine("Imforme o E-mail da pessoa: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o valor da diaria do aluguel: ");
                double valorDiaria = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o tempo de estadia: ");
                int dias = int.Parse(Console.ReadLine());

                dados[i] = new DadosAluguel(nome, idade, nascimento, endereco, numero, email, valorDiaria, dias);
                //Vai mandar as variaves do vetor para a classe
                Console.WriteLine();

                Console.WriteLine("O cliente deseja retirar a nota das imformaçoes: (S,s/N,n)");
                char notas = char.Parse(Console.ReadLine());
                //Pergunta se a pessoa vai querer impremir os dados 
                if (notas == 'S' || notas == 's')
                {
                    Console.WriteLine("----------Dados " + (i + 1) + "------------");
                    Console.WriteLine(dados[i]);
                    //pucha as funçoes, metodos e variaveis da classe
                    Console.WriteLine("----------FIM-----------");
                }
                else
                {
                    Console.WriteLine("----------FIM-----------");
                }
            }

        }
    }
}
