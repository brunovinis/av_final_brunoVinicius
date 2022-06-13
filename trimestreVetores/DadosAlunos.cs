using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trimestreVetores
{
    class DadosAlunos
    {
       
        //public int i;
        public string Nome { get; set; }    
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        //variaveis da classe 

        public DadosAlunos(string nome, double nota1, double nota2, double nota3)
            //Atribui as variaveis de programa as variaveis de classe
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }


        public double MediaNotas()
            //função que caluca a soma das notas
        {
            return Nota1 + Nota2 + Nota3;
        }
    }
}
