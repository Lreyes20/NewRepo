using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Vendedor
    {

        public string Nombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public DateTime Nacimiento { get; set; }

        public char Genero { get; set; }

        public DateTime FechaIngreso { get; set; }

        public Articulos[] Articulos{ get; set; } 

        public Vendedor()
        {
            Nombre = string.Empty;
            PrimerApellido = string.Empty;
            SegundoApellido = string.Empty;
            Nacimiento = DateTime.MinValue;
            Genero = 'H';
            FechaIngreso = DateTime.MinValue;
            Articulos = new Articulos[20];
        }

        public Vendedor(string nombre, string primerApellido, string segundoApellido, DateTime nacimiento, char genero, DateTime fechaIngreso)
        {
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Nacimiento = nacimiento;
            Genero = genero;
            FechaIngreso = fechaIngreso;
            Articulos = new Articulos[20]; 
        }
    }

}
