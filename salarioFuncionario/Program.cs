using System;
using System.Globalization;

namespace dadosFuncionarios
{

    class Programa
    {
        static void Main(string[] args)
        {
            int numerofuncionario;//atribuição das variaveis
            char vaiAumentar;//atribuição das variaveis

            Console.WriteLine("Enforme o número de funcionarios");
            numerofuncionario = int.Parse(Console.ReadLine());
            //Pergunta 
            DadosF[] dados = new DadosF[numerofuncionario];

            for (int i = 0; i < numerofuncionario; i++)
            {

                Console.WriteLine("Digite o nome do funciomario(a): ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o valor do salario bruto do(a) " + nome + ": ");
                double salarioBruto = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor do imposto do funcionario(a) " + nome + ": ");
                double imposto = double.Parse(Console.ReadLine());

                Console.WriteLine();
                dados[i] = new DadosF(nome, salarioBruto, imposto);
                //double salarioLiquido = dados[i].SalarioLiquido(); 
                Console.WriteLine("------------Dados 1------------------");
                //Console.WriteLine(dados[i]);
                Console.WriteLine("Funcionario(a): " + dados[i].Nome);
                Console.WriteLine("Valor do salario bruto: " + dados[i].SalarioBruto.ToString("F"));
                Console.WriteLine("Valor do salario com imposto (Salario liquido): " + dados[i].SalarioLiquido().ToString("F"));
                Console.WriteLine("-------------------------------------");

                Console.WriteLine();

                Console.WriteLine("O funcionario(a) " + nome + " recebera um almento(S,s/N,n): ");
                vaiAumentar = char.Parse(Console.ReadLine());

                //dados[i] = new DadosF(nome, salarioBruto, imposto, vaiAumentar);

                if (vaiAumentar == 's' || vaiAumentar == 'S')
                {

                    Console.WriteLine(" Digite a porcentagem do almeto de salario do funcionario(a) " + dados[i].Nome);
                    double aumento = double.Parse(Console.ReadLine());

                    dados[i] = new DadosF(nome, salarioBruto, imposto, vaiAumentar, aumento);

                    //dados[i].SalarioBruto = dados[i].SalarioAumento();
                    Console.WriteLine("------------Dados 2------------------");
                    Console.WriteLine(dados[i]);
                    Console.WriteLine("-------------FIM---------------------");

                }
                else
                {
                    Console.WriteLine("-------------FIM---------------------");
                }

            }
        }
    }
}