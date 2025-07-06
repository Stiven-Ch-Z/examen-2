using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2.CapaDatos
{

    using System;

    public class UsuarioGimnasio : examen_2.CapaDatos.Persona
    {
        public int NumeroMembresia { get; set; }
        public string TipoMembresia { get; set; }
        public DateTime FechaHoraIngreso { get; set; }

        public string Calificacion
        {
            get 
            {
                if (Edad < 18) return "Adolescente";
                else if (Edad < 60) return "Adulto";
                else return "Adulto Mayor";
            }
        
        }

        //constructor

        public UsuarioGimnasio(string nombre, int edad, int numeroMembresia, string tipoMembresia)
        {
            Nombre=nombre;
            Edad=edad;
            NumeroMembresia = numeroMembresia;
            TipoMembresia = tipoMembresia;
            FechaHoraIngreso = DateTime.Now;
        }

        public string MostrarInformacion()
        {
            return $"Nombre: {Nombre}\nEdad {Edad}\nNumeroMembresia {NumeroMembresia}\nTipoMembresia {TipoMembresia}\nFechaHoraIngreso{FechaHoraIngreso}";
        }
    }
}
