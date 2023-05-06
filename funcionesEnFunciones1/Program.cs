using System;

namespace funcionesEnFucniones1
{
    class Program
    {
        static int SolicitarNumero()
        {
            Console.Write("Ingrese un número: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }
        static void Sumar()
        {
            int valor1 = SolicitarNumero();
            int valor2 = SolicitarNumero();
            System.Console.WriteLine("La suma es: " + (valor1 + valor2));
        }
        static void Main(string[] args)
        {
            Sumar();
            System.Console.ReadLine();
        }
    }
}
