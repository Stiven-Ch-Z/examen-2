using examen_2.CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2.CapaLogica
{
    public static class Registro
    {
        private static List<UsuarioGimnasio> listaUsuarios = new List<UsuarioGimnasio>(); // aqui se crea la lista de los usuarios

        public static bool AgregarUsuario(string nombre, int edad, int numeroMembresia, string tipoMembresia)
        {
            UsuarioGimnasio usuario = new(nombre, edad, numeroMembresia, tipoMembresia);
            if (!listaUsuarios.Any(x => x.NumeroMembresia == usuario.NumeroMembresia)) // esta es la validacion que ve si se repite el numero de la membresia
            {
                listaUsuarios.Add(usuario);
                return true; // si no se repite se agrega
            }
            return false; // y si se repite marca falso
        }
        public static List<UsuarioGimnasio> IncorporarUsuarios()
        {
             return listaUsuarios; //actualiza la lista con los nuevos usuarios
        }

        public static int TotalUsuarios()
        {
            return listaUsuarios.Count; //cuenta la cantidad de objetos (usuarios) hay en la lista
        }
      
    }

}
