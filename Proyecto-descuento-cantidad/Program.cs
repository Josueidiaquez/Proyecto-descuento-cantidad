﻿using System;

class Program
{
    static void main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("==== Ventas Varias ====");
            Console.WriteLine("1. Transistores");
            Console.WriteLine("2. Capacitores");
            Console.WriteLine("3. Leds");
            Console.WriteLine("4. Salir");
            Console.WriteLine("=======================");
            Console.WriteLine("Seleccione una Opcion: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Has seleccionado la opcion: 1.");
                    break;
                case "2":
                    Console.WriteLine("Has seleccionado la opcion: 2.");
                    break;
                case "3":
                    Console.WriteLine("Has seleccionado la opcion: 3.");
                    break;
                case "4":
                    Console.WriteLine("Saliendo del programa...");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("opcion no valida, intente de nuevo");
                    break;
            }

            if (continuar) 
            {
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();

            }

            while (continuar)
            {
                Console.WriteLine("==== Categorias ====");
                Console.WriteLine("1. Bebidas");
                Console.WriteLine("2. Ropa");
                Console.WriteLine("3. Joyeria");
                Console.WriteLine("4. Cajas de regalo");
                Console.WriteLine("5. velas");
                Console.WriteLine("6. Salir");
                Console.WriteLine("====================");
                Console.WriteLine("Seleccione la categoria: ");

                string categoria = Console.ReadLine();

                switch (categoria) 
                {
                    case "1":
                        Console.WriteLine("Has seleccionado la opcion 1.");
                        break;
                    case "2":
                        Console.WriteLine("Has seleccionado la opcion 2.");
                        break;
                    case "3":
                        Console.WriteLine("Has seleccionado la opcion 3.");
                        break;
                    case "4":
                        Console.WriteLine("Has seleccionado la opcion 4.");
                        break;
                    case "5":
                        Console.WriteLine("Has seleccionado la opcion 5.");
                        break;
                    case "6":
                        Console.WriteLine("Saliendo del programa...");
                        continuar = false;
                        break;
                }
            }
        }
    }
}