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
            agregar nuevaventana = new agregar();
            nuevaventana.ShowDialog();
        }
    }
}
