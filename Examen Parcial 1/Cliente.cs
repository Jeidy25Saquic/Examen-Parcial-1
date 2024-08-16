using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_1
{
    public  class Cliente
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Cliente(string nombre, string correo, string direccion)
        {
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
        }

        public Cliente()
        {
        }

        public virtual  void SolicitarDatos()
        {
            Console.WriteLine("Ingrese el nombre del cliente");
            string nombre= Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese el correo del cliente");
            string correo = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion del cliente");
            string direccion  = Console.ReadLine();
            Nombre= nombre;
            Correo = correo;
            Direccion = direccion;


        }
          
        public bool ExisteCliente( string nombre)
        {
            bool existe = true;

            if (Nombre!= nombre)
            {
                existe = false;
            }
            return existe;

        }
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre} Correo: {Correo} Direccion {Direccion}");
        }
    }
}
