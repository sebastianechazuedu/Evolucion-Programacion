using System;

namespace Programacion_Estructurada_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------------------------------
            // DECLARACION VARIABLES
            // -------------------------------------------------------------------------------------
            //Empleado
            string[] nombres;
            string[] apellidos;
            Boolean[] afiliados;
            //Afiliado
            int[] numAfis;
            Boolean[] delegados;
            // variable de lectura por consola
            string linea;
            // variable contador de empleados
            int cantidad;
            // -------------------------------------------------------------------------------------
            //INGRESO DE INFORMACION
            // -------------------------------------------------------------------------------------
            Console.Clear();
            Console.WriteLine("ingrese cantidad de empleados:");
            cantidad = int.Parse(Console.ReadLine());

            nombres = new string[cantidad];
            apellidos = new string[cantidad];
            afiliados = new Boolean[cantidad];
            numAfis = new int[cantidad];
            delegados = new Boolean[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("ingrese un nombre:");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("ingrese un apellido:");
                apellidos[i] = Console.ReadLine();
                Console.WriteLine("Es afiliado?");
                linea = Console.ReadLine();
                if (linea == "si")
                {
                    afiliados[i] = true;
                }
                if (afiliados[i] == true)
                {
                    Console.WriteLine("ingrese numero de afiliado:");
                    numAfis[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Es delegado?");
                    linea = Console.ReadLine();
                    if (linea == "si")
                    {
                        delegados[i] = true;
                    }
                }
            }
            // -------------------------------------------------------------------------------------
            // IMPRESION DE RESULTADOS
            // -------------------------------------------------------------------------------------
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Empleado nro: 1");
                Console.WriteLine("nombre: " + nombres[i]);
                Console.WriteLine("Apellido: " + apellidos[i]);
                if (afiliados[i] == true)
                {
                    Console.WriteLine("es afiliado al sindicato con el numero: " + numAfis[i]);
                    if (delegados[i] == true)
                    {
                        Console.WriteLine("Es delegado del sindicato");
                    }
                }
                Console.WriteLine("--------------------------------------------------");
            }           
            Console.Read();
        }
    }
}
