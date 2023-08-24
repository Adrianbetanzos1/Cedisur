using Cedisur.Clases;
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
            VerProveedores prov = new VerProveedores();
            prov.Show();
            this.Hide();
        }
        private void CustomizeDesign()
        {
            SubmenuPro.Visible = false;
            SubMenuFac.Visible = false;
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
            VerProveedores pro = new VerProveedores();
            pro.Show();
            this.Hide();
            HideSubmenu();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProveedor agregarProveedor = new AgregarProveedor();
            agregarProveedor.Show();
            this.Hide();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            AgregarFacturas pagos = new AgregarFacturas();
            pagos.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubMenuFac);
        }

        private void BtnTodosFac_Click(object sender, EventArgs e)
        {
            VerFacturas fac = new VerFacturas();
            fac.Show();
            this.Hide();
        }
    }
}
