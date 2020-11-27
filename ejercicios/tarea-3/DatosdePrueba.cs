using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Mouse  ", 250);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Teclado", 350);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Monitor", 4000);
        ListadeProductos.Add(p3);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Juan Martinez", "77777");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Pedro Escobar", "99999");
        ListadeClientes.Add(c2);
    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Jose Lopez", "V001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Pablo Ramirez", "V002");
        ListadeVendedores.Add(v2);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("===================");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }

        Console.ReadLine();
    }

    public void CrearOrden()
    {
        Console.Clear();
        Console.WriteLine("Creando Orden");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.Write("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.Write("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.Write("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }
        for (int i = 0; i < 4; i++)
        {
            Console.Write(">>>>> ");
        }
        Console.WriteLine("");
        Console.WriteLine("Subtotal es :       " + nuevaOrden.SubTotal);
        Console.WriteLine("Total impuestos es: " + nuevaOrden.Impuesto);
        Console.WriteLine("Total a pagar es:   " + nuevaOrden.Total);
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("-----");
        }

        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Ordenes");
        Console.WriteLine("================");
        Console.WriteLine("");  
        
       

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine();
            Console.WriteLine("No. de Orden |   Fecha  ");
            Console.WriteLine(" " + orden.Codigo + "   |   " + orden.Fecha);
            Console.WriteLine();
            Console.WriteLine("Nombre del Cliente: " + orden.Cliente.Nombre);
            Console.WriteLine("Nombre del Vendedor: " + orden.Vendedor.Nombre);
            Console.WriteLine();
            Console.WriteLine("Descripcion | Cantidad | Precio");
            
            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine(detalle.Producto.Descripcion + "  |   " + detalle.Cantidad + "   | " + detalle.Precio);
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("El total a pagar es:  " + orden.Total);
            Console.Write("----------------------------------");

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}