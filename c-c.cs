using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo(a) à calculadora!");

        while (true)
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");

            Console.Write("Opção: ");
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Calculadora encerrada. Até logo!");
                break;
            }

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {result}");
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {result}");
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {result}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
