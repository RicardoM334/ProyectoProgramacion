using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

            class Program
        {
            static void Main(string[] args)
            {
                // Crear una lista de usuarios registrados
                List<User> users = new List<User>();

                while (true)
                {
                    // Mostrar el menú de inicio de sesión o registro
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Iniciar sesión");
                    Console.WriteLine("2. Registrarse");
                    Console.Write("Opción: ");
                    string opcion = Console.ReadLine();
                    Console.Clear();

                    if (opcion == "1") // Si el usuario elige iniciar sesión
                    {
                        // Solicitar el nombre de usuario y la contraseña
                        Console.Write("Nombre de usuario: ");
                        string usuario = Console.ReadLine();
                        Console.Write("Contraseña: ");
                        string contraseña = Console.ReadLine();

                        // Buscar el usuario en la lista de usuarios registrados
                        User user = users.Find(u => u.Usuario == usuario && u.Contraseña == contraseña);

                        if (user != null) // Si el usuario existe
                        {
                            Console.Clear();
                            Console.WriteLine($"Bienvenido, {user.Nombre}!");
                            Console.ReadKey();

                            //Ingreso de sucursales


                            break;
                        }
                        else // Si el usuario no existe
                        {
                            Console.Clear();
                            Console.WriteLine("NOMBRE DE USUARIO O CONTRASEÑA INCORRECTOS");
                            Console.ReadKey();

                        }
                    }


                    else if (opcion == "2") // Si el usuario elige registrarse
                    {
                        // Solicitar los datos del usuario
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Nombre de usuario: ");
                        string usuario = Console.ReadLine();
                        Console.Write("Contraseña: ");
                        string contraseña = Console.ReadLine();
                        Console.Write("DUI: ");
                        string dui = Console.ReadLine();
                        Console.Write("Dirección: ");
                        string direccion = Console.ReadLine();
                        Console.Write("Correo electrónico: ");
                        string correoElectronico = Console.ReadLine();
                        Console.Write("Número de teléfono: ");
                        string numeroTelefono = Console.ReadLine();

                        // Crear un nuevo usuario con los datos ingresados
                        User user = new User(nombre, usuario, contraseña, dui, direccion, correoElectronico, numeroTelefono);
                        users.Add(user); // Agregar el usuario a la lista de usuarios registrados

                        Console.WriteLine("Usuario registrado correctamente.");
                    }
                    else // Si el usuario elige una opción inválida
                    {
                        Console.WriteLine("Opción inválida.");
                    }
                }
                Console.Clear();
            }
        }

        // Clase para representar a un usuario
        class User
        {
            public string Nombre { get; set; }
            public string Usuario { get; set; }
            public string Contraseña { get; set; }
            public string DUI { get; set; }
            public string Direccion { get; set; }
            public string CorreoElectronico { get; set; }
            public string NumeroTelefono { get; set; }

            public User(string nombre, string usuario, string contraseña, string dui, string direccion, string correoElectronico, string numeroTelefono)
            {
                Nombre = nombre;
                Usuario = usuario;
                Contraseña = contraseña;
                DUI = dui;
                Direccion = direccion;
                CorreoElectronico = correoElectronico;
                NumeroTelefono = numeroTelefono;
            }
        }

  
