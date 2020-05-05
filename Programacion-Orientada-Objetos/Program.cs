using System;
using System.Collections.Generic;

namespace Programacion_Orientada_Objetos
{
    class Empleado
    {
        public string nombre;
        public string apellido;
        public int? numAfiliado;

    }
    class Afiliado
    {
        public int numAfiliado;
        public Boolean delegado;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------------------------------
            // DECLARACION VARIABLES
            // -------------------------------------------------------------------------------------
            Empleado[] empleados;
            List<Afiliado> afiliados = new List<Afiliado>();
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
            empleados = new Empleado[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Empleado emp = new Empleado();

                Console.WriteLine("ingrese un nombre:");
                emp.nombre = Console.ReadLine();
                Console.WriteLine("ingrese un apellido:");
                emp.apellido = Console.ReadLine();
                Console.WriteLine("Es afiliado?");
                linea = Console.ReadLine();
                if (linea != "si")
                {
                    emp.numAfiliado = null;
                }
                else
                {
                    Afiliado afl = new Afiliado();
                    Console.WriteLine("ingrese numero de afiliado: ");
                    string numero = Console.ReadLine();
                    emp.numAfiliado = int.Parse(numero);
                    afl.numAfiliado = int.Parse(numero);
                    Console.WriteLine("Es delegado?");
                    linea = Console.ReadLine();
                    if (linea == "si")
                    {
                        afl.delegado = true;
                    }
                    afiliados.Add(afl);
                }
                empleados[i] = emp;
            }
            // -------------------------------------------------------------------------------------
            // IMPRESION DE RESULTADOS
            // -------------------------------------------------------------------------------------
            Console.Clear();

            ImpresionDatos(empleados, afiliados);

            Console.Read();
        }
        //funcion para imprimir datos
        static void ImpresionDatos(Empleado[] empleados, List<Afiliado> afiliados)
        {
            for (int i = 0; i < empleados.Length; i++)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Empleado nro: " + (i + 1));
                Console.WriteLine("nombre: " + empleados[i].nombre);
                Console.WriteLine("Apellido: " + empleados[i].apellido);

                foreach (var afiliado in afiliados)
                {
                    if (afiliado.numAfiliado == empleados[i].numAfiliado && empleados[i].apellido == "perez")
                    {
                        Console.WriteLine("es afiliado al sindicato con el numero: " + afiliado.numAfiliado);
                        if (afiliado.delegado == true)
                        {
                            Console.WriteLine("Es delegado del sindicato");
                        }
                    }
                }
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}
