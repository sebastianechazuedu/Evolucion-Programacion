using System;

namespace Programacion_Orientada_Objetos_3
{
    public class Afiliado
    {
        public int nroAfiliado { get; set; }
        public Boolean delegado { get; set; }

        public Afiliado IngresarAfiliado(Afiliado afiliado)
        {
            Console.WriteLine("ingrese numero de afiliado: ");
            string numero = Console.ReadLine();
            afiliado.nroAfiliado = int.Parse(numero);
            Console.WriteLine("Es delegado?");
            string linea = Console.ReadLine();
            if (linea == "si")
            {
                afiliado.delegado = true;
            }
            return afiliado;
        }

        public void ImprimirAfiliado(Afiliado afiliado)
        {
            Console.WriteLine("es afiliado al sindicato con el numero: " + afiliado.nroAfiliado);
            if (afiliado.delegado == true)
            {
                Console.WriteLine("Es delegado del sindicato");
            }
        }
    }
}
