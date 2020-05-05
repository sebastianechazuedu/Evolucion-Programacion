using System;
using System.Collections.Generic;

namespace Programacion_Orientada_Objetos_2
{
    class Imprimir
    {
        public static void ImpresionDatos(Empleado[] empleados, List<Afiliado> afiliados)
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