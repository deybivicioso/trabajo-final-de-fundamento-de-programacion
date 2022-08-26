using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace trabajo_final_de_fundamento_de_programacion /*fundamento de programacion
                                                       * trabajo final 
                                                       * participantes: 
                                                       * deybi vicioso 2022-0030
                                                       * fraimer carrasco 2022-0485*/
{
    class Program
    {
       //procedimientotablamultiplicar
        static void procedimientotablamultiplicar(double vg)
        {
            double resultado;
            double X;
            Console.Clear();
            X = 1;

            Console.WriteLine(" Bienvenido a la opcion 2...\n ");
            Console.WriteLine(" Tabla de multiplicar {0} \n", vg);
            while (X <= 12)
            {
                resultado = vg * X;
                Console.WriteLine(" " + vg + " X " + X + " = " + resultado);
                X++;
            }
            Console.WriteLine(" La tabla de multiplicar esta siendo mostrada en pantalla.\n ");
            Thread.Sleep(2 * 1000);
            
            Console.WriteLine(" Presione una tecla  para volver al menu principal\n");
        }


        static void procedimientodenumerosprimos(double vg)
        {

            //procedimiento para mostrar evaluacion de
            //numeros primos
            double cont;
            double i;
            Console.Clear();
            cont = 0;
            Console.WriteLine(" Bienvenido a la opcion 3...\n");
            for (i = 1; i <= vg; i++)
            {
                if (vg % i == 0)
                {
                    cont = cont + 1;

                }
            }

            if (cont == 2)
            {
                Console.WriteLine(" " + vg + " es un numero primo\n");
            }
            else
            {
                Console.WriteLine(" " + vg + " no es un numero primo\n");
            }
            Console.WriteLine(" Presione una tecla para volver al menu principal\n");


        }

        static void procedimientodiagonalesmatriz()
        {

            int C;
            int f;
            Random azar = new Random();
            Console.Clear();
            double[,] matrix = new double[4, 4];
            Console.WriteLine(" Bienvenido a la opcion 4\n");
            for (f = 1; f <= 4; f++)
            {
                for (C = 1; C <= 4; C++)
                {
                    matrix[f - 1, C - 1] = f;
                    switch (f)
                    {
                        case 1:
                            matrix[f - 1, C - 1] = 1 + azar.Next(0, 4);
                            break;

                        case 2:
                            matrix[f - 1, C - 1] = 1 + azar.Next(0, 4);
                            break;

                        case 3:
                            matrix[f - 1, C - 1] = 1 + azar.Next(0, 4);
                            break;

                        case 4:
                            matrix[f - 1, C - 1] = 1 + azar.Next(0, 4);
                            break;
                    }
                }
            }
            //mostrar array bidimencional
            for (f = 1; f <= 4; f++)
            {
                Console.WriteLine(" " + "[" + matrix[f - 1, 0] + "]" + " " + "[" + matrix[f - 1, 1] + "]" + " " + "[" + matrix[f - 1, 2] + "]" + " " + "[" + matrix[f - 1, 3] + "]");
            }
            Console.WriteLine("");

            Console.WriteLine(" Diagonal principal: \n" + " " + matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3]);

            Console.WriteLine();

            Console.WriteLine(" Diagonal secunaria:\n" + " " + matrix[0, 3] + matrix[1, 2] + matrix[2, 3] + matrix[3, 0]);

            Console.WriteLine();

            

        }

        static void Main(string[] args)
        {
           
            int opcion = 0;
            int vg = 0;
            string[,] matrix = new string[4, 4];

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("fundamento de programcion");
            Console.WriteLine("trabajo final");
            Console.WriteLine("participantes: ");
            Console.WriteLine("deybi vicioso 2022-0030");
            Console.WriteLine("fraimer carrasco 2022-0485");
            Thread.Sleep(10 * 100);
            Console.Clear();

            //mientras.....
            while (opcion != 5)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                //menu
               Console.WriteLine(" <----------* menu principal*---------->");

                Console.WriteLine("");

                Console.WriteLine(" 1-> Capturar el valor de su preferencia");

                Console.WriteLine(" 2-> Generacion de la tabla de multiplicacion");

                Console.WriteLine(" 3-> Determinacion del valor primo");

                Console.WriteLine(" 4-> Matriz 4 x 4");

                Console.WriteLine(" 5-> Salida del menu");

                Console.WriteLine("");

                Console.WriteLine("introduce una opcion correspondiente al menu\n ");
                Console.WriteLine("  para acceder a la opcion 2 y 3 debe primero capturar un valor en la opcion 1\n ");

                //captura de una opcion del menu
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        //captura del valor
                       

                        Console.WriteLine(" Bienvenido a la opcion 1...\n");

                        Console.WriteLine(" introduce un numero de su preferencia\n");

                        Console.Write(" ");

                        vg = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        Console.WriteLine(" ya hemos guardado su numero\n");

                        Console.WriteLine(" Presione cualquier tecla para volver al menu\n");

                        break;

                    case 2:
                        procedimientotablamultiplicar(vg);
                        break;

                    case 3:
                        procedimientodenumerosprimos(vg);
                        break;

                    case 4:
                        procedimientodiagonalesmatriz();
                        break;

                    case 5:
                     Console.WriteLine(" Presione cualquier tecla para salir\n");


                        break;
                    default:
                        Console.WriteLine(" Debe introducir un numero correspondiente a las opciones de menu\n");
                        break;
                }
                Console.ReadKey();

            }
        }
    }
}


