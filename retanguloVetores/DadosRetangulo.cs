using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//classe referente ao programa dados retangulo
namespace retanguloVetores
{
    internal class DadosRetangulo
    {
        public int Quantidade { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        // variaveis da classe
        public DadosRetangulo( int numeroRetangulo, double altura, double largura)
            //atribui as variaves do pragrama nas variaves de classe
        {
            Quantidade = numeroRetangulo;
            Altura = altura;
            Largura = largura;
        }
        public double Area()
            // metodo que faz a conta da area do retangulo
        {   
            return Altura * Largura;
        }

        public double Perimetro()
            //metodo que faz a conta do perimetro do retangulo
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
            //função que faz a conta do diagonal do retangulo
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
             
        }

        public override string ToString()
            //retornas todos os valores das variaveis e funçoes a partir do vetor 
        {
            return "\nAltura: "
                + Altura.ToString("F2")
                + "\nLargura: "
                + Largura.ToString("F2")
                + "\nÁrea: "
                + Area().ToString("F2")
                + "\nPerimetro: "
                + Perimetro().ToString("F2")
                + "\nDiagonal: "
                + Diagonal().ToString("F2");





        }
    }
}
