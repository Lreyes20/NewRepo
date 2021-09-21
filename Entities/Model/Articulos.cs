using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Articulos
    {
        public int ID { get; set; }

        public string Descripcion { get; set; }

        public bool Activo { get; set; }

        public decimal PrecioVendor { get; set; }

        public decimal PrecioFinal { get; set; }

        public int CantidadDisponible { get; set; }

      

        public Articulos()
        {
            ID = -1;
            Descripcion = string.Empty;
            Activo = true;
            PrecioVendor = 0;
            PrecioFinal = 0;
            CantidadDisponible = -1;
           
        }

        public Articulos(int iD, string descripcion, bool activo, decimal precioVendor, decimal precioFinal, int cantidadDisponible)
        {
            ID = iD;
            Descripcion = descripcion;
            Activo = activo;
            PrecioVendor = precioVendor;
            PrecioFinal = precioFinal;
            CantidadDisponible = cantidadDisponible;
          
        }
    }
}
