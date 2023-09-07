using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CedisurB
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void MsgError(string error)
        {
            LblError.Text = "  " + error;
            LblError.Visible = true;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
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

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            userTxt.Clear();
            passTxt.Clear();
            LblError.Visible = false;
            this.Show();
            userTxt.Focus();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
