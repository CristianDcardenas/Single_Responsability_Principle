using System;

namespace SRP.Logica
{
    // Clase abstracta para servicios de validación
    public abstract class ServicioValidar
    {
        // Método abstracto que debe implementar cada validador
        public abstract bool EsValido(object entidad);

        // Método abstracto para obtener mensajes de error
        public abstract string[] ObtenerErrores(object entidad);

        // Método normal (no abstracto) que pueden usar todos los validadores
        public void MostrarErrores(object entidad)
        {
            string[] errores = ObtenerErrores(entidad);

            if (errores.Length == 0)
            {
                Console.WriteLine("No hay errores de validación.");
            }
            else
            {
                Console.WriteLine("Errores de validación:");
                foreach (string error in errores)
                {
                    Console.WriteLine($"- {error}");
                }
            }
        }
    }
}