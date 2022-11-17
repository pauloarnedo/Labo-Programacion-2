using Entidades;

namespace Ejercicio_1
{
    public partial class FrmAvisador : Form
    {
        public FrmAvisador()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(persona is null)
            {
                //conviene poner en el constructor
                persona = new Persona();
                
                
                //As� asocio una funci�n al evento vvv
                persona.EventoString += NotificarCambio;


                btnCrear.Text = "Actualizar";
            }
            persona.Nombre = this.txtNombre.Text;
            persona.Apellido = this.txtApellido.Text;

            this.lblNombreCompleto.Text = persona.Mostrar();
        }

        private Persona persona;
         
        public static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

    }
}