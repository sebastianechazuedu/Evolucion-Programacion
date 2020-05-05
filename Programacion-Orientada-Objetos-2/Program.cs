using System;
using System.Collections.Generic;
namespace Programacion_Orientada_Objetos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------------------------------
            // DECLARACION VARIABLES
            // -------------------------------------------------------------------------------------
            Empleado[] empleados;
            List<Afiliado> afiliados = new List<Afiliado>();
            int cantidad;
            // -------------------------------------------------------------------------------------
            // INGRESO DE INFORMACION
            // -------------------------------------------------------------------------------------
            Console.Clear();
            Console.WriteLine("ingrese cantidad de empleados:");
            cantidad = int.Parse(Console.ReadLine());
            empleados = new Empleado[cantidad];
            Ingresar.IngresoDatos(empleados, afiliados);          
            // -------------------------------------------------------------------------------------
            // IMPRESION DE RESULTADOS
            // -------------------------------------------------------------------------------------
            Console.Clear();
            Imprimir.ImpresionDatos(empleados, afiliados);
            Console.Read();
        }
    }
}
