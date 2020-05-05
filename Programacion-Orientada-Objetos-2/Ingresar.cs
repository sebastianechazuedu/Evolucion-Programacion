using System;
using System.Collections.Generic;
namespace Programacion_Orientada_Objetos_2
{
    class Ingresar
    {
        public static void IngresoDatos(Empleado[] empleados, List<Afiliado> afiliados)
        {
            for (int i = 0; i < empleados.Length; i++)
            {
                Empleado emp = new Empleado();
                string linea;
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
        }
    }
}