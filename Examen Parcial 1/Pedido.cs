using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void registrarPedido( List<Cliente> clientes)
        {
            bool existe=false;
            Console.WriteLine("Ingrese el numero de pedido");
            int numero= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha del pedido");
            string fecha = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre  del Cliente");
            string nombre= Console.ReadLine().ToUpper();
            foreach(Cliente cliente in clientes)
            {
                if (cliente.ExisteCliente(nombre) == true)
                {
                    NumeroPedido = numero;
                    Fecha = fecha;
                    ClientePedido = cliente;
                    existe=true;
                    break;
                }
            }

            if (existe == false)
            {
                Console.WriteLine("No existe ese cliente para registrar el pedido");
            }

        }
        public void MostrarDetallesPedido()
        {
            Console.WriteLine($" Numero {NumeroPedido} Fecha: {Fecha} Cliente: {ClientePedido.Nombre}");
        }

    }
}
