using System;

namespace CalculosGeometricos
{
    class Program
    {

        static double CalculoCircunferencia(double radio)
        {
            return 2 * radio * Math.PI;
        }
        static double CalculoAreaCirculo(double radio)
        {
            return Math.PI * Math.Sqrt(radio);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Calculos geometricos \b");
            Console.WriteLine("Introduzca el radio: \b");
            double radio = Double.Parse(Console.ReadLine());
            Console.WriteLine("La circunferencia tiene un valor de "+ CalculoCircunferencia(radio) +" cm y el valor del area es de "+ CalculoAreaCirculo(radio)+" cm cuadrados.");
        }

    }
}
