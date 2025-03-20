using System;

class ProgramaComMenu
{
    static void Main(string[] args)
    {
        int opcao;
        do
        {
            Console.WriteLine("\n-=- Menu de opções -=- ");
            Console.WriteLine("\n1 - Perímetro do círculo");
            Console.WriteLine("\n2 - Perímetro do retângulo");
            Console.WriteLine("\n3 - Perímetro do triângulo");
            Console.WriteLine("\n4 - Sair");
            Console.Write("\nDigite sua opção: ");
            opcao = int.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    Console.Write("\nInsira o raio do círculo: ");
                    double raio = double.Parse(Console.ReadLine());
                    Console.WriteLine("O perímetro do círculo é: " + FiguraHelper.CalcularPerimetro(raio));
                    break;
                
                case 2:
                    Console.Write("\nInsira o comprimento do retângulo: ");
                    double comprimento = double.Parse(Console.ReadLine());
                    Console.Write("Insira a altura do retângulo: ");
                    double altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("O perímetro do retângulo é: " + FiguraHelper.CalcularPerimetro(comprimento, altura));
                    break;
                
                case 3:
                    Console.Write("\nInsira o primeiro lado do triângulo: ");
                    double lado1 = double.Parse(Console.ReadLine());
                    Console.Write("Insira o segundo lado do triângulo: ");
                    double lado2 = double.Parse(Console.ReadLine());
                    Console.Write("Insira o terceiro lado do triângulo: ");
                    double lado3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("O perímetro do triângulo é: " + FiguraHelper.CalcularPerimetro(lado1, lado2, lado3));
                    break;
                
                case 4:
                    Console.WriteLine("\nSaindo...");
                    break;
                
                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }
        } while (opcao != 4);
        
        Console.WriteLine("\nFim do programa");
    }
}

class FiguraHelper
{
    public static double CalcularPerimetro(double raio)
    {
        return 2 * Math.PI * raio;
    }

    public static double CalcularPerimetro(double comprimento, double altura)
    {
        return 2 * (comprimento + altura);
    }

    public static double CalcularPerimetro(double lado1, double lado2, double lado3)
    {
        return lado1 + lado2 + lado3;
    }
}
