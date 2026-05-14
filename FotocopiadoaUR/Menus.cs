using System;
using System.Collections.Generic;
using System.Text;

namespace FotocopiadoaUR
{
    internal class Menus
    {
        public string MenuIngreso()
        {
            Usuario buscar = new Usuario();
            string usuarioIngreso, passIngreso, asignado = "";
            int intentos = 5;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Bienvenido al Sistema Fotocopias UR ===");
                Console.Write("Ingrese su Usuario:");
                usuarioIngreso = Console.ReadLine();
                Console.Write("Ingrese su Contraseña:");
                passIngreso = Console.ReadLine();
                if (!buscar.BuscarUsuario(usuarioIngreso, passIngreso))
                {
                    Console.Write("Usuario no encontrado!");
                    Thread.Sleep(500);
                    Console.Write("-----> Intente otra ves");
                    Thread.Sleep(500);
                    intentos--;
                }
                else
                {
                    asignado = buscar.SaberPropiedad(usuarioIngreso);
                }
                if (intentos == 0)
                {
                    Console.WriteLine("Llego al limite de intentos!");
                    break;
                }
            } while (!buscar.BuscarUsuario(usuarioIngreso, passIngreso));
            return asignado;
        }

        public void MenuAdmin()
        {
            Console.Clear();
            Console.WriteLine("=== Fotocopias UR ===");
            Console.WriteLine("1. Productos");
            Console.WriteLine("2. Usuario");
            Console.WriteLine("3. Ingresos y Egresos");
            Console.WriteLine("4. Fotocopiadora");
            Console.WriteLine("5. Comentarios");
            Console.WriteLine("6. Herramientas disponibles");
            Console.WriteLine("0. Salir.");
            Console.Write("Elija una opcion:");
        }

        public void MenuTrabajador()
        {
            Console.Clear();
            Console.WriteLine("=== Fotocopias UR ===");
            Console.WriteLine("1. Ver todos los productos");
            Console.WriteLine("2. Administrar Ventas");
            Console.WriteLine("3. Comentarios");
            Console.WriteLine("4. Ver subtotal de ganancias");
            Console.WriteLine("5. Herramientas disponibles");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opcion:");
        }

        public void MenuProductos()
        {
            Console.Clear();
            Console.WriteLine("--- Productos ---");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Ver todos los productos");
            Console.WriteLine("3. Buscar Productos");
            Console.WriteLine("4. Eliminar Productos");
            Console.WriteLine("5. Suspender Producto");
            Console.WriteLine("6. Modificar Producto");
            Console.WriteLine("0. Regresar.");
            Console.Write("Elija una opcion:");
        }
        public void MenuUsuario()
        {
            Console.Clear();
            Console.WriteLine("--- Usuario ---");
            Console.WriteLine("1. Agregar Trabajador");
            Console.WriteLine("2. Agregar Administrador");
            Console.WriteLine("3. Ver Usuarios");
            Console.WriteLine("4. Buscar Usuario");
            Console.WriteLine("0. Regresar.");
            Console.Write("Elija una opcion:");
        }
        public void MenuIngresosEgresos()
        {
            Console.Clear();
            Console.WriteLine("--- Ingresos y Egresos ---");
            Console.WriteLine("1. Agregar Ingresos");
            Console.WriteLine("2. Agregar Egresos");
            Console.WriteLine("3. Ver resumen de ingresos y egresos");
            Console.WriteLine("0. Regresar.");
            Console.Write("Elija una opcion:");
        }
        public void MenuFotocopiadora()
        {
            Console.Clear();
            Console.WriteLine("--- Fotocopiadora ---");
            Console.WriteLine("1. Ver suministros");
            Console.WriteLine("2. Fotocopias Sacadas");
            Console.WriteLine("3. Porcentaje de toner Actual");
            Console.WriteLine("0. Regresar.");
            Console.Write("Elija una opcion:");
        }
        public void MenuComentarios()
        {
            Console.Clear();
            Console.WriteLine("--- Comentarios ---");
            Console.WriteLine("1. Ver Comentarios");
            Console.WriteLine("2. Enviar Comentarios");
            Console.WriteLine("0. Regresar.");
            Console.Write("Elija una opcion:");
        }
        public void MenuHerramientas()
        {
            Console.Clear();
            Console.WriteLine("--- Herramientas ---");
            Console.WriteLine("1. Agrgar herramienta");
            Console.WriteLine("2. Eliminar herramienta");
            Console.WriteLine("3. Supender herramienta");
            Console.WriteLine("4. Ver herramientas");
            Console.WriteLine("0. Regresar.");
            Console.Write("Elija una opcion:");
        }
        public void MenuAdministrarVentas()
        {
            Console.Clear();
            Console.WriteLine("--- Administrar Ventas ---");
            Console.WriteLine("1. Tienda");
            Console.WriteLine("2. Libreria");
            Console.WriteLine("0. Regresar.");
            Console.Write("Elija una opcion:");
        }
    }
}