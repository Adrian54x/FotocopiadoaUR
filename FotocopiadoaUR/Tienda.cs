using System;
using System.Collections.Generic;
using System.Text;

namespace FotocopiadoaUR
{
    internal class Tienda : Libreria
    {
        private DateTime fechaVencimiento;
        
        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        public Tienda(string codigoProducto, string nombreProducto, double precio, int unidadesDisponibles, string marca, string asignatura, string descripcion, DateTime fechaVencimiento)
            :base(codigoProducto, nombreProducto, precio, unidadesDisponibles, marca, asignatura, descripcion)
        {
            FechaVencimiento = fechaVencimiento;
        }
    }
}
