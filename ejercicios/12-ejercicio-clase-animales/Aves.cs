using System;
public abstract class Aves: animal
{
    public int Patas { get; set; }
    public void leSirven()
    {
        Console.WriteLine("Para agarrar");
    }

}