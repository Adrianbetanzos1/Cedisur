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
    public partial class EditarProveedor : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");
        VerProveedores prov = new();
        public new Form ParentForm;
        public EditarProveedor()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            prov.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Modificar()
        {

            conexion.Open();
            string selectedDate = DTPFecha.Value.ToString("yyyy-MM-dd");
            string query = "update Cedisur.dbo.Proveedor set nombreProveedor='" + TxtNombreProv.Text + "', fechaDeRegistro=CAST('" + selectedDate + "' as datetime) where  ID_proveedor= '" + TxtIDProveedor.Text + "'";
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas modificar los datos este proveedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Modificar();
                this.Close();
                prov.Show();
            }
        }
    }
}
