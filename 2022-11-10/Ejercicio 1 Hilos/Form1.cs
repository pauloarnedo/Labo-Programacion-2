namespace Ejercicio_1_Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Creo un delegado y le asigno el método AsignarHora
            Action ac = AsignarHora;
            
            //Creo un nuevo hilo (este hilo tiene un delegado, que a su vez lleva un método)
            Task t1 = new Task(ac);

            //Inicio ese hilo
            t1.Start();
        }

        public void AsignarHora()
        {
            while (true)
            {
                if (this.lblHora.InvokeRequired)
                {
                    /*this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblHora.Text = DateTime.UtcNow.ToString();
                    });*/

                    //Tengo que crear un delegado nuevo porque dentro de este hilo no puedo modificar el form
                    Action ac = new Action(() => { this.lblHora.Text = DateTime.UtcNow.ToString(); });
                    //BeginInvoke busca el hilo donde fue instanciado el form y mediante el delegado ejecuta la funcion especificada
                    this.lblHora.BeginInvoke(ac);
                }
                else
                {
                    this.lblHora.Text = DateTime.UtcNow.ToString();
                }
                Thread.Sleep(1000);
            }
        }
    }
}