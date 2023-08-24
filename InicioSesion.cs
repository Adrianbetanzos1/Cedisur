using System.DirectoryServices;
using System.Runtime.InteropServices.ObjectiveC;

namespace Cedisur
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }


        private void buttona1_Click(object sender, EventArgs e)
        {
            if (userTxt.Text != "NombreUsuario")
            {
                if (passTxt.Text != "Contraseña")
                {
                    UserModel usuario = new UserModel();
                    var validLogin = usuario.LoginUser(userTxt.Text, passTxt.Text);
                    if (validLogin == true)
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        menu.FormClosed += cerrarSesion;
                        this.Hide();
                        

                    }
                    else
                    {
                        msgError("Usuario/Contraseña incorrectos");
                        userTxt.Clear();
                        passTxt.Clear();
                        userTxt.Focus();
                    }
                }
                else msgError("Coloque su contraseña");

            }
            else msgError("Coloque su nombre de usuario");

        }

        private void msgError(string error)
        {
            LblError.Text = "  " + error;
            LblError.Visible = true;
        }


        private void cerrarSesion(object sender, FormClosedEventArgs e)
        {
            userTxt.Clear();
            passTxt.Clear();
            LblError.Visible = false;
            this.Show();
            userTxt.Focus();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}