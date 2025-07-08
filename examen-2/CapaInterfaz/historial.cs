using System;
using examen_2.CapaLogica;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using examen_2.CapaDatos;

namespace examen_2
{
    public partial class historial : Form
    {
        public historial()
        {
            InitializeComponent();
        }

        private void historial_Load(object sender, EventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
        
            List<UsuarioGimnasio> listaUsuarios = Registro.IncorporarUsuarios();  //aqui se llama el metodo de incorporarusuarios
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // se Definen las columnas manualmente (incluye Calificación)
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Edad", "Edad");
            dataGridView1.Columns.Add("NumeroMembresia", "Número de Membresía");
            dataGridView1.Columns.Add("TipoMembresia", "Tipo de Membresía");
            dataGridView1.Columns.Add("FechaHoraIngreso", "Fecha y Hora de Ingreso");
            dataGridView1.Columns.Add("Calificacion", "Calificación por Edad");

            // y se Usa foreach para agregar los datos al DataGridView
            foreach (UsuarioGimnasio usuario in listaUsuarios)
            {
                dataGridView1.Rows.Add(
                    usuario.Nombre,
                    usuario.Edad,
                    usuario.NumeroMembresia,
                    usuario.TipoMembresia,
                    usuario.FechaHoraIngreso.ToString("g"), 
                    usuario.Calificacion 
                );
            }

            // Mostrar total de usuarios con el label
            lbltotal.Text = $"Total de Usuarios: {Registro.TotalUsuarios()}";
        }




        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
