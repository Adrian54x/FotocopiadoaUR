using System;
using System.Collections.Generic;
using System.Text;

namespace FotocopiadoaUR
{
    internal class Administrador
    {
        private string codigoUsuario;
        private string nombreUsuario;
        private string password;
        private DateTime fechaNacimiento;
        private string asignado;

        public string CodigoUsuario
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public string Asignado
        {
            get { return asignado; }
            set { asignado = value; }
        }

        public Administrador(string codigoUsuario, string nombreUsuario, string password, DateTime fechaNacimiento, string asignado)
         {
            CodigoUsuario = codigoUsuario;
            NombreUsuario = nombreUsuario;
            Password = password;
            FechaNacimiento = fechaNacimiento;
            Asignado = asignado;
        }

        public int CalcularEdad()
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (DateTime.Today.Day < fechaNacimiento.Day && DateTime.Today.Month <= fechaNacimiento.Month)
            {
                edad--;
            }
            return edad;
        }

        public virtual void MostarDtos()
        {
            Console.WriteLine($"\nCodigo:{codigoUsuario} \nNombre:{nombreUsuario} \nContraseña:{password} \nEdad:{CalcularEdad()} \nAsignado:{asignado}");
        }

        public void GuardarDatos(string ruta)
        {
            File.WriteAllText(ruta, ExtraerInformacion());
        }

        public virtual string ExtraerInformacion()
        {
            return "Codigo de usuario:" + codigoUsuario + Environment.NewLine + "Nombre:" + nombreUsuario + Environment.NewLine +
                   "Contraseña:" + password + Environment.NewLine + "Fecha de nacimiento" + Environment.NewLine + 
                   "Categoria:"+ asignado + Environment.NewLine + "------------------------" + Environment.NewLine;
        }
    }
}
