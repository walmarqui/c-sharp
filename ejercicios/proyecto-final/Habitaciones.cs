using System;
public class Habitaciones
{

    public void describirHabitacion()
    {
        aCensilla();
        aDoble();
        aFamiliar();
    }
    private void aCensilla()
    {
        Console.Clear();
        Console.WriteLine("Descripcion de Habitacion Cencilla:");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Camas disponibles: 1");
        Console.WriteLine("Television por cable: si");
        Console.WriteLine("Aire acondicionado: no");
        Console.WriteLine("Acceso a Internet: si");
        Console.WriteLine("Precio: Lps.500");
        Console.ReadLine();
    }
    private void aDoble()
    {   
        Console.Clear();
        Console.WriteLine("Descripcion de Habitacion Doble:");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Camas disponibles: 2");
        Console.WriteLine("Television por cable: si");
        Console.WriteLine("Aire acondicionado: si");
        Console.WriteLine("Acceso a Internet: si");
        Console.WriteLine("Precio: Lps.750");
        Console.ReadLine();
    }
    private void aFamiliar()
    {
        Console.Clear();
        Console.WriteLine("Descripcion de Habitacion Familiar:");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Camas disponibles: 3");
        Console.WriteLine("Television por cable: si");
        Console.WriteLine("Aire acondicionado: si");
        Console.WriteLine("Acceso a Internet: si");
        Console.WriteLine("Precio: Lps.1000");
        Console.ReadLine();
    }
 
}