using Cedisur.Clases;
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
    public partial class VerUsuarios : Form
    {
        private readonly SqlConnection conexion = new("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");
        public VerUsuarios()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new();
            menu.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        readonly Usuarios usuarios = new();

        //Método que carga los valores del DGV con sus header text establecidos
        private void VerUsuarios_Load(object sender, EventArgs e)
        {

            DGVusuarios.DataSource = Usuarios.MostrarUsuario();
            DGVusuarios.Columns[0].HeaderText = "ID usuario";
            DGVusuarios.Columns[1].HeaderText = "Nombre completo del usuario";
            DGVusuarios.Columns[2].HeaderText = "Nombre de usuario";
            DGVusuarios.Columns[3].HeaderText = "Contraseña";
            DGVusuarios.Columns[4].HeaderText = "Nivel de seguridad";
            DGVusuarios.Columns[5].HeaderText = "Email";

        }

        //Método para eliminar los datos seleccionados.
        private void Button1_Click(object sender, EventArgs e)
        {
            if (DGVusuarios.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else if (MessageBox.Show("Estás seguro que deseas eliminar a este usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                conexion.Open();
                string query = "delete from Usuarios where ID_usuario = " + DGVusuarios.SelectedRows[0].Cells[0].Value.ToString();
                SqlCommand comando = new(query, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado correctamente");
                conexion.Close();

                this.Close();
                VerUsuarios verUsuarios = new();
                verUsuarios.Show();

            }


        }

        //Método para mandar los datos seleccionados al formulario para editarlos.
        private void BtnEditarPro_Click(object sender, EventArgs e)
        {
            if (DGVusuarios.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else
            {
                var usuarios = new EditarUsuarios
                {
                    ParentForm = this
                };
                usuarios.TxtIDUsuario.Text = DGVusuarios.SelectedRows[0].Cells[0].Value.ToString();
                usuarios.TxtNombreCompleto.Text = DGVusuarios.SelectedRows[0].Cells[1].Value.ToString();
                usuarios.TxtNombre.Text = DGVusuarios.SelectedRows[0].Cells[2].Value.ToString();
                usuarios.TxtContraseña.Text = DGVusuarios.SelectedRows[0].Cells[3].Value.ToString();
                usuarios.CbTipoAutorizacion.SelectedValue = DGVusuarios.SelectedRows[0].Cells[4].Value.ToString();
                usuarios.TxtEmail.Text = DGVusuarios.SelectedRows[0].Cells[5].Value.ToString();

                this.Hide();
                usuarios.ShowDialog();
            }
        }

        //Método para buscar según el nombre del usuario

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBusqueda.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un dato antes", "Advertencia");
            }
            else
            {
                DGVusuarios.DataSource = usuarios.MostrarUsuariosNombre(TxtBusqueda.Text);
            }
        }

        
    }
}
