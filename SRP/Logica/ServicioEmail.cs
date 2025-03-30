using SRP.Entidades;
using System;

namespace SRP.Logica
{
    // Esta clase tiene la única responsabilidad de enviar emails
    public class ServicioEmail
    {
        public void EnviarEmailBienvenida(Usuario usuario)
        {
            // En un caso real, aquí se enviaría un email
            Console.WriteLine($"Email de bienvenida enviado a {usuario.Email}");
        }

        public void EnviarEmailRecuperacionContrasena(Usuario usuario)
        {
            // En un caso real, aquí se enviaría un email
            Console.WriteLine($"Email de recuperación de contraseña enviado a {usuario.Email}");
        }
    }
}