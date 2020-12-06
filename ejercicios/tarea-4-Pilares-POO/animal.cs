using System;
public abstract class animal
{
    public string Nombre { get; set; }

    public void Comer()
    {
        Console.WriteLine("Comiendo...");
    }
   
}