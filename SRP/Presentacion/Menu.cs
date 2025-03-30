using SRP.Entidades;
using SRP.Logica;
using System;

namespace SRP.Presentacion
{
    // Esta clase tiene la responsabilidad de gestionar el menú de la aplicación
    public class Menu
    {
        private readonly ServicioValidar _servicioValidar;
        private readonly ServicioRepositorioUsuario _servicioRepositorio;
        private readonly ServicioEmail _servicioEmail;
        private readonly UsuarioConsola _consola;

        public Menu()
        {
            _servicioValidar = new ServicioValidarUsuario();
            _servicioRepositorio = new ServicioRepositorioUsuario();
            _servicioEmail = new ServicioEmail();
            _consola = new UsuarioConsola();
        }

        public void Mostrar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE USUARIOS (SRP) ===");
                Console.WriteLine("1. Registrar usuario");
                Console.WriteLine("2. Ver usuarios");
                Console.WriteLine("3. Enviar email de bienvenida");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarUsuario();
                        break;
                    case "2":
                        MostrarUsuarios();
                        break;
                    case "3":
                        EnviarEmailBienvenida();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        _consola.MostrarMensajeError("Opción no válida");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        private void RegistrarUsuario()
        {
            Console.WriteLine("\n=== REGISTRO DE USUARIO ===");

            Console.Write("ID: ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                _consola.MostrarMensajeError("ID no válido");
                return;
            }

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Contraseña: ");
            string contrasena = Console.ReadLine();

            var usuario = new Usuario(id, nombre, email, contrasena);

            if (_servicioValidar.EsValido(usuario))
            {
                _servicioRepositorio.Agregar(usuario);
                _consola.MostrarMensajeExito("Usuario registrado correctamente");
            }
            else
            {
                string[] errores = _servicioValidar.ObtenerErrores(usuario);
                foreach (string error in errores)
                {
                    _consola.MostrarMensajeError(error);
                }
            }
        }

        private void MostrarUsuarios()
        {
            Console.WriteLine("\n=== LISTA DE USUARIOS ===");
            var usuarios = _servicioRepositorio.ObtenerTodos();

            if (usuarios.Count == 0)
            {
                Console.WriteLine("No hay usuarios registrados");
                return;
            }

            foreach (var usuario in usuarios)
            {
                _consola.MostrarUsuario(usuario);
            }
        }

        private void EnviarEmailBienvenida()
        {
            Console.WriteLine("\n=== ENVIAR EMAIL DE BIENVENIDA ===");
            Console.Write("Ingrese el ID del usuario: ");

            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var usuario = _servicioRepositorio.ObtenerPorId(id);

                if (usuario != null)
                {
                    _servicioEmail.EnviarEmailBienvenida(usuario);
                    _consola.MostrarMensajeExito("Email enviado correctamente");
                }
                else
                {
                    _consola.MostrarMensajeError("Usuario no encontrado");
                }
            }
            else
            {
                _consola.MostrarMensajeError("ID no válido");
            }
        }
    }
}