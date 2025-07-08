namespace examen_2
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        private void btnhistorial_Click(object sender, EventArgs e)
        {
            historial historial = new historial();//aqui se crea el form historial
            this.Hide();// esto hace que se cierre el form menu 
            historial.ShowDialog(); //esto muestra el historial pero no permite que se muestre menu hasta que historial sea cerrado
            this.Show(); // cuando se cierra historial vuelve a aparecer el form menu 
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            agregar agregar = new agregar(); // lo mismo de arriba
            this.Hide();
            agregar.ShowDialog();
            this.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            //al hacer click le va a aparecer al usuario un messagebox con si y no, si se preciona SI el formulario menu va a cerrarse
        }
    }
}
