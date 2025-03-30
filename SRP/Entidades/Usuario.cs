namespace SRP.Entidades
{
    // La clase Usuario solo tiene la responsabilidad de almacenar datos del usuario
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string nombre, string email, string contrasena)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            Contrasena = contrasena;
        }
    }
}