namespace examen_2
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            agregar agregar = new agregar();
            this.Hide();
            agregar.ShowDialog();
            this.Show();
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            historial historial = new historial();
            this.Hide();
            historial.ShowDialog();
            this.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
