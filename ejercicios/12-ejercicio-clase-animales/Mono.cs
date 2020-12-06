using System;
public class Mono: Gato
{
    public bool EsJugueton { get; set; }

    public void gritar()
    {
        Console.WriteLine("uuuuh uuuuh uuuuh aaaaah");
    }
    public Mono()
    {
        EsJugueton = true;
    }
    public void leGusta()
    {
        describirLeGusta();
    }
    private void describirLeGusta()
    {
        Console.WriteLine("Al mono le gustan las bananas.");
    }
}