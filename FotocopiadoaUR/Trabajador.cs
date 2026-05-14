using System;
using System.Collections.Generic;
using System.Text;

namespace FotocopiadoaUR
{
    internal class Trabajador : Administrador
    {
        private string numeroTelefono;

        public string NumeroTelefono
        {
            get { return numeroTelefono; }
            set { numeroTelefono = value; }
        }

        public Trabajador(string codigoUsuario, string nombreUsuario, string password, DateTime fechaNacimiento, string asignado, string numeroTelefono) 
            : base(codigoUsuario, nombreUsuario, password, fechaNacimiento, asignado)
        {
            NumeroTelefono = numeroTelefono;
        }
        public override void MostarDtos()
        {
            base.MostarDtos();
            Console.WriteLine($"Numero de telefono: {numeroTelefono}");
        }


        public override string ExtraerInformacion()
        {
            return "Codigo de usuario:" + this.CodigoUsuario + Environment.NewLine + "Nombre:" + NombreUsuario + Environment.NewLine +
            "Contraseña:" + Password + Environment.NewLine + "Fecha de nacimiento" + Environment.NewLine +
            "NumeroTelefono:" + numeroTelefono + Environment.NewLine + "------------------------" + Environment.NewLine;
        }
    }
}
