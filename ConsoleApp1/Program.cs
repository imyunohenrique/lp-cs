using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Calculadora de Macacos");
            Console.WriteLine("Digite o valor de A: \n");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: \n");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: \n");
            var c = int.Parse(Console.ReadLine());

            var delta = Math.Pow(b, 2) - 4 * a * c;
            double a1 = (-b + (delta)) / (2 * a);
            double a2 = (-b - (delta)) / (2 * a);

            Console.WriteLine("Este é o valor de DELTA:    " + delta);
            Console.WriteLine("Este é o valor de x1:   " + a1);
            Console.WriteLine("Este é o valor de x2:   " + a2);
        }
     }
}





































