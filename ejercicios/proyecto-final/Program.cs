using System;

namespace proyecto_final
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Habitaciones  a = new Habitaciones();
                Reservaciones r = new Reservaciones();
                string opcion = "";
                Console.Clear();
                Console.WriteLine("****************************");
                Console.WriteLine("     HOTEL TU FANTASIA");
                Console.WriteLine("****************************");
                Console.WriteLine("1 - Ver tipo de Habitaciones");
                Console.WriteLine("2 - Registrar Nuevo Cliente");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                    a.describirHabitacion();
                    break;
                    case "2":
                    r.Reservacion("",0,0);
                    break;
                    default:
                    break;
                }
                if (opcion == "0") {
                    Console.Clear();
                    break;
                }
            }
           
        }
    }
}
