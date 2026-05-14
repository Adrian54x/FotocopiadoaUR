using System;
using System.Collections.Generic;
using System.Text;

namespace FotocopiadoaUR
{
    internal class Libreria
    {
        private string codigoProducto;
        private string nombreProducto;
        private double precio;
        private int unidadesDisponibles;
        private string marca;
        private string asignatura;
        private string descripcion;

        public string CodigoProducto
        {
            get { return codigoProducto; }
            set { codigoProducto = value; }
           
        }

        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int UnidadesDisponibles
        {
            get { return unidadesDisponibles; }
            set { unidadesDisponibles = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Libreria(string codigoProducto, string nombreProducto, double precio, int unidadesDisponibles, string marca, string asignatura,string descripcion)
        {
            CodigoProducto = codigoProducto;
            NombreProducto = nombreProducto;
            UnidadesDisponibles = unidadesDisponibles;
            Marca = marca;
            Asignatura = asignatura;
            Descripcion = descripcion;
        }
    }
}
