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
            cbotipomembre.DropDownStyle = ComboBoxStyle.DropDownList; // esto hace que solo se puedan elegir las opciones del combobox
        }


        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close(); //esto cierra el form actual y vuelve al form del menu
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (Validarcampos()) // si se cumple con validar campos
            {
                string nombre = txtnombre.Text;
                int edad = int.Parse(txtedad.Text);   
                int numeroMembresia = int.Parse(txtmembre.Text);
                string tipoMembresia = "";
                // los atributos de la clase Usuario asignan los datos que se encuentran en los txt
                switch (cbotipomembre.SelectedIndex)
                {
                    case 0:  // aqui dependiendo lo que selecciono el usuario le va a salir un mensaje con la mensualidad seleccionada
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

                bool agregado = Registro.AgregarUsuario(nombre, edad, numeroMembresia, tipoMembresia); //aqui se llama al metodo de agregarusuario para intentar agregar un nuevo usuario
                if (agregado) //si no se repite el numero de membresia con uno ya existen
                {
                    MessageBox.Show($"Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // manda un messagebox diciendo que se agrego el usuario correctamente y cierra el formulario de agregar
                }
                else
                {
                    MessageBox.Show("El número de membresía ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvideragregar.SetError(txtmembre, "Este número ya existe.");
                    // y si se repite manda este message box y marca el txtmembre para que el usuario cambie el numero
                }
                
            }
        }

        private bool Validarcampos()
        {
            errorProvideragregar.Clear(); //aqui se limpian las x (errores) anteriores
            bool esvalido = true; // esto se utiliza para saber si los txt de los datos estan validos o no 

            if (string.IsNullOrEmpty(txtnombre.Text)) // esto valida si el txtnombre esta vacio o no
            {
                MessageBox.Show("Por favor agregue un nombre valido!", "Algo inesperado a ocurrido...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvideragregar.SetError(txtnombre, "agrega un nombre aqui!");
                esvalido = false; //si lo esta, manda el messagebox y marca el bool como invalido y no permite que se guarde el dato
            }
            if (!int.TryParse(txtedad.Text, out int edad) || edad > 90 || edad < 10) // aqui lo mismo, pero ademas verifica si es un numero y si ese numero es mayor a 90 o menor a 10
            {
                MessageBox.Show("Por favor agregue una edad valida!", "Algo inesperado a ocurrido...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvideragregar.SetError(txtedad, "cambie la edad aqui!");
                esvalido = false; // si lo es, lo ya mencionado antes
            }
            if (!int.TryParse(txtmembre.Text, out int numeroMembresia)) //aqui lo mismo que la edad
            {
                MessageBox.Show("Por favor agregue un número para la membresia!", "Algo inesperado a ocurrido...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvideragregar.SetError(txtmembre, "Ingrese un número de membresía válido.");
                esvalido = false;
            }

            if (cbotipomembre.SelectedIndex == -1) // si el comobobox esta vacio 
            {
                MessageBox.Show("Por Favor agregue una opcion de mensualidad", "Algo inesperado a ocurrido...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvideragregar.SetError(cbotipomembre, "Elija el tipo de membresia aqui!");
                esvalido = false; 
            }
            return esvalido; //si todo se cumple devuelve esvalido en true osea que se guardan los datos
        }

        private void cambiarElColorDelFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog()) 
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDialog.Color;
                }
            }//esto es pa cambiar el color del fondo del form agregar
        }

        private void mostrarTotalDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int total = examen_2.CapaLogica.Registro.TotalUsuarios(); 
            MessageBox.Show($"Total de ingresos: {total}", "Cantidad de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //esto es para ver el total de usuarios registrados
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); //y esto es pa salir del programa desde la opcion del contestmenustrip
            }
        }
    }
}
