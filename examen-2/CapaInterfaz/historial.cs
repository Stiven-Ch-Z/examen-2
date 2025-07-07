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
            dataGridView1.AutoGenerateColumns = true; //aqui se crean las columnas automaticamente basandose en los objetos de la lista
            dataGridView1.DataSource = null; //esto limpia el datagrind 
            dataGridView1.DataSource = listaUsuarios; //y aqui se agrega la lista al datagrind

            lbltotal.Text = $"Total de Usuarios: {Registro.TotalUsuarios().ToString()}"; //aqui se actualiza el label para mostrar el total de usuarios que hay
        }
        

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
