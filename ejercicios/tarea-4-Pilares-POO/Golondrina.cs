using System;
public class Golondrina: Loro
{
    public bool VuelaLejos { get; set; }
    
    public void temporada()
    {
        tiempo();
    }
    private void tiempo()
    {
        Console.WriteLine("Vuelan hullendo del invierno");
    }
}