// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace proj1{
    public class Program{
        static void Main(string[] args){
            double num1;
            double num2;
            string nome = "meuNome";

            Console.WriteLine("Qual o seu nome? Digite aqui: ");
            nome = Console.ReadLine();

            Console.WriteLine($"\nBom dia {nome}!\nDigite o 1º nº: ");
            num1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Digite o 2º nº: ");
            num2 = Convert.ToInt32 (Console.ReadLine());

            double soma = (num1 + num2);
            double sub = (num1 - num2);
            double multi = (num1 * num2);
            double div = (num1 / num2);

            Console.WriteLine($"A soma de {num1} + {num2} = {soma}\n");
            Console.WriteLine($"A subtração de {num1} - {num2} = {sub}\n");
            Console.WriteLine($"A multiplicação de {num1} x {num2} = {multi}\n");
            Console.WriteLine($"A divisão de {num1} / {num2} = {div/*.ToString("N2")*/}\n");
            if((num1%2) == 0) {
                Console.WriteLine($"O 1º nº, {num1} é par!\n");
            }
            if((num2%2) == 0){
                Console.WriteLine($"O 2º nº, {num2} é par!\n");
            }
            else if((num1%2) != 0){
                Console.WriteLine($"O 1º nº, {num1} é ímpar!\n");
            }
            else{
                Console.WriteLine($"O 2º nº, {num2} é ímpar!");
            }
            //Mantém na tela
            //Console.ReadKey();
        }
    }
}