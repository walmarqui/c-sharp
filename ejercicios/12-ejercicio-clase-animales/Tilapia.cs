using System;
public class Tilapia: Payaso
{
    public bool esComestible { get; set; }

    public void alimento()
    {
        saludable();
    }
    private void saludable()
    {
        Console.WriteLine("Es un buen alimento");
    }
}