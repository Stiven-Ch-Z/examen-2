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
        
            List<UsuarioGimnasio> listaUsuarios = Registro.IncorporarUsuarios(); // Asegúrate de tener este método en tu clase Registro

            dataGridView1.AutoGenerateColumns = true; // Auto-generar columnas según las propiedades de Usuario
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaUsuarios;

            lbltotal.Text = $"Total de Usuarios: {Registro.TotalUsuarios().ToString()}";
        }
        

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
