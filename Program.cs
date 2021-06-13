using System;

namespace T03_02_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 15;
            double A = 5.55;
            char C = 'P';
            Console.WriteLine("Variable N = " + N);
            Console.WriteLine("Variable A = " + A);
            Console.WriteLine("Variable C = " + C);
            double suma = N + A;
            double dif = A - N;
            int valor = (int)C;

            Console.WriteLine("N+A = " + suma);
            Console.WriteLine("A-N = " + dif);
            Console.WriteLine("Valor numérico de " + C + " = " + valor);
        }
    }
}
