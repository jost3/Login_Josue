using Microsoft.VisualBasic.ApplicationServices;

namespace login_J
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            String Nombre, Contraseña;
            Nombre = textBox1.Text;
            Contraseña = textPassword.Text;

        }
    }
}