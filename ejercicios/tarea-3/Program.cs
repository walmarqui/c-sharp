using System;

namespace tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdePrueba datos = new DatosdePrueba();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Ordenes");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Productos");
                Console.WriteLine("2 - Lista de Vendedores");
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Crear Orden");
                Console.WriteLine("5 - Lista de Ordenes");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;
                    case "2":
                        datos.ListarVendedores();
                        break;
                    case "3":
                        datos.ListarClientes();
                        break;
                    case "4":
                        datos.CrearOrden();
                        break;      
                    case "5":
                        datos.ListarOrdenes();
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}