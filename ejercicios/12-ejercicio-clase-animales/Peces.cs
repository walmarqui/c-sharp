using System;
public class Peces:animal
{
    public string Nadar { get; set; }
    public void aletas()
    {
        cantidadAletas();
    }
    private void cantidadAletas()
    {
        Console.WriteLine("tienen 2 aletas");
    }
}