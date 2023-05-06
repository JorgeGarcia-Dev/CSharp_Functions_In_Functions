using System;

namespace funcionesEnFunciones3
{
    class Program
    {
        static int MayorQue(int num1, int num2, int num3)
        {
            System.Console.WriteLine("Ingresa un número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
        static int operacionResultado()
        {
            int num1 = MayorQue(0, 0, 0);
            int num2 = MayorQue(0, 0, 0);
            int num3 = MayorQue(0, 0, 0);

            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        static void Main(string[] args)
        {
            int resultado = operacionResultado();
            System.Console.WriteLine($"El número mayor es {resultado}");
        }
    }
}
