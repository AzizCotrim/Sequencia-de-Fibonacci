using System;
namespace Teste1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe um número para verificar se ele pertence à sequência de Fibonacci:");
            int numero = int.Parse(Console.ReadLine());

            if (VerificarFibonacci(numero)) {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
                Console.ReadLine();
            } else {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
                Console.ReadLine();
            }
        }
        static bool VerificarFibonacci(int num) {
            int a = 0;
            int b = 1;

            while (a <= num) {
                if (a == num) {
                    return true;
                }

                int temp = a;
                a = b;
                b = temp + b;
            }

            return false;
        }
    }
}
