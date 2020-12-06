using System;
public class Perro: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }

    public Perro() // <- Polimorfismo
    {
        EsDomestico = true;
    }
    public Perro(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Ladrar()
    {
        Console.WriteLine("Gua Gua Gua"); // <- Abstraccion
    }
    public void Tamano()
    {
        DescribirTamano();
    }
    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un perro grande");
    }
}