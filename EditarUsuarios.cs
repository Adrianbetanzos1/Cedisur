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

namespace Cedisur
{
    public partial class EditarUsuarios : Form
    {

        private readonly SqlConnection conexion = new("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");

        //Definimos este formulario como hijo del ver usuarios
        readonly VerUsuarios usuarios = new();
        public new Form? ParentForm;
        public EditarUsuarios()
        => InitializeComponent();

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            usuarios.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Modificar()
        {

            conexion.Open();

            string query = "update Cedisur.dbo.Usuarios " +
                "set NombreCompleto= '" + TxtNombreCompleto.Text + "', NombreUsuario='" + TxtNombre.Text + "'" +
                " ,Contraseña='" + TxtContraseña.Text + "', Nivel_seguridad= '" + CbTipoAutorizacion.SelectedItem + "', Email= '" + TxtEmail.Text + "' where  ID_usuario= '" + TxtIDUsuario.Text + "'";
            SqlCommand comando = new(query, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            if (cant == 1)
            {
                MessageBox.Show("Registro modificado correctamente");
            }
            else
            {
                MessageBox.Show("Registro no modificado correctamente");
            }
            conexion.Close();


        }


        //Requisitos contraseña
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


        //Requisitos contraseña


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
            else if (MessageBox.Show("¿Estas seguro que deseas modificar los datos este usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Modificar();
                this.Close();
                usuarios.Show();
            }
        }
    }
}
