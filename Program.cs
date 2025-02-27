using System;

namespace Lista_1
{
    class Program
    {
        /*
         
    Exercício 1: Escreva um programa que armazene em variáveis o seu nome, sua idade e a cidade onde reside. Na sequência exiba o conteúdo destas variáveis na tela. 

    Exercício 2: Escreva um programa que leia um número inteiro, calcule e exiba o resultado do dobro deste número. 

    Exercício 3: Escreva um programa que leia um número inteiro, calcule e exiba o resultado do quadrado deste número.

    Exercício 4: Escreva um programa que calcule e exiba o resultado da seguinte expressão matemática: (Dica: O usuário deverá informar os valores para as variáveis A, B e C) 
    A² * 5 – C / (B – A % 4) 

    Exercício 5: Escreva um programa que leia a idade de uma pessoa e deverá ser exibido na tela, se esta pessoa é maior ou menor de idade (considerar 18 anos para maior idade). 

    Exercício 6: Escreva um programa que leia um valor em Reais (R$), leia também a cotação do Dólar, realize o cálculo da conversão de moeda (de Reais para Dólares) e exiba na tela o resultado.

    Exercício 7: Escreva um programa que leia o nome de duas pessoas e ao final exiba: 
        •	O nome das duas pessoas com todos os caracteres maiúsculos 
        •	A quantidade de caracteres de cada nome 
        •	Apenas os três primeiros caracteres de cada nome
             */

        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - 2DS 2025 - Otavio e Samuel");
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
        }
        public static void Exercicio1()
        {
            string nome;
            int idade;
            string cidade;

            Console.WriteLine("\nExercicio 1");
            Console.WriteLine("\nDigite seu nome...");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade...");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua cidade...");
            cidade = Console.ReadLine();
            Console.WriteLine($"\nSeu nome é {nome}, sua idade é {idade} e seu endereço é {cidade}");
            Console.WriteLine("\nMuito obrigado pelas informações!");
        }
        public static void Exercicio2()
        {
            int num;
            Console.WriteLine("\nExercicio 2");
            Console.WriteLine("\nDigite um numero para exibir o dobro dele");
            num = Convert.ToInt32(Console.ReadLine());
            int dobro = num * 2;
            Console.WriteLine($"\nO dobro de {num} é igual a {dobro}");
        }
        public static void Exercicio3()
        {
            int num;
            Console.WriteLine("\nExercicio 3");
            Console.WriteLine("\nDigite um numero para exibir o quadrado dele");
            num = Convert.ToInt32(Console.ReadLine());
            int quadrado = num * num;
            Console.WriteLine($"\nO quadrado de {num} é igual a {quadrado}");
        }
        public static void Exercicio4()
        {
            int a, b, c, resultado;
            Console.WriteLine("\nExercicio 4");
            Console.WriteLine("\nEste exercicio calcula a expressão 'A² * 5 – C / (B – A % 4)'");
            Console.WriteLine("\nDigite um numero para ser o valor de A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite um numero para ser o valor de B");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite um numero para ser o valor de C");
            c = Convert.ToInt32(Console.ReadLine());
            resultado = a * a * 5 - c / (b - a % 4);
            Console.WriteLine($"\nO resultado da expressão é: {resultado}");
        }
        public static void Exercicio5()
        {
            int idade;
            Console.WriteLine("\nExercicio 5");
            Console.WriteLine("\nDigite sua idade...");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("voce é maior de idade");
            }
            else
            {
                Console.WriteLine("voce é menor de idade!");
            }
        }    
    }
}
