using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Categorias categorias = new Categorias();
             string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("**********");
                Console.WriteLine(" ANIMALES ");
                Console.WriteLine("**********");
                Console.WriteLine("Seleccione una categoria");
                Console.WriteLine("");
                Console.WriteLine("1 - Mamiferos");
                Console.WriteLine("2 - Aves");
                Console.WriteLine("3 - Peces");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        categorias.mAnimales();
                    break;
                    case "2":
                        categorias.aAves();
                    break;
                    case "3":
                        categorias.aPeces();
                    break;
                    default:
                    break;
                }  

                if (opcion == "0")
                {
                    break;
               }    
            }
        }
    }
}
