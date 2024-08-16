using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_1
{
    public  class ClienteEstandar: Cliente
    {
         public string Fecha {  get; set; }

        public override void SolicitarDatos()
        {
            base.SolicitarDatos();
            Console.WriteLine("Ingrese la fecha de registro");
            string fecha= Console.ReadLine();
            Fecha = fecha;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Fecha de Registro  {Fecha}");
        }
    }
}
