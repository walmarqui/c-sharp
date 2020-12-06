using System;
public class Loro: Aguila
{
    public bool colorPlumaje { get; set; }

    public void Plumaje()
    {
        Colorido();
    }
    private void Colorido()
    {
        Console.WriteLine("Su plumaje es muy colorido");
    }
}