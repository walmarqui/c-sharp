using System;
public abstract class Mamifero: animal
{
    public int Patas { get; set; }
    public void Caminar()
    {
        Console.WriteLine("Caminando...");
    }
}