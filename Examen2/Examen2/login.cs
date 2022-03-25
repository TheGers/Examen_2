using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Windows.Forms;

namespace Examen2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Frm_usuarios frmusers = new Frm_usuarios();
            usuario usuariov2 = new usuario();


           usuariov2 = frmusers.login(usuario_textBox.Text, contra_textBox.Text);

            if (usuariov2 == null)
            {
                MessageBox.Show("Datos erroneos");
                return;
            }




        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
