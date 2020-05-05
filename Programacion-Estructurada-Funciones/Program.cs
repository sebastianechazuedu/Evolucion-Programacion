using System;

namespace Programacion_Estructurada_Funciones
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
                    Console.WriteLine("ingrese numero de afiliado: ");
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
                ImpresionDatos(i ,nombres[i], apellidos[i], afiliados[i], numAfis[i], delegados[i]);
            }
            Console.Read();
        }
        //funcion para imprimir datos
        static void ImpresionDatos(int nro,string nombre, string apellido, Boolean afiliado, int numAfi, Boolean delegado)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Empleado nro: " + (nro+1));
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            if (afiliado == true)
            {
                Console.WriteLine("es afiliado al sindicato con el numero: " + numAfi);
                if (delegado == true)
                {
                    Console.WriteLine("Es delegado del sindicato");
                }
            }
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
