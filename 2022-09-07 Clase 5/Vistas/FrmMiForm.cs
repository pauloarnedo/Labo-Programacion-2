namespace Vistas
{
    public partial class FrmMiForm : Form
    {
        public FrmMiForm()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.txtNombre.Text;

            MessageBox.Show($"Hola {nombre}", "BIENVENIDO", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void FrmMiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.txtNombre.Text;

            FrmSaludar frmSaludar = new FrmSaludar(nombre);
            frmSaludar.Show();
        }
    }
}