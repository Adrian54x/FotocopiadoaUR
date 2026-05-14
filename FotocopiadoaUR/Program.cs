using FotocopiadoaUR;
Usuario usuario = new Usuario();
Metodos funcion = new Metodos();
Menus mostrar = new Menus();
string rutaUsuario = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"UsuarioUR.txt");
string[] asignatura = { "Administrador", "Trabajador" };
if (File.Exists(rutaUsuario))
{
    File.ReadAllText(rutaUsuario);
}

if (usuario.ContarUsuarios() == 0)
{
    Console.Clear();
    Console.WriteLine("=== Ingrese el Administrador Principal ===");
    string codigo0 = "UR00";

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("(El usuario tiene que tener 3 o mas caracteres y solo contener letras)");
    Console.ResetColor();
    Console.Write("Ingrese su Usuario:");
    string usuario0 = funcion.ValidarNombre();

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("(La contraseña debe tener al menos 1 Mayuscula, 1 Numero y 8 a 15 Caracteres)");
    Console.ResetColor();
    Console.Write("Ingrese su Contraseña:");
    string pass0 = funcion.PassWord();

    Console.Write("Ingrese su fecha de nacimiento:");
    DateTime fecha0 = funcion.FechaNacimiento();

    Administrador adminprincipal = new Administrador(codigo0, usuario0, pass0, fecha0, asignatura[0]);
    usuario.AgregarUusarios(adminprincipal);
    adminprincipal.GuardarDatos(rutaUsuario);
}

bool menu = true;
do
{
    int opcionMenu, subMenu;
    string asignado = mostrar.MenuIngreso();
    if (asignado == asignatura[0])
    {
        do
        {
            mostrar.MenuAdmin();
            opcionMenu = funcion.ValidarMenu();
            switch (opcionMenu)
            {
                case 0:
                    Console.Write("Saliendo");
                    Thread.Sleep(200);
                    Console.Write(".");
                    Thread.Sleep(200);
                    Console.Write(".");
                    Thread.Sleep(200);
                    Console.Write(".");
                    break;

                case 1:
                    do
                    {
                        mostrar.MenuProductos();
                        subMenu = funcion.ValidarMenu();
                        Console.Clear();
                        switch (subMenu)
                        {
                            case 0:
                                funcion.MostrarRegresar();
                                break;

                            case 1:
                                Console.WriteLine("--- Producto ---");
                                break;
                            case 2:
                                Console.WriteLine("2. Ver todos los productos");
                                break;
                            case 3:
                                Console.WriteLine("3. Buscar Productos");
                                break;
                            case 4:
                                Console.WriteLine("4. Eliminar Productos");
                                break;
                            case 5:
                                Console.WriteLine("5. Suspender Producto");
                                break;
                            case 6:
                                Console.WriteLine("6. Modificar Producto");
                                break;

                            default:
                                funcion.OpcionNoValida();
                                break;
                        }
                    } while (subMenu != 0);
                    break;

                case 2:
                    mostrar.MenuUsuario();
                    subMenu = funcion.ValidarMenu();
                    Console.Clear();
                    switch (subMenu)
                    {
                        case 0:
                            funcion.MostrarRegresar();
                            break;

                        case 1:
                            Console.WriteLine("--- Trabajador ---");
                            usuario.AgregarUusarios(funcion.IngresoUsuarios(asignatura[1]));
                            break;

                        case 2:
                            Console.WriteLine("--- Administrador ---");
                            usuario.AgregarUusarios(funcion.IngresoUsuarios(asignatura[0]));
                            break;

                        case 3:
                            Console.WriteLine("--- Ver Usuarios ---");
                            Console.WriteLine("*** Administradores ***");
                            usuario.MostarDatosUsuario(asignatura[0]);
                            Console.WriteLine("*** Trabajadores ***");
                            usuario.MostarDatosUsuario(asignatura[1]);
                            break;

                        case 4:
                            Console.WriteLine("--- Buscar Usuario ---");
                            break;

                        default:
                            funcion.OpcionNoValida();
                            break;
                    }
                    break;

                case 3:
                    mostrar.MenuIngresosEgresos();
                    subMenu = funcion.ValidarMenu();
                    Console.Clear();
                    switch (subMenu)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;

                        default:
                            funcion.OpcionNoValida();
                            break;
                    }
                    break;

                case 4:
                    mostrar.MenuFotocopiadora();
                    subMenu = funcion.ValidarMenu();
                    Console.Clear();
                    switch (subMenu)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;

                        default:
                            funcion.OpcionNoValida();
                            break;
                    }
                    break;

                case 5:
                    mostrar.MenuComentarios();
                    subMenu = funcion.ValidarMenu();
                    Console.Clear();
                    switch (subMenu)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        case 2:
                            break;

                        default:
                            funcion.OpcionNoValida();
                            break;
                    }
                    break;

                case 6:
                    mostrar.MenuHerramientas();
                    subMenu = funcion.ValidarMenu();
                    Console.Clear();
                    switch (subMenu)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;

                        default:
                            funcion.OpcionNoValida();
                            break;
                    }
                    break;

                default:
                    funcion.OpcionNoValida();
                    break;
            }
        } while (opcionMenu != 0 && opcionMenu != 7);
    }
    else if (asignado == asignatura[1])
    {
        do
        {
            Console.Clear();
            mostrar.MenuTrabajador();
            opcionMenu = funcion.ValidarMenu();
            Console.Clear();
            switch (opcionMenu)
            {
                case 0:
                    Console.Write("Saliendo");
                    Thread.Sleep(200);
                    Console.Write(".");
                    Thread.Sleep(200);
                    Console.Write(".");
                    Thread.Sleep(200);
                    Console.Write(".");
                    break;

                case 1:
                    break;

                case 2:
                    mostrar.MenuAdministrarVentas();
                    break;

                case 3:
                    mostrar.MenuComentarios();
                    break;

                case 4:
                    break;

                case 5:
                    mostrar.MenuHerramientas();
                    break;

                default:
                    funcion.OpcionNoValida();
                    break;
            }
        } while (opcionMenu != 0 && opcionMenu != 7);
    }
    else
    {
        Console.WriteLine("Error!");
        opcionMenu = 1;
    }
    if (opcionMenu == 0)
        menu = false;
} while (menu);