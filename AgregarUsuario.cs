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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        // Verifica si una contraseña cumple con los requisitos mínimos


        static bool ContainsUpperCaseLetter(string input)
        {
            return input.Any(char.IsUpper);
        }

        static bool ContainsDigit(string input)
        {
            return input.Any(char.IsDigit);
        }

        static bool IsStrongPassword(string password)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Coloca una contraseña de 8 dígitos");
            }
            else if (!ContainsUpperCaseLetter(password))
            {
                MessageBox.Show("La contraseña debe de tener almenos una mayúscula");
            }
            else if (!ContainsDigit(password))
            {
                MessageBox.Show("La contraseña debe de tener almenos un dígito");
            }

            return password.Length >= 8 &&
                               password.Any(char.IsUpper) &&
                               password.Any(char.IsLower) &&
                               password.Any(char.IsDigit);

        }

        static bool DoPasswordsMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }


        private void LimpiarDatos()
        {
            TxtNombreCompleto.Clear();
            TxtNombre.Clear();
            TxtContraseña.Clear();
            TxtConfirmar.Clear();
            CbTipoAutorizacion.ClearSelected();
            TxtEmail.Clear();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!IsStrongPassword(TxtContraseña.Text))
            {
            }
            else if (!DoPasswordsMatch(TxtContraseña.Text, TxtConfirmar.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else if (string.IsNullOrEmpty(TxtNombreCompleto.Text) || string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrEmpty(TxtContraseña.Text) || string.IsNullOrEmpty(TxtConfirmar.Text) || CbTipoAutorizacion.CheckedItems.Count == 0 || string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("Colocar los datos faltantes antes de continuar");
            }
            else if (MessageBox.Show("Estas seguro que deseas agregar este nuevo usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
                {
                    SqlCommand cmd = new SqlCommand("Insert into Usuarios(NombreCompleto, NombreUsuario, Contraseña, Nivel_seguridad,Email) values (@nombreCompleto, @nombreUsuario, @Contraseña, @nivelSeguridad,@Email)")
                    {
                        CommandType = CommandType.Text,
                        Connection = conexion
                    };

                    cmd.Parameters.AddWithValue("@nombreCompleto", TxtNombreCompleto.Text);
                    cmd.Parameters.AddWithValue("@nombreUsuario", TxtNombre.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text);
                    cmd.Parameters.AddWithValue("@nivelSeguridad", CbTipoAutorizacion.SelectedItem);
                    cmd.Parameters.AddWithValue("@Email", TxtEmail.Text);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado correctamente");
                    conexion.Close();
                    LimpiarDatos();

                }
                    
            }
        }
    }
}
