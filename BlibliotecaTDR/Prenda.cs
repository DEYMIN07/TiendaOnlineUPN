using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlibliotecaTDR
{
    public class Prenda
    {    
        public string Nombre { get; set; }
      
        public string[] TallasDisponibles { get; set; }

        public decimal Precio { get; set; }
     
        public Prenda(string nombre, string[] tallas, decimal precio)
        {          
            Nombre = nombre;

            TallasDisponibles = tallas;

            Precio = precio;
        }

        public void MostrarTallas()
        {
            Console.WriteLine("Tallas disponibles:");

            int i = 0;

            while (i < TallasDisponibles.Length)
            {
                Console.WriteLine((i + 1) + ". " + TallasDisponibles[i]);

                i++;
            }
        }
    }
}
