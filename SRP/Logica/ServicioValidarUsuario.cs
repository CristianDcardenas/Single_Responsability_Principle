using SRP.Entidades;
using System.Collections.Generic;

namespace SRP.Logica
{
    // Clase concreta que hereda de ServicioValidar
    public class ServicioValidarUsuario : ServicioValidar
    {
        // Implementación del método abstracto EsValido
        public override bool EsValido(object entidad)
        {
            // Convertimos el objeto a Usuario
            Usuario usuario = entidad as Usuario;

            // Si no es un Usuario, no es válido
            if (usuario == null)
                return false;

            // Validamos los datos del usuario
            return !string.IsNullOrEmpty(usuario.Nombre) &&
                   EsEmailValido(usuario.Email) &&
                   EsContrasenaValida(usuario.Contrasena);
        }

        // Implementación del método abstracto ObtenerErrores
        public override string[] ObtenerErrores(object entidad)
        {
            List<string> errores = new List<string>();

            // Convertimos el objeto a Usuario
            Usuario usuario = entidad as Usuario;

            // Si no es un Usuario, devolvemos un error
            if (usuario == null)
            {
                errores.Add("La entidad no es un usuario válido");
                return errores.ToArray();
            }

            // Validamos cada campo
            if (string.IsNullOrEmpty(usuario.Nombre))
            {
                errores.Add("El nombre no puede estar vacío");
            }

            if (!EsEmailValido(usuario.Email))
            {
                errores.Add("El email no es válido (debe contener '@' y '.')");
            }

            if (!EsContrasenaValida(usuario.Contrasena))
            {
                errores.Add("La contraseña debe tener al menos 8 caracteres");
            }

            return errores.ToArray();
        }

        // Métodos auxiliares específicos para validar usuarios
        private bool EsEmailValido(string email)
        {
            return !string.IsNullOrEmpty(email) &&
                   email.Contains("@") &&
                   email.Contains(".");
        }

        private bool EsContrasenaValida(string contrasena)
        {
            return !string.IsNullOrEmpty(contrasena) &&
                   contrasena.Length >= 8;
        }
    }
}