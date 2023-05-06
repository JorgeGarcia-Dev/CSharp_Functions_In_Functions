using System;

namespace funcionesEnFunciones2
{
    class Program
    {
        static string SolicitarNombre()
        {
            System.Console.WriteLine("Ingresa tu nombre:");
            string? nombre = System.Console.ReadLine();
            return nombre ?? "Sin nombre";
        }
        static string SolicitarApellido()
        {
            System.Console.WriteLine("Ingresa tu apellido:");
            string? apellido = System.Console.ReadLine();
            return apellido ?? "Sin apellido";
        }
        static string SolicitarProfesion()
        {
            System.Console.WriteLine("Ingresa tu profesión:");
            string? profesion = System.Console.ReadLine();
            return profesion ?? "Sin profesión";
        }
        static void Datos()
        {
            string nombre = SolicitarNombre();
            string apellido = SolicitarApellido();
            string profesion = SolicitarProfesion();
            System.Console.WriteLine($"Mi nombre es {nombre} {apellido} y soy {profesion}");
        }
        static void Main(string[] args)
        {
            Datos();
        }
    }
}
