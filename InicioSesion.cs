using Common.Cache;
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


        private void Buttona1_Click(object sender, EventArgs e)
        {
            if (userTxt.Text != "NombreUsuario")
            {
                if (passTxt.Text != "Contraseña")
                {
                    UserModel usuario = new();
                    var validLogin = usuario.LoginUser(userTxt.Text, passTxt.Text);
                    if (validLogin == true)
                    {

                        Menu menu = new();
                        MessageBox.Show("Bienvenido " + CacheInicioSesionUsuario.NombreCompleto);

                        menu.Show();
                        menu.FormClosed += CerrarSesion;
                        this.Hide();


                    }
                    else
                    {
                        MsgError("Usuario/Contraseña incorrectos");
                        userTxt.Clear();
                        passTxt.Clear();
                        userTxt.Focus();
                    }
                }
                else MsgError("Coloque su contraseña");

            }
            else MsgError("Coloque su nombre de usuario");

        }

        private void MsgError(string error)
        {
            LblError.Text = "  " + error;
            LblError.Visible = true;
        }


        private void CerrarSesion(object? sender, FormClosedEventArgs e)
        {
            userTxt.Clear();
            passTxt.Clear();
            LblError.Visible = false;
            this.Show();
            userTxt.Focus();

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}