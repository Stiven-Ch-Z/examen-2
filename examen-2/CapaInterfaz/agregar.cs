using examen_2.CapaDatos;
using examen_2.CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace examen_2
{

    public partial class agregar : Form
    {

        public agregar()
        {
            InitializeComponent();
        }
        private void agregar_Load(object sender, EventArgs e)
        {
            cbotipomembre.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (Validarcampos())
            {
                string nombre = txtnombre.Text;
                int edad = int.Parse(txtedad.Text);
                int numeroMembresia = int.Parse(txtmembre.Text);
                string tipoMembresia = "";

                switch (cbotipomembre.SelectedIndex)
                {
                    case 0:
                        tipoMembresia = "Anual";
                        MessageBox.Show("Haz seleccionado la Membresia Anual", "Membresia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        tipoMembresia = "Mensual";
                        MessageBox.Show("Haz seleccionado la Membresia Mensual", "Membresia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        tipoMembresia = "Trimestral";
                        MessageBox.Show("Haz seleccionado la Membresia Trimestral", "Membresia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                }

                bool agregado = Registro.AgregarUsuario(nombre, edad, numeroMembresia, tipoMembresia);
                if (agregado)
                {
                    MessageBox.Show($"Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El número de membresía ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvideragregar.SetError(txtmembre, "Este número ya existe.");
                }
                
            }
        }

        private bool Validarcampos()
        {
            errorProvideragregar.Clear();
            bool esvalido = true;

            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Por favor agregue un nombre valido!", "Algo inesperado a ocurrido...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvideragregar.SetError(txtnombre, "agrega un nombre aqui!");
                esvalido = false;
            }
            if (!int.TryParse(txtedad.Text, out int edad) || edad > 90 || edad < 10)
            {
                MessageBox.Show("Por favor agregue una edad valida!", "Algo inesperado a ocurrido...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvideragregar.SetError(txtedad, "cambie la edad aqui!");
                esvalido = false;
            }
            if (!int.TryParse(txtmembre.Text, out int numeroMembresia))
            {
                MessageBox.Show("Por favor agregue un número para la membresia!", "Algo inesperado a ocurrido...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvideragregar.SetError(txtmembre, "Ingrese un número de membresía válido.");
                esvalido = false;
            }
            else if (Registro.IncorporarUsuarios().Any(u => u.NumeroMembresia == numeroMembresia))
            {
                MessageBox.Show("Este número de membresía ya está registrado.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvideragregar.SetError(txtmembre, "Número ya registrado.");
                esvalido = false;
            }

            if (cbotipomembre.SelectedIndex == -1)
            {
                MessageBox.Show("Por Favor agregue una opcion de mensualidad", "Algo inesperado a ocurrido...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvideragregar.SetError(cbotipomembre, "Elija el tipo de membresia aqui!");
                esvalido = false;
            }
            return esvalido;
        }

        private void cambiarElColorDelFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDialog.Color;
                }
            }
        }

        private void mostrarTotalDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int total = examen_2.CapaLogica.Registro.TotalUsuarios();
            MessageBox.Show($"Total de ingresos: {total}", "Cantidad de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
