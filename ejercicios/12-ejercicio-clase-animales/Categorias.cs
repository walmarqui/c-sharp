using System;
public class Categorias: animal
{
    public void mAnimales()
    {
        Mamiferos();
        Console.ReadLine();
    }
    public void aAves()
    {
        Aves();
        Console.ReadLine();
    }
    public void aPeces()
    {
        Peces();
        Console.ReadLine();
    }
    private void Mamiferos()
    {
        Console.Clear();
        Console.WriteLine("Animales Mamiferos");
        Console.WriteLine("------------------");
        Console.WriteLine("Tipo: Perro");
        Perro p = new Perro();
            p.Nombre = "Firulais";
            p.Patas = 4;
            p.EsDomestico = true;
           
        Console.WriteLine("Nombre: " + p.Nombre);
        Console.WriteLine("Cantidad de patas: " + p.Patas);
        Console.WriteLine("Es un animal domestico?: " + p.EsDomestico);
            p.Comer();
            p.Caminar();
        Console.Write("Ladra: ");
            p.Ladrar();

        Console.WriteLine();
        Console.WriteLine("Tipo: Gato");

         Gato g = new Gato();
            g.Nombre = "Gardfield";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.EsDomestico = true;
        Console.WriteLine("Nombre: " + g.Nombre);
        Console.WriteLine("Cantidad de patas: " + g.Patas);
        Console.WriteLine("Es un animal domestico?: " + g.EsDomestico);
        Console.WriteLine("Tipo de piel: " + g.Pelaje);
            g.Comer();
            g.Caminar();
        Console.Write("Maulla: " );
            g.Maullar();

        Console.WriteLine();
        Console.WriteLine("Tipo: Mono");
         Mono m = new Mono();
            m.Nombre = "Chita";
            m.Patas = 2;
            m.Pelaje = "Peludo";
            m.EsJugueton = true;
            m.EsDomestico = false;
        Console.WriteLine("Nombre: " + m.Nombre);
        Console.WriteLine("Cantidad de patas: " + m.Patas);
        Console.WriteLine("Es un animal domestico?: " + m.EsDomestico);
        Console.WriteLine("Tipo de piel: " + m.Pelaje);
        Console.Write("Le gusta jugar: " );
        Console.WriteLine(m.EsJugueton);
        Console.Write("Grita: " );
            m.gritar();
            m.leGusta();

           // Console.ReadLine();
    }
     private void Aves()
    {
        Console.Clear();
        Console.WriteLine("Aves");
        Console.WriteLine("----");
        Console.WriteLine();
        Console.WriteLine("Tipo: Aguila");
        Aguila ag = new Aguila();
            ag.Nombre = "Real";
            ag.Patas = 2;
            ag.Alas = true;
        Console.WriteLine("Nombre: " + ag.Nombre);
        Console.WriteLine("Cantidad de patas: " + ag.Patas);
        Console.Write("Le sirven ");
            ag.leSirven();
        Console.WriteLine("Tiene alas: " + ag.Alas);
        Console.Write("Le sirven para: ");
            ag.Volar();

        Console.WriteLine();
        Console.WriteLine("Tipo: Loro");
          Loro l = new Loro();
            l.Patas = 2;
            l.Nombre = "Paco";
            l.Alas = true;
        Console.WriteLine("Nombre: " +  l.Nombre);
        Console.WriteLine("Cantidad de patas: " + l.Patas);
        Console.Write("Le sirven ");
            l.leSirven();
            l.Plumaje();
        Console.WriteLine("Tiene alas: " + l.Alas);
            l.Comer();
        
        Console.WriteLine();
        Console.WriteLine("Tipo: Golondrina");
        Golondrina gl = new Golondrina();
            gl.Nombre = "Carmen";
            gl.Patas = 2;
            gl.Alas = true;
        Console.WriteLine("Nombre: " + gl.Nombre);
        Console.WriteLine("Cantidad de patas: " + gl.Patas);
        Console.WriteLine("Tiene alas: " + true);
            gl.temporada();
            gl.Comer();
    }
    private void Peces()
    {
        Console.Clear();
        Console.WriteLine("Peces");
        Console.WriteLine("-----");
        Console.WriteLine();
        
        Payaso py = new Payaso();
        py.Nombre = "Payaso";
        py.habitat = "Oceano";
        py.Nadar ="En arrecifes";
        Console.WriteLine("Nombre: " + py.Nombre);
        py.aletas();
        Console.WriteLine("Vive en el " + py.habitat);
        Console.WriteLine("Nada: " + py.Nadar);
        py.tipoAgua();
        py.Comer();
        
        Console.WriteLine();
        Tilapia t = new Tilapia();
        t.Nombre = "Tilapia";
        t.esComestible = true;
        Console.WriteLine("Nombre: " + t.Nombre);
        t.habitat = "Peceras";
        Console.WriteLine("Vive en " + t.habitat);
        t.alimento();
        t.aletas();
        t.Comer();
    }
}
 