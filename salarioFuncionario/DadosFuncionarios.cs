using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Classe do programa dados funcionarios
namespace dadosFuncionarios
{
    class DadosF
    {
        //Atribuição de variaveis da classe para ser utilizadas no programa
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }
        public double Aumento { get; set; }
        public char VaiAumentar { get; set; }

        public double SalarioLiquido()
        {
            //Metodo que faz a conta para calcular o salario liquido dos funcionarios
            return SalarioBruto - Imposto;
        }

        public double SalarioAumento()
        {
            //Metodo que faz a conta do lalario bruto soamdo com a porcentagem de aumento salarial
            return (Aumento / 100 * SalarioBruto) + SalarioBruto;
        }
        public double AumentoLiquido()
        {
            //Metodo que faz a conta para saber o valor do salario bruto dos funcionars com o aumento mais o Imposto
            return (Aumento / 100 * SalarioBruto) + SalarioBruto - Imposto;
        }
        public DadosF(string nome, double salarioBruto, double imposto)
        {
            //Atribui as variaveis do programa as variaveis da classe
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;

        }
        
        public DadosF(string nome, double salarioBruto, double imposto, char vaiAumentar, double aumento)
        {
            //Atribui as variaveis do programa as variaveis da classe
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
            VaiAumentar = vaiAumentar;
            Aumento = aumento;
        }
        public override string ToString()
        //retornas todos os valores das variaveis e funçoes a partir do vetor 
        {
            return "\nFuncionario: "
                + Nome
                + "\nValor do Salario bruto: "
                + SalarioBruto.ToString("F2")
                + "\nImposto: "
                + Imposto.ToString("F2")
                + "\nValor do salario menos o imposto (salario liquido): "
                + SalarioLiquido().ToString("F2")
                + "\nPorcentagem de aumento: "
                + Aumento.ToString("F2") + "%"
                + "\nSalario Bruto com o Aumento: "
                + SalarioAumento().ToString("F2")
                + "\nSalario Liquido com aumento: "
                + AumentoLiquido().ToString("F");



        }
        
    }
}

