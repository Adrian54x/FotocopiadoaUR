using System;
using System.Collections.Generic;
using System.Text;

namespace FotocopiadoaUR
{
    internal class Metodos
    {
        // Validaciones simples

        public void OpcionNoValida()
        {
            Console.WriteLine("Opcion no existente!");
            Thread.Sleep(1000);
        }
        public void MostrarRegresar()
        {
            Console.Write("Regresando");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
        }

        public void Error()
        {
            Console.Write("Ingreso no valido!");
            Thread.Sleep(500);
            Console.Write("-----> Intente otra ves:");
        }

        public int ValidarMenu()
        {
            int validarMenu;
            bool valM;
            do
            {
                valM = true;
                if (!int.TryParse(Console.ReadLine(), out validarMenu) || validarMenu < 0)
                {
                    valM = false;
                    Error();
                }
            } while (!valM);
            return validarMenu;
        }

        public string ValidarTexto(int cantidadMinimaCaracters)
        {
            string textoValido;
            do
            {
                textoValido = Console.ReadLine();
                if (textoValido.Length < cantidadMinimaCaracters)
                {
                    Error();
                }
            } while (textoValido.Length < cantidadMinimaCaracters);
            return textoValido;
        }

        // Opciones de ingreso 

        public Libreria IngresoProductos()
        {
            Inventario agregar = new Inventario();
            string codigoProducto = GeneradorCodigos(agregar.ContarProductos());

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(El nombre del producto tiene que tener 3 o mas caracteres)");
            Console.ResetColor();
            Console.WriteLine("Nombre del producto:");
            string nombreProducto = ValidarTexto(4);

            double precio =;
            int unidadesDisponibles;
            string marca;
            string asignatura;
            string descripcion;

        }

        public Administrador IngresoUsuarios(string asignadoA)
        {
            Usuario agrgar = new Usuario();
            string codigo = "UR" + GeneradorCodigos(agrgar.ContarUsuarios());

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"(El {asignadoA} tiene que tener 3 o mas caracteres y solo contener letras )");
            Console.ResetColor();
            Console.Write("Usuario:");
            string usuario = ValidarNombre();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(La contraseña debe tener al menos 1 Mayuscula, 1 Numero y 8 a 15 Caracteres)");
            Console.ResetColor();
            Console.Write("Contraseña:");
            string pass = PassWord();

            Console.Write("Fecha de nacimiento:");
            DateTime fecha = FechaNacimiento();

            if (asignadoA == "Administrador")
            {
                return new Administrador(codigo, usuario, pass, fecha, asignadoA);
            }
            else
            {
                Console.Write("Numero telefonico:");
                string numeroTelefono = NumeroTelefono();
                return new Trabajador(codigo, usuario, pass, fecha, asignadoA, numeroTelefono);
            }
        }

        public string GeneradorCodigos(int codigoActual)
        {
            string codigoGenerado = "0" + (codigoActual + 1).ToString();
            return codigoGenerado;
        }

        public string ValidarNombre()
        {
            string nombreValido;
            bool nombreerror = false;
            do
            {
                nombreValido = Console.ReadLine();
                foreach (char nv in nombreValido)
                {
                    if (nv < 'a' || nv > 'z' || nv < 'A' || nv > 'Z')
                        nombreerror = true;
                }
                if (nombreValido.Length < 3 || nombreerror)
                {
                    Error();
                }
            } while (nombreValido.Length < 3 || nombreerror);
            return nombreValido;
        }

        public string PassWord()
        {
            string passValida;
            int passNumeros, passMayusculas;
            do
            {
                passNumeros = 0;
                passMayusculas = 0;
                passValida = Console.ReadLine();
                if (passValida.Length >= 8 && passValida.Length <= 15)
                {
                    foreach (char v in passValida)
                    {
                        if (v >= 'A' && v <= 'Z')
                        {
                            passMayusculas++;
                        }
                        if (v >= '1' && v <= '9')
                        {
                            passNumeros++;
                        }
                    }
                }
                if (passValida.Length < 8 || passValida.Length > 15 || passNumeros == 0 || passMayusculas == 0)
                {
                    Error();
                }
            } while (passValida.Length < 8 || passValida.Length > 15 || passNumeros == 0 || passMayusculas == 0);
            return passValida;
        }

        public DateTime FechaNacimiento()
        {
            DateTime fechaEdad;
            bool validarFecha;
            do
            {
                validarFecha = DateTime.TryParse(Console.ReadLine(), out fechaEdad);
                if (!validarFecha || (DateTime.Today.Year - fechaEdad.Year) < 14 || fechaEdad.Year < 1925)
                {
                    Error();
                }
            } while (!validarFecha || (DateTime.Today.Year - fechaEdad.Year) < 14 || fechaEdad.Year < 1925);
            return fechaEdad;
        }

        public string NumeroTelefono()
        {
            string telefono;
            bool validarTelefono;
            do
            {
                validarTelefono = false;
                telefono = Console.ReadLine();
                foreach (char tv in telefono)
                {
                    if (tv < '0' || tv > '9')
                    {
                        validarTelefono = true;
                    }
                }
                if (validarTelefono || telefono.Length < 8)
                {
                    Error();
                }
            } while (validarTelefono || telefono.Length < 8);
            return telefono;
        }

        public double Precio()
        {
            double validarPrecio;
            do 
            { 
                double
            }
            return validarPrecio;
        }
    }
}
