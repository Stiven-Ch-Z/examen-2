using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2.CapaDatos
{

    using System;

    public class UsuarioGimnasio : examen_2.CapaDatos.Persona //aqui se llama la clase persona para poder realizar el contructor mas abajo
    {
        public int NumeroMembresia { get; set; } //propiedad de numero de la membresia
        public string TipoMembresia { get; set; } //la del tipo de membresia
        public DateTime FechaHoraIngreso { get; set; } // aqui se hace la propiedad de fecha pero se realiza automaticamente con datatime 

        public string Calificacion // la de calificacion que usa la propiedad de edad para calificar la categoria de la edad
        {
            get 
            {
                if (Edad < 18) return "Adolescente"; // si la edad es menor a 18 es adolescente
                else if (Edad < 60) return "Adulto"; // si es menor a 60 es adulto
                else return "Adulto Mayor"; // y si es mayor a 60 es un adulto mayor
            }
        
        }

        public UsuarioGimnasio(string nombre, int edad, int numeroMembresia, string tipoMembresia)
        {
            Nombre=nombre;
            Edad=edad;
            NumeroMembresia = numeroMembresia;
            TipoMembresia = tipoMembresia;
            FechaHoraIngreso = DateTime.Now;
        } //constructor

        public string MostrarInformacion()
        {
            return $"Nombre: {Nombre}\nEdad {Edad}\nNumeroMembresia {NumeroMembresia}\nTipoMembresia {TipoMembresia}\nFechaHoraIngreso{FechaHoraIngreso}";
        }
    }
}
