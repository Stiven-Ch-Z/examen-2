using examen_2.CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2.CapaLogica
{
    public static class Registro
    {
        private static List<UsuarioGimnasio> listaUsuarios = new List<UsuarioGimnasio>();

        public static bool AgregarUsuario(string nombre, int edad, double peso, double altura, string numeroMembresia, string tipoMembresia)
        {
            UsuarioGimnasio usuario = new(nombre, edad, peso, altura, numeroMembresia, tipoMembresia);
            if (!listaUsuarios.Any(x => x.NumeroMembresia == usuario.NumeroMembresia))
            {
                listaUsuarios.Add(usuario);
                return true;
            }
            return false;
        
        
        }
        public static List<UsuarioGimnasio> IncorporarUsuarios()
        {
             return listaUsuarios;
        
        }

        public static int TotalUsuarios()
        {
            return listaUsuarios.Count;
        }


















    }

}
