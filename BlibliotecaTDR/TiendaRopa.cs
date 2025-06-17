using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlibliotecaTDR
{
    public class TiendaRopa
    {
        private Prenda[] prendas;
        private Carrito[] carrito;
        private int totalItems = 0;
        public TiendaRopa()
        {
            prendas = new Prenda[]
            {
            new Prenda("Camisa", new string[] { "S", "M", "L", "XL" }, 49.90m), 
            new Prenda("Casaca", new string[] { "S", "M", "L" }, 89.90m),
            new Prenda("Pantalón", new string[] { "28", "30", "32", "34", "36" }, 69.50m),
            new Prenda("Zapatos", new string[] { "38", "39", "40", "41", "42" }, 120.00m),
            new Prenda("Calzoncillos", new string[] { "S", "M", "L" }, 25.00m),
            new Prenda("Medias", new string[] { "Única" }, 9.90m)
            }; 
            carrito = new Carrito[100];
        }
        public void MostrarMenu()
        {
            while (true)
            {
                Console.Clear(); 

                Console.WriteLine("=== Bienvenido a la Tienda de Ropa UPN ===");
                for (int i = 0; i < prendas.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + prendas[i].Nombre + " - S/. " + prendas[i].Precio);
                }

                Console.WriteLine("0. Finalizar compra");

                Console.Write("Seleccione una prenda: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 0 || opcion > prendas.Length)

                {
                    Console.WriteLine("Opción no válida. Presione Enter para continuar...");
                    Console.ReadLine();
                    continue;
                }
                if (opcion == 0)
                {
                    FinalizarCompra(); 
                    break; 
                }

                Prenda prendaSeleccionada = prendas[opcion - 1];

                Console.Clear();

                Console.WriteLine("Has seleccionado: " + prendaSeleccionada.Nombre); 

                prendaSeleccionada.MostrarTallas(); 

                Console.Write("Elige una talla: "); 

                if (int.TryParse(Console.ReadLine(), out int tallaSeleccion) &&
                    tallaSeleccion >= 1 && tallaSeleccion <= prendaSeleccionada.TallasDisponibles.Length)
                {
                    string talla = prendaSeleccionada.TallasDisponibles[tallaSeleccion - 1];
                    Console.Write("Cantidad: "); 
                    if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
                    {
                        carrito[totalItems] = new Carrito
                        {
                            Nombre = prendaSeleccionada.Nombre, 
                            Talla = talla,                      
                            Precio = prendaSeleccionada.Precio, 
                            Cantidad = cantidad                 
                        };

                        totalItems++; 

                        Console.WriteLine("Añadido al carrito: " + prendaSeleccionada.Nombre + " - Talla " + talla + " - Cantidad: " + cantidad);
                    }
                    else
                    {
                        Console.WriteLine("Cantidad no válida."); 
                    }
                }
                else
                {
                    Console.WriteLine("Talla no válida."); 
                }
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
            }
        }
        private void FinalizarCompra()
        {
            Console.Clear(); 
            Console.WriteLine("=== RESUMEN DE COMPRA ===");
            if (totalItems == 0)
            {
                Console.WriteLine("No compraste ningún producto.");
            }
            else
            {
                decimal totalGeneral = 0; 
                for (int i = 0; i < totalItems; i++)
                {
                    var item = carrito[i]; 
                    Console.WriteLine("Producto: " + item.Nombre + 
                                      " | Talla: " + item.Talla +
                                      " | Cantidad: " + item.Cantidad +
                                      " | Precio: S/. " + item.Precio +
                                      " | Subtotal: S/. " + item.Total);

                    totalGeneral += item.Total; 
                }
                Console.WriteLine("TOTAL A PAGAR: S/. " + totalGeneral);
            }
            Console.WriteLine("Gracias por tu compra. ¡Vuelve pronto!");
            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine(); 
        }
    }
}
