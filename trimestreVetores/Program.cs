using System;
using System.Globalization;

namespace trimestreVetores
{

    class Programa
    {
        static void Main(string[] args)
        {


            int numeroAlunos;

            Console.WriteLine("Quantos alunos teram as notas processadas: ");
            numeroAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //Pergunta o numero de estudandes que serão utilizados 
            DadosAlunos[] dados = new DadosAlunos[numeroAlunos];
            //vetor utilizado para armazenar as tres notas referente a quantidade de alunos

            for (int i = 0; i < numeroAlunos; i++) 
                //Repetição para perguntar as 3 notas de cada alunos
            {
                Console.WriteLine("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a primeira nota: (Maximo 30 pontos)");
                double nota1 = double.Parse(Console.ReadLine());
                if (nota1 > 30)
                    //if que vai delimitar o maximo de pontos da primeira nota
                {
                    while (nota1 > 30)
                    //Vai perguntar até ter uma nota dentro dos parametros
                    {

                        Console.WriteLine("Valor fora dos parametros, porfavor digete novamente; ");
                        nota1 = double.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Digite as 2 notas dos dois ultimos trimestres do aluno (maximo 35 pontos) :");
                double nota2 = double.Parse(Console.ReadLine());
                double nota3 = double.Parse(Console.ReadLine());

                if (nota2 > 35 || nota3 > 35)
                //if que vai delimitar o maximo de pontos da segunda e terceira nota
                {
                    while (nota2 > 35 || nota3 > 35)
                        //Vai perguntar até ter uma nota dentro dos parametros
                    {
                        Console.WriteLine("Valor fora dos parametros, porfavor digete novamente: ");
                        nota2 = double.Parse(Console.ReadLine());
                        nota3 = double.Parse(Console.ReadLine());
                    }
                }

                double somaNotas = nota1 + nota2 + nota3;


                dados[i] = new DadosAlunos(nome, nota1, nota2, nota3);
                // vai puchar os valores do vetor da classe.

                Console.WriteLine("---------Ficha" + (i + 1) + "-----------");
                //Vai criar a finha para todos os alunos
                Console.WriteLine("NOME DO ALUNO: " + nome);
                Console.WriteLine("NOTA NUMERO 1: " + nota1);
                Console.WriteLine("NOTA NUMERO 2: " + nota2);
                Console.WriteLine("NOTA NUMERO 3: " + nota3);
                Console.WriteLine("MÉDIA DE ALUNOS: " + somaNotas.ToString("F"));
                if (somaNotas < 60)
                    //if que mostra se o aluno passo ou reprovou utilizando a nota media (60).
                {
                    somaNotas = 60 - somaNotas;
                    Console.WriteLine("Aluno Reprovado");
                    Console.WriteLine("Falta " + somaNotas + " pontos para ser aprovado");
                    // Se ele reprova o codigo mostra quantos pontos serão necessarios para atingir a media.
                }
                else
                {
                    Console.WriteLine("Aluno Aprovado Parabéns!!!");
                }
                Console.WriteLine("-----------FIM--------------------");
                Console.WriteLine();
            }







        }
    }
}

