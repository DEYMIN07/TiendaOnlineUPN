using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlibliotecaTDR
{
    public class Carrito
    {
        public string Nombre { get; set; } 


        public string Talla { get; set; }


        public decimal Precio { get; set; }


        public int Cantidad { get; set; }


        public decimal Total => Precio * Cantidad;
    }
}
