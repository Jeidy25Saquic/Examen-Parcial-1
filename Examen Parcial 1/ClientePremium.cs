using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_1
{
    internal class ClientePremium: Cliente
    {
        public double Descuento {  get; set; }

        public override void SolicitarDatos()
        {
            base.SolicitarDatos();
            Console.WriteLine("Ingrese el descuento especial");
            double descuento= Convert.ToDouble(Console.ReadLine());
            Descuento = descuento;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Descuento Especial: {Descuento}");
        }

    }
}
