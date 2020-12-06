using System;
public class Gato: Perro
{
    public string Pelaje { get; set; }
    public void Maullar()
    {
        Console.WriteLine("Miau Miau Miau");
    }
    public void comida()
    {
        comeCarne();
    }
    private void comeCarne()
    {
        Console.WriteLine("Le gustan los ratones");
    }
}