using System;
using System.Globalization;

namespace retanguloVetores
{

    class Programa
    {
        static void Main(string[] args)
        {

            int numeroRetangulo;

            Console.WriteLine("Digite a quantidade de retangulos: ");
            numeroRetangulo = int.Parse(Console.ReadLine());
            //Pergunta a quantidades de retangulos que serão contabilizados
            DadosRetangulo[] dados = new DadosRetangulo[numeroRetangulo];
            // Atribui a função dados ao vetor DadosRetangulos
            for (int i = 0; i < numeroRetangulo; i++)
                //For que pergunta a altura e largura do numero de retangulos mostrado pelo usuario.
            {
                //DadosRetangulo dados = new DadosRetangulo();

                Console.Write("Digite a altura do retangulo: ");
                double altura = double.Parse(Console.ReadLine());

                Console.Write("Digite a largura do retangulo: ");
                double largura = double.Parse(Console.ReadLine());

                Console.WriteLine();

                dados[i] = new DadosRetangulo(numeroRetangulo, altura, largura);
                //mostra quais variaveis serão utilizados no vetor

               
                Console.WriteLine(dados[i]);
                //pucha a função public override string da classe que por sua vez pucha as funçoes e variaveis da classe
                Console.WriteLine();
            }


        }
    }
}
