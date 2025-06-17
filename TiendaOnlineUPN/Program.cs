using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlibliotecaTDR;

namespace TiendaOnlineUPN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TiendaRopa tienda = new TiendaRopa();
            tienda.MostrarMenu();
        }
    }
}
