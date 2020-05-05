using System;
using System.Collections.Generic;
namespace Programacion_Orientada_Objetos_3
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
            for (int i = 0; i < empleados.Length; i++)
            {   
                Empleado emp = new Empleado();
                empleados[i].IngresarEmpleado(emp);
            }   
             // -------------------------------------------------------------------------------------
            // IMPRESION DE RESULTADOS
            // -------------------------------------------------------------------------------------
            for (int i = 0; i < empleados.Length; i++)
            {
                empleados[i].ImprimirEmpleado(empleados[i],i);
            }  
        }
    }
}
