using System;
using System.Collections.Generic;
using System.Text;

namespace FotocopiadoaUR
{
    internal class Inventario
    {
        private Dictionary<string, Libreria> productos = new Dictionary<string, Libreria>();
        private Dictionary<string, (int, string)> herramientas = new Dictionary<string, (int, string)>();

        public int ContarProductos()
        {
            return productos.Count;
        }

        public int ContarHerramientas()
        {
            return herramientas.Count;
        }

        public void AgregarProductos(Libreria libreria)
        {
            productos.Add(libreria.CodigoProducto, libreria);
        }

        public void AgregarHerramienta(string nombre, int cantidadDisponible, string comentario)
        {
            herramientas.Add(nombre, (cantidadDisponible, comentario));
        }
    }
}
