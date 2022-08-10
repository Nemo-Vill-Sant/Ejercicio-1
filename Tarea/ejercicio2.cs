using System;

namespace Tarea
{
    public class ejercicio2
    {
        static void main(string[] args)
        {
            double b, h, l, A = 0, P = 0;
            Console.WriteLine("13. AREA Y PERIMETRO DEL TRIANGULO EN C#.\n");
            Console.Write("Ingrese Base   : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese Altura : ");
            h = double.Parse(Console.ReadLine());
            A = (b * h) / 2;
            Console.WriteLine("AREA           : " + String.Format("{0,4:##.00}", A));
            Console.Write("\nIngrese Lado   : ");
            l = double.Parse(Console.ReadLine());
            P = l * 3;
            Console.WriteLine("PERIMETRO      : " + String.Format("{0,4:##.00}", P));
            Console.ReadLine();


        }
    }
}
