namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //AsignarHora();
        }

        public void AsignarHora()
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                lblHora.Text = now.ToString();
                Thread.Sleep(1000);
            }
        }
    }
}