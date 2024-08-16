using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examen_Parcial_1
{
    public  class Pedido
    {
     public int NumeroPedido { get; set; }   
      public string Fecha { get; set; }   
      Cliente ClientePedido { get; set; }

        public Pedido(int numeroPedido, string fecha, Cliente clientePedido)
        {
            NumeroPedido = numeroPedido;
            Fecha = fecha;
            ClientePedido = clientePedido;
        }

        public Pedido()
        {
        }

        public bool registrarPedido( List<Cliente> clientes, List<Pedido> pedidos)
        {
            bool existe = false, duplicado = false; ;
            Console.WriteLine("Ingrese el numero de pedido");
            int numero= int.Parse(Console.ReadLine());
            foreach (Pedido pedido in pedidos)
            {
                if (pedido.NumeroPedido==numero)
                {
                    Console.WriteLine(" Error: Ya existe un pedido con ese numero");
                    duplicado=true;
                    break;
                }
            }
            if (duplicado == false)
            {
                Console.WriteLine("Ingrese la fecha del pedido");
                string fecha = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre  del Cliente");
                string nombre = Console.ReadLine().ToUpper();
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.ExisteCliente(nombre) == true)
                    {
                        NumeroPedido = numero;
                        Fecha = fecha;
                        ClientePedido = cliente;
                        existe = true;
                        Console.WriteLine("Se agrego correctamente");
                        break;
                    }
                }

                if (existe == false)
                {
                    Console.WriteLine("No existe ese cliente para registrar el pedido");
                }
            }
            return existe;
        }
        public bool ExistePedido(int numeroPedido)
        {
            bool existe = true;

            if (NumeroPedido != numeroPedido)
            {
                existe = false;
            }
            return existe;

        }
        public void MostrarDetallesPedido()
        {
            Console.WriteLine($" Numero {NumeroPedido} Fecha: {Fecha} Cliente: {ClientePedido.Nombre}");
        }

    }
}
