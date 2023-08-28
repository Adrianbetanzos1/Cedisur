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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cedisur
{
    public partial class VerProveedores : Form
    {

        private readonly SqlConnection conexion = new("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");

        public VerProveedores()
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

        readonly Proveedor prov = new();
        private void VerProveedores_Load(object sender, EventArgs e)
        {
            DGVproveedores.DataSource = prov.MostrarProveedores();
            DGVproveedores.Columns[0].HeaderText = "ID proveedor";
            DGVproveedores.Columns[1].HeaderText = "Nombre del proveedor";
            DGVproveedores.Columns[2].HeaderText = "Fecha de registro";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBusqueda.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un dato antes", "Advertencia");
            }
            else
            {
                DGVproveedores.DataSource = Proveedor.MostrarNombreProveedores(TxtBusqueda.Text);
            }
        }

        private void BtnEditarPro_Click(object sender, EventArgs e)
        {
            if (DGVproveedores.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else
            {
                var proveedores = new EditarProveedor();
                proveedores.ParentForm = this;
                proveedores.TxtIDProveedor.Text = DGVproveedores.SelectedRows[0].Cells[0].Value.ToString();
                proveedores.TxtNombreProv.Text = DGVproveedores.SelectedRows[0].Cells[1].Value.ToString();
                proveedores.DTPFecha.Value = (DateTime)DGVproveedores.SelectedRows[0].Cells[2].Value;

                this.Hide();
                proveedores.ShowDialog();
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (DGVproveedores.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else
            {
                var factura = new AgregarFacturas();
                factura.ParentForm = this;
                factura.TxtIDProveedor.Text = DGVproveedores.SelectedRows[0].Cells[0].Value.ToString();
                conexion.Open();
                string query = "select nombreProveedor " +
                    "from Proveedor " +
                    "where Proveedor.ID_proveedor='" + DGVproveedores.SelectedRows[0].Cells[0].Value.ToString() + "'";


                using (SqlCommand comando = new(query, conexion))
                {

                    object result = comando.ExecuteScalar();

                    if (result != null)
                    {
                        factura.TxtNombrePro.Text = result.ToString();
                    }



                }
                conexion.Close();
                this.Hide();
                factura.ShowDialog();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro que deseas eliminar a este proveedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                conexion.Open();
                string query = "delete from Proveedor where ID_proveedor = " + DGVproveedores.SelectedRows[0].Cells[0].Value.ToString();
                SqlCommand comando = new(query, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor eliminado correctamente");
                conexion.Close();
            }
        }
    }
}
