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
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string NumeroMembresia { get; set; }
        public string TipoMembresia { get; set; }
        public DateTime FechaHoraIngreso { get; set; }

        //constructor que llama la clase Persona
        public UsuarioGimnasio(string nombre, int edad, double peso, double altura, string numeroMembresia, string tipoMembresia, DateTime fechaHoraIngreso)
            : base(nombre, edad) // hace llamado el constructor de persona
        {
            Peso = peso;
            Altura = altura;
            NumeroMembresia = numeroMembresia;
            TipoMembresia = tipoMembresia;
            FechaHoraIngreso = fechaHoraIngreso;
        }
        public UsuarioGimnasio(string nombre, int edad, double peso, double altura, string numeroMembresia, string tipoMembresia)
            : base(nombre, edad) // hace un segundo llamado el constructor de persona
        {
            Peso = peso;
            Altura = altura;
            NumeroMembresia = numeroMembresia;
            TipoMembresia = tipoMembresia;

        }

        public string MostrarInformacion()
        {
            return $"Nombre: {Nombre}\nEdad {Edad}\nPeso {Peso} Kg \nAltura {Altura}\nNumeroMembresia {NumeroMembresia}\nTipoMembresia {TipoMembresia}\nFechaHoraIngreso{FechaHoraIngreso}";
        }
    }
}
