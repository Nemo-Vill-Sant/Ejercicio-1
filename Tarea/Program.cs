using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea
{
    class ejercicio1
    {

        static void Main(string[] args)
        {
            int horas;
            Console.WriteLine("---------Ejercicio 1---------\n");
            Console.WriteLine("Ingresar horas a convertir:");
            horas = Convert.ToInt32(Console.ReadLine());

            double minutos = horas * 60;

            Console.WriteLine("horas ingresadas tienen un equivalente en minutos de:" + minutos);

            double segundos = minutos * 60;

            Console.WriteLine("minutos ingresados tiene un equivalente en segundos de:" + segundos);
            Console.WriteLine("Presionar tecla Enter para continuar\n");
            Console.ReadKey();


            Console.WriteLine("---------Ejercicio 2---------\n");

            double b, h, l, A = 0, P = 0;

            Console.WriteLine("AREA Y PERIMETRO DEL TRIANGULO\n");

            Console.Write("Ingrese Base:");
            b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese Altura:");
            h = double.Parse(Console.ReadLine());

            A = b * h / 2;

            Console.WriteLine("AREA:" + A);

            Console.Write("Ingrese Lado:");
            l = double.Parse(Console.ReadLine());

            P = l * 3;

            Console.WriteLine("PERIMETRO:" + P);
            Console.WriteLine("Presionar tecla Enter Para continuar\n");
            Console.ReadKey();


            Console.WriteLine("---------Ejercicio 3---------\n");

            double Area, Volumen;
            string VARIABLE;

            Console.WriteLine("ingrese el radio");

            int Radio;

            VARIABLE = Console.ReadLine();
            Radio = int.Parse(VARIABLE);

            Console.WriteLine("ingrese la altura");

            int Altura;

            VARIABLE = Console.ReadLine();
            Altura = int.Parse(VARIABLE);

            Area = (2) * Radio;

            Console.WriteLine("El area es:" + Area);

            Volumen = Area * Altura;

            Console.WriteLine("El volumen es:" + Volumen);
            Console.WriteLine("Presionar la tecla Enter para continuar\n");
            Console.ReadKey();


            Console.WriteLine("---------Ejercicio 4---------\n");

            Console.WriteLine("Operaciones basicas");

            string resp = "";

            do

            {
                int valor1 = 0;

                int valor2 = 0;

                int R = 0;

                

                Console.WriteLine("Presione el simbolo para realizar la operacion:n");

                Console.WriteLine("+ para sumar");

                Console.WriteLine("- para restar");

                Console.WriteLine("* para multiplicar");

                Console.WriteLine("/ para dividir");

                Console.Write("Eliga Una Opcion: "); 

                resp = Console.ReadLine();

                string eleccion = Convert.ToString(resp);


                Console.WriteLine("Ingrese sus dos numeros");

                Console.Write("Valor1: ");

                valor1 = int.Parse(Console.ReadLine());

                Console.Write("Valor2: ");

                valor2 = int.Parse(Console.ReadLine());

                Console.WriteLine();



                switch (eleccion)

                {

                    case "+":

                        Console.WriteLine("El resultado de la suma es:");

                        R = valor1 + valor2;

                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);

                        break;

                    case "-":

                        Console.WriteLine("El resultado de la resta es:");

                        R = valor1 - valor2;

                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);

                        break;

                    case "*":

                        Console.WriteLine("El resultado de la multiplicacion es:");

                        R = valor1 * valor2;

                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);

                        break;

                    case "/":

                        Console.WriteLine("El resultado de la division es:");

                        R = valor1 / valor2;

                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);

                        break;

                }

                Console.Write("¿Desea Continuar? si/no: "); 

                resp = Console.ReadLine();

            }

            while (resp == "si" || resp == "si");

            Console.WriteLine("presionar la tecla Enter para continuar\n");

            Console.ReadKey();


            Console.WriteLine("---------Ejercicio 5---------\n");

            Console.WriteLine("Ingrese el nombre del paciente:");
            string nombre = Console.ReadLine();

            int edad;

            Console.WriteLine("Ingrese la edad del paciente:");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el peso del paciente:");
            double peso = Convert.ToDouble(Console.ReadLine());

            double estatura;

            Console.WriteLine("Ingrese la estatura del paciente:");
            estatura = Convert.ToDouble(Console.ReadLine());

            string tipo_de_sangre;

            Console.WriteLine("Ingrese el tipo de sangre del paciente:");
            tipo_de_sangre = Console.ReadLine();

            Console.WriteLine("Los datos del paciente son los siguientes: \n");
            Console.WriteLine("Nombre: " + nombre + " \nEdad: " + edad + "\nPeso: " + peso + "\nEstatura: " + estatura + "\nTipo de sangre: " + tipo_de_sangre);
            Console.WriteLine("presionar la tecla Enter para finalizar");
            Console.ReadKey();
        }
    }
}