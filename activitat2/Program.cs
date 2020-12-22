using System;
using System.Collections.Generic;
using System.Text;

namespace activitat2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Writeline("HOLA MUNDO!!!");
            int num1 = 5;
            int num2 = 6;
            double numero3 = 2.57;
            double suma;
            suma = num1 + numero3;

            Console.WriteLine(suma);
            string valor1 = Console.ReadLine();
            Console.WriteLine("El numero introducido es:" + valor1);
            int valorint = Convert.ToInt32(valor1);

            Console.ReadKey();
                }
    }
}
