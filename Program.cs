using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_desafiado_2022_05_16
{
    public  class Program
    {
        public static void Main(string args[]) {
            Exercicio1();
            /*Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();
            Exercicio6();
            Exercicio7();
            Exercicio8();
            Exercicio9();*/
        }
        public static void Exercicio1()
        {
            Console.WriteLine("Insira a idade mínima: ");
            int idadeMinima = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a idade maxima: ");
            int idadeMaxima = int.Parse(Console.ReadLine());

            Console.WriteLine($"A média das idades é: {(idadeMinima + idadeMaxima) / 2.0}");
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Insira a cotação do Euro: ");
            float cotacaoEuro = float.Parse(Console.ReadLine());

            Console.WriteLine($"O valor da compra de 750 euros em Reais é: {750 * cotacaoEuro}");
        }

        public static void Exercicio3()
        {
            Console.WriteLine("Insira quanto o vendedor vendeu no mês de Maio: ");
            float quantidadeVenda = float.Parse(Console.ReadLine());
            float comissao = 0.05f;

            Console.WriteLine($"A comissão do vendedor para o mês de Maio foi: {quantidadeVenda * comissao}");
        }

        public static void Exercicio4()
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            float celsius = float.Parse(Console.ReadLine());

            Console.WriteLine($"A temperatura em Fahrenheit é: {(9 * celsius + 160) / 5}");
        }

        public static void Exercicio5()
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            float fahrenheit = float.Parse(Console.ReadLine());

            Console.WriteLine($"A temperatura em Celsius é: {(fahrenheit - 32) * 5 / 9 }");
        }

        public static void Exercicio6()
        {
            Console.WriteLine("Digite a sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine($"O seu peso ideal é: {(72.7 * altura) - 58}");
        }

        public static void Exercicio7()
        {
            Console.WriteLine("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            float nota4 = float.Parse(Console.ReadLine());

            float mediaNotas = (nota1 + nota2 + nota3 + nota4) / 4f;

            Console.WriteLine($"A média das notas é: {mediaNotas}");

            Console.WriteLine(mediaNotas > 7 ? "Aprovado" : "Reprovado");
        }

        public static void Exercicio8()
        {
            Console.WriteLine("Digite o valor A: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor B: ");
            float b = float.Parse(Console.ReadLine());

            float total = a - b;

            Console.WriteLine($"O valor da subtração de A e B é: {total}");

            Console.WriteLine(total >= 0 ? "Valor positivo" : "Valor negativo");
        }

        public static void Exercicio9()
        {
            Console.WriteLine("Digite o valor A: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor B: ");
            float b = float.Parse(Console.ReadLine());

            if (b != 0)
            {
                float totalDivisao = a / b;
                float totalModulo = a % b;

                Console.WriteLine($"O valor da divisão de A e B é: {totalDivisao}");
                Console.WriteLine($"O valor do módulo de A e B é: {totalModulo}");

            }
            else
            {
                Console.WriteLine("Divisor inválido!");
            }
        }
    }
}
