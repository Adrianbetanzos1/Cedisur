using Cedisur.Clases;
using Common.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cedisur
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cerrar sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                InicioSesion form = new();
                form.Show();
                this.Hide();
            }


        }

        private void Label2_Click(object sender, EventArgs e)
        {
            VerFacturas prov = new();
            prov.Show();
            this.Hide();
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

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuPro);
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            VerProveedores pro = new();
            pro.Show();
            this.Hide();
            HideSubmenu();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            AgregarProveedor agregarProveedor = new();
            agregarProveedor.Show();
            this.Hide();


        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            AgregarPagos pagos = new();
            pagos.Show();
            this.Hide();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubMenuFac);
        }

        private void BtnTodosFac_Click(object sender, EventArgs e)
        {
            VerFacturas facturas = new();
            facturas.Show();
            this.Hide();
        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuPagos);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            VerPagos pagos = new();
            pagos.Show();
            this.Hide();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuUsuarios);
        }

        private void BtnAgregarNuevoU_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregar = new();
            agregar.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            VerUsuarios usuarios = new();
            usuarios.Show();
            this.Hide();
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
    }
}
