using System;

namespace _11_repaso_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(1, "Juan", "000123");
            Profesor p = new Profesor(1, "Jose", 20000);
            Gerente g = new Gerente(1, "Maria", 80000);

            a.EnviarMensaje();
            p.EnviarMensaje();
            g.EnviarMensaje();

            Utilerias.formatoMoneda(100);

            Console.WriteLine(a.Nombre + " " + a.NoCarnet);
            Console.WriteLine(p.Nombre + " " + p.Salario);
            Console.WriteLine(g.Nombre + " " + g.Salario);
        }
    }
}
