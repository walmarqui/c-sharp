using System;
public class Aguila: Aves
{
    public bool Alas { get; set; }

    public void Volar()
    {
        Funcion();
    }
    private void Funcion()
    {
        Console.WriteLine("Sostenerse y volar alto");
    }
}