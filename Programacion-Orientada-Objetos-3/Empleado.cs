using System;
namespace Programacion_Orientada_Objetos_3
{
    public class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Afiliado afiliado { get; set; }
        public Empleado IngresarEmpleado(Empleado empleado)
        {
            string linea;
            Console.WriteLine("ingrese un nombre:");
            empleado.nombre = Console.ReadLine();
            Console.WriteLine("ingrese un apellido:");
            empleado.apellido = Console.ReadLine();
            Console.WriteLine("Es afiliado?");
            linea = Console.ReadLine();
            if (linea != "si")
            {
                empleado.afiliado = null;
            }
            else
            {
                empleado.afiliado.IngresarAfiliado(afiliado);
            }
            return empleado;
        }

        public void ImprimirEmpleado(Empleado empleado, int orden)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Empleado nro: " + (orden + 1));
            Console.WriteLine("nombre: " + empleado.nombre);
            Console.WriteLine("Apellido: " + empleado.apellido);

            if (empleado.afiliado != null  && empleado.apellido == "perez")
            {
               empleado.afiliado.ImprimirAfiliado(afiliado);
            }
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
