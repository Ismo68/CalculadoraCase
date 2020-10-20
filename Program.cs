using System;

namespace CalculadoraCase
{
    class Program
    {
        static void Main(string[] args)
        {
            static void calcular()
            {

                decimal num1 = 0;
                decimal num2 = 0;
                decimal oper = 0;

                Console.WriteLine("Introduce un numero");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Introduce otro numero");
                num2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\n");


                Console.WriteLine("Elija una opcion");
                Console.WriteLine("\n");
                Console.WriteLine("a) suma");
                Console.WriteLine("b) resta");
                Console.WriteLine("c) multiplicacion");
                Console.WriteLine("d) division");

                char result = Convert.ToChar(Console.ReadLine());

                switch (result)
                {

                    case 'a':
                        oper = num1 + num2;
                        Console.WriteLine("\n");
                        Console.WriteLine("El resultado de la suma de " + num1 + " y " + num2 + " es: " + oper);
                        break;

                    case 'b':
                        oper = num1 - num2;
                        Console.WriteLine("\n");
                        Console.WriteLine("El resultado de la resta de " + num1 + " y " + num2 + " es: " + oper);
                        break;

                    case 'c':
                        oper = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicacion de " + num1 + " por " + num2 + " es: " + oper);
                        break;

                    case 'd':
                        if (num2 == 0)
                        {
                            Console.WriteLine("No es posible dividir por cero. Introduzca un numero distinto de 0 ");
                            Console.WriteLine("\n");
                            
                        }
                        else
                        {
                            oper = num1 / num2;
                            Console.WriteLine("\n");
                            Console.WriteLine("El resultado de la division de " + num1 + " entre " + num2 + " es: " + oper);
                        }
                        break;

                    default:

                        Console.WriteLine("Eleccion erronea. Por favor elija una de las 4 opciones ofrecidas. ");
                        Console.WriteLine("\n");
                        break;
                }

            }


            calcular();

            int cont = 1;

            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Desea realizar otra operacion? Escriba si en caso afirmativo, sino pulse cualquier tecla\n");
                string seguir = Console.ReadLine();

                if (seguir == "Si" || seguir == "SI" || seguir == "sI" || seguir == "si")
                {
                    Console.WriteLine("\n");
                    calcular();
                    cont++;


                }
                else
                {
                    cont = 0;
                    Console.WriteLine("Gracias");



                }

            }








        }
    }
}
