using System;
using System.Collections.Generic;
using System.Text;

namespace FotocopiadoaUR
{
    internal class Usuario
    {
        private Dictionary<string, Administrador> usuarios = new Dictionary<string, Administrador>();

        public int ContarUsuarios()
        {  
            return usuarios.Count; 
        }

        public void AgregarUusarios(Administrador usuario)
        {
            usuarios.Add(usuario.CodigoUsuario,usuario);    
        }

        public string SaberPropiedad(string usuarioPropiedad)
        {
            string asignado = "";
            foreach (var au in usuarios)
            {
                if (au.Value.NombreUsuario == usuarioPropiedad)
                {
                    asignado = au.Value.Asignado;
                }
            }
            return asignado;
        }

        public bool BuscarUsuario(string usuariox, string passwordx)
        {
            bool verificar = false;
            foreach (var up in usuarios)
            {
                if (up.Value.NombreUsuario == usuariox && up.Value.Password == passwordx)
                {
                    verificar = true;
                }
            }
            return verificar;
        }

        public void MostarDatosUsuario(string asignadoA)
        {
            foreach(var md in usuarios)
            {
                if(md.Value.Asignado.Contains(asignadoA))
                {
                    md.Value.MostarDtos();
                }
            }
        }
    }
}
