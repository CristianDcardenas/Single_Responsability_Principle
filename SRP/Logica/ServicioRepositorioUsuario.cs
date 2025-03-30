using SRP.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SRP.Logica
{
    // Esta clase tiene la única responsabilidad de gestionar el almacenamiento de usuarios
    public class ServicioRepositorioUsuario
    {
        private List<Usuario> _usuarios = new List<Usuario>();

        public void Agregar(Usuario usuario)
        {
            // En un caso real, aquí se guardaría en una base de datos
            _usuarios.Add(usuario);
            Console.WriteLine($"Usuario {usuario.Nombre} guardado en la base de datos.");
        }

        public Usuario ObtenerPorId(int id)
        {
            return _usuarios.FirstOrDefault(u => u.Id == id);
        }

        public List<Usuario> ObtenerTodos()
        {
            return _usuarios;
        }

        public void Actualizar(Usuario usuario)
        {
            var index = _usuarios.FindIndex(u => u.Id == usuario.Id);
            if (index != -1)
            {
                _usuarios[index] = usuario;
                Console.WriteLine($"Usuario {usuario.Nombre} actualizado en la base de datos.");
            }
        }

        public void Eliminar(int id)
        {
            var usuario = ObtenerPorId(id);
            if (usuario != null)
            {
                _usuarios.Remove(usuario);
                Console.WriteLine($"Usuario {usuario.Nombre} eliminado de la base de datos.");
            }
        }
    }
}