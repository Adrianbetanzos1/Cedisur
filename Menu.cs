using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CedisurB
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomizeDesign()
        {
            SubmenuPro.Visible = false;
            SubMenuFac.Visible = false;
            SubmenuPagos.Visible = false;
            SubmenuUsuarios.Visible = false;
        }

        private void HideSubmenu()
        {
            if (SubmenuPro.Visible == true || SubMenuFac.Visible == true)
            {
                SubmenuPro.Visible = false;

            }
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;

            }
            else
                submenu.Visible = false;
        }

        private void Load_User()
        {
            LblNombre.Text = CacheInicioSesionUsuario.NombreCompleto;
            LblPosicion.Text = CacheInicioSesionUsuario.Nivel_seguridad;
        }

        private void RestringirAccesos()
        {
            if (CacheInicioSesionUsuario.Nivel_seguridad == Cargos.usuario)
            {
                BtnAgregar.Enabled = false;

                BtnUsuarios.Enabled = false;

            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Load_User();
            RestringirAccesos();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cerrar sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                InicioSesion form = new InicioSesion();
                form.Show();
                this.Hide();
            }
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuPro);
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubMenuFac);
        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuPagos);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuUsuarios);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProveedor agregarProveedor = new AgregarProveedor();
            agregarProveedor.Show();
            this.Hide();
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            VerProveedores pro = new VerProveedores();
            pro.Show();
            this.Hide();
            HideSubmenu();
        }

        private void BtnTodosFac_Click(object sender, EventArgs e)
        {
            VerFacturas facturas = new VerFacturas();
            facturas.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerPagos pagos = new VerPagos();
            pagos.Show();
            this.Hide();
        }

        private void BtnAgregarNuevoU_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregar = new AgregarUsuario();
            agregar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerUsuarios usuarios = new VerUsuarios();
            usuarios.Show();
            this.Hide();
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            Load_User();
            RestringirAccesos();
            
        }
    }
}
