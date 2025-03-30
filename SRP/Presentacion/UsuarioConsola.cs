using SRP.Entidades;
using System;

namespace SRP.Presentacion
{
    // Esta clase tiene la única responsabilidad de mostrar información del usuario en la consola
    public class UsuarioConsola
    {
        public void MostrarUsuario(Usuario usuario)
        {
            Console.WriteLine("=== Información del Usuario ===");
            Console.WriteLine($"ID: {usuario.Id}");
            Console.WriteLine($"Nombre: {usuario.Nombre}");
            Console.WriteLine($"Email: {usuario.Email}");
            Console.WriteLine("=============================");
        }

        public void MostrarMensajeError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR: {mensaje}");
            Console.ResetColor();
        }

        public void MostrarMensajeExito(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"ÉXITO: {mensaje}");
            Console.ResetColor();
        }
    }
}