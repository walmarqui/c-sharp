using System;
using System.Collections.Generic;
public class Reservaciones
{
    public void Reservacion(string Nombre, double Id, int Telefono)
    {
            Console.WriteLine("Registro de Cliente: ");
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("No Identidad: ");
            Id = Convert.ToDouble(Console.ReadLine());
            Console.Write("Telefono: ");
            Telefono = Convert.ToInt32(Console.ReadLine());
        

            int habitacionC = 11;
            int habitacionD = 8;
            int habitacionF = 6;
            int opcion ;

            Console.Clear();
            Console.WriteLine("Elija un tipo de Habitacion ");
            Console.WriteLine();
            Console.WriteLine("1 - Cencilla");
            Console.WriteLine("2 - Doble ");
            Console.WriteLine("3 - Familiar ");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
        
                habitacionC = habitacionC - 1;
                Console.WriteLine("Bienvenido " + Nombre + " " + "su numero de habitacion es " + habitacionC);
                Console.ReadLine();
           
            }else if (opcion == 2)
            {
                habitacionD = habitacionD - 1;
                Console.WriteLine("Bienvenido " + Nombre + " " + "su numero de habitacion es " + habitacionD);
                Console.ReadLine();
            }else if (opcion == 3)
            {
                habitacionF = habitacionF - 1;
                Console.WriteLine("Bienvenido " + Nombre + " " + "su numero de habitacion es " + habitacionF);
                Console.ReadLine();
            }
        
        
    }
}