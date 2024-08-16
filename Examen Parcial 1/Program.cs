using Examen_Parcial_1;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Pedido> pedidos = new List<Pedido>();
       
        bool continuar = true;
        int opcion = 0;

        do
        {
            try
            {

                Console.WriteLine("1. Agregar Cliente");
                Console.WriteLine("2. Registrar Pedidos");
                Console.WriteLine("3. Detalles de  Cliente");
                Console.WriteLine("4. Detalles de  Pedido");
                Console.WriteLine("5. Buscar Cliente");
                Console.WriteLine("6. Buscar Pedido");
                Console.WriteLine("7. salir");



                opcion = Convert.ToInt32(Console.ReadLine());
                while (opcion < 1 || opcion > 10)
                {
                    Console.WriteLine("Valor no esta en el rango...");
                    Console.WriteLine("Ingrese un valor: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        switch (AgregarCliente())
                        {
                            case 1:
                                ClienteEstandar clienteEstandar = new ClienteEstandar();
                                clienteEstandar.SolicitarDatos();
                                clientes.Add(clienteEstandar);
                                Console.WriteLine("Se agrego correctamente");
                                break;
                            case 2:
                                ClientePremium clientePremium = new ClientePremium();
                                clientePremium.SolicitarDatos();
                                clientes.Add(clientePremium);
                                Console.WriteLine("Se agrego correctamente");
                                break;
                        }


                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2. Registrar Pedidos");
                        Pedido pedido = new Pedido();
                        if (pedido.registrarPedido(clientes, pedidos) == true)
                        {
                            pedidos.Add(pedido);
                        }
                        Console.WriteLine();

                        break;


                    case 3:
                        Console.Clear();
                        Console.WriteLine("Detalles de Clientes");
                        Console.WriteLine();
                        MostrarClientes(clientes);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Detalles de Pedido");
                        MostrarClientes(pedidos);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Buscar Clientes");
                        BuscarClientes(clientes);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Buscar  Pedido");
                        BuscarPedido(pedidos);
                        Console.WriteLine();
                        break;

                    case 7:
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("no agregado");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error... " + ex.Message);
            }
        } while (continuar == true);
    }


    static int  AgregarCliente()
    {
        int opcion = 0;
        Console.WriteLine("1. Estandar");
        Console.WriteLine("2. Premium");
        opcion=int.Parse(Console.ReadLine());

        return opcion;

    }

    static void MostrarClientes(List<Cliente> clientes)
    {
        int numeroCliente = 0;
        foreach (Cliente cliente in clientes)
        {
            numeroCliente++;
            Console.WriteLine($"Cilente #{numeroCliente}");
            cliente.MostrarDetalles();
            Console.WriteLine();
        }
    }
    static void BuscarClientes(List<Cliente> clientes)
    { bool existe=false;
        Console.WriteLine("Ingrese el nombre del cliente");

        string nombre=Console.ReadLine().ToUpper();
       
        foreach (Cliente cliente in clientes)
        {  
            if (cliente.ExisteCliente(nombre) == true)
            {
                cliente.MostrarDetalles();
               existe= true;
                break;
            }
        }

       if (existe== false)
        {
            Console.WriteLine("No existe el cliente");
        }

    }

    static void MostrarClientes(List<Pedido> pedidoss)
    {
       
        foreach (Pedido pedido in pedidoss)
        {
            
            pedido.MostrarDetallesPedido();
            Console.WriteLine();
        }
    }

    static void BuscarPedido(List<Pedido> pedidos)
    {
        bool existe = false;
        Console.WriteLine("Ingrese el numero del pedido");

       int numeroPedido= int.Parse(Console.ReadLine());

        foreach (Pedido pedido in pedidos)
        {
            if (pedido.ExistePedido(numeroPedido) == true)
            {
                pedido.MostrarDetallesPedido();
                existe= true;
                break;
            }
        }

        if (existe == false)
        {
            Console.WriteLine("No existe el cliente");
        }

    }


}