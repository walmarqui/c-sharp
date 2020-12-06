using System;
public class Payaso: Peces
{
    public string habitat { get; set; }

    public void tipoAgua()
    {
        Agua();
    }
    private void Agua()
    {
        Console.WriteLine("Vive en agua salada");
    }

}