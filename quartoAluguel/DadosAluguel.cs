using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//classe referente ao programa quarto aluguel
namespace quartoAluguel
{
    class DadosAluguel
    {

        public int Diaria { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Nascimento { get; set; }
        public string Numero { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public double ValorDiaria { get; set; }
        //Atribuição de variavel na classe
        public double TempoAluguel()
        {
            //função (metodo) que calcula o preço tota da estadia
            return Diaria * ValorDiaria;
        }

        public DadosAluguel(string nome, int idade, string nascimento,string endereco, string numero, string email, double valorDiaria, int dias)
            //Pega os valores do vetor do programa e passa para a classe
        {
            //atribui as funçoes do programa as funçoes da classes
            Diaria = dias;
            Nome = nome;
            Email = email;
            ValorDiaria = valorDiaria;
            Idade = idade;
            Nascimento = nascimento;
            Numero = numero;
            Endereco = endereco;
        }
        public override string ToString()
        //retornas todos os valores das variaveis e funçoes a partir do vetor 
        {
            return "\nNome: "
                + Nome
                + "\nIdade: "
                + Idade
                + "\nData de nascimento: "
                + Nascimento
                + "\nE-mail: "
                + Email
                +"\nEndereço: "
                + Endereco
                + "\nValor da Diaria: "
                + ValorDiaria.ToString("F2")
                +"\nDias: "
                + Diaria
                + "\nValor total a pagar: "
                + TempoAluguel().ToString("F");




        }
    }
}
