using System;

namespace Programacion_Estructurada
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------------------------------
            // DECLARACION VARIABLES
            // -------------------------------------------------------------------------------------
            //Empleado
            string nombre1, nombre2, nombre3;
            string apellido1, apellido2, apellido3;
            Boolean afiliado1 = false, afiliado2 = false, afiliado3 = false;
            //Afiliado
            int numAfi1 = 0, numAfi2 = 0, numAfi3 = 0;
            Boolean delegado1 = false, delegado2 = false, delegado3 = false;
            // variable de lectura por consola
            string linea;
            // -------------------------------------------------------------------------------------
            //INGRESO DE INFORMACION
            // -------------------------------------------------------------------------------------
            Console.Clear();
            Console.WriteLine("ingrese un nombre:");
            nombre1 = Console.ReadLine();
            Console.WriteLine("ingrese un apellido:");
            apellido1 = Console.ReadLine();
            Console.WriteLine("Es afiliado?");
            linea = Console.ReadLine();
            if (linea == "si")
            {
                afiliado1 = true;
            }
            if (afiliado1 == true)
            {
                Console.WriteLine("ingrese numero de afiliado:");
                numAfi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Es delegado?");
                linea = Console.ReadLine();
                if (linea == "si")
                {
                    delegado1 = true;
                }
            }
            Console.WriteLine("ingrese un nombre");
            nombre2 = Console.ReadLine();
            Console.WriteLine("ingrese un apellido:");
            apellido2 = Console.ReadLine();
            Console.WriteLine("Es afiliado?");
            linea = Console.ReadLine();
            if (linea == "si")
            {
                afiliado2 = true;
            }
            if (afiliado2 == true)
            {
                Console.WriteLine("ingrese numero de afiliado:");
                numAfi2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Es delegado?");
                linea = Console.ReadLine();
                if (linea == "si")
                {
                    delegado2 = true;
                }
            }
            Console.WriteLine("ingrese un nombre:");
            nombre3 = Console.ReadLine();
            Console.WriteLine("ingrese un apellido:");
            apellido3 = Console.ReadLine();
            Console.WriteLine("Es afiliado?");
            linea = Console.ReadLine();
            if (linea == "si")
            {
                afiliado3 = true;
            }
            if (afiliado3 == true)
            {
                Console.WriteLine("ingrese numero de afiliado:");
                numAfi3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Es delegado?");
                linea = Console.ReadLine();
                if (linea == "si")
                {
                    delegado3 = true;
                }
            }
            // -------------------------------------------------------------------------------------
            // IMPRESION DE RESULTADOS
            // -------------------------------------------------------------------------------------
            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Empleado nro: 1");
            Console.WriteLine("nombre: " + nombre1);
            Console.WriteLine("Apellido: " + apellido1);
            if (afiliado1 == true)
            {
                Console.WriteLine("es afiliado al sindicato con el numero: " + numAfi1);
                if (delegado1 == true)
                {
                    Console.WriteLine("Es delegado del sindicato");
                }
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Empleado nro: 2");
            Console.WriteLine("nombre: " + nombre2);
            Console.WriteLine("Apellido: " + apellido2);
            if (afiliado2 == true)
            {
                Console.WriteLine("es afiliado al sindicato con el numero: " + numAfi2);
                if (delegado2 == true)
                {
                    Console.WriteLine("Es delegado del sindicato");
                }
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Empleado nro: 3");
            Console.WriteLine("nombre: " + nombre3);
            Console.WriteLine("Apellido: " + apellido3);
            if (afiliado3 == true)
            {
                Console.WriteLine("es afiliado al sindicato con el numero: " + numAfi3);
                if (delegado3 == true)
                {
                    Console.WriteLine("Es delegado del sindicato");
                }
            }
            Console.WriteLine("--------------------------------------------------");
            Console.Read();
        }
    }
}
