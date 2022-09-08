namespace Vistas
{
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string materia;

            nombre = this.txtNombre.Text;
            apellido = this.txtApellido.Text;
            materia = this.cboMaterias.Text;

            bool nombreIsNull = String.IsNullOrWhiteSpace(nombre);
            bool apellidoIsNull = String.IsNullOrWhiteSpace(apellido);
            if (!nombreIsNull && !apellidoIsNull)
            {
                FrmSaludo frmSaludar = new FrmSaludo(nombre, apellido, materia);
                frmSaludar.Show();
            }
            else
            {
                string nomApe = "";
                if (nombreIsNull)
                {
                    nomApe += "\nNombre";
                }
                if (apellidoIsNull)
                {
                    nomApe += "\nApellido";
                }
                MessageBox.Show($"Se deben completar los siguientes campos:{nomApe}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}