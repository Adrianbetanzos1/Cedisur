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
        private readonly SqlConnection conexion = new("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");

        //Definimos este formulario como hijo del ver proveedores
        readonly VerProveedores prov = new();
        public new Form? ParentForm;
        public EditarProveedor()
        => InitializeComponent();

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            prov.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Método para modificar los datos del proveedor, utilizando una consulta para modificarla directamente a la base de datos
        private void Modificar()
        {

            conexion.Open();
            string selectedDate = DTPFecha.Value.ToString("yyyy-MM-dd");
            string query = "update Cedisur.dbo.Proveedor " +
                "set RfcProveedor= '"+ TxtRfc.Text+"', nombreProveedor='" + TxtNombreProv.Text + "', fechaDeRegistro=CAST('" + selectedDate + "' as datetime)," +
                " TipoDeProveedor='"+CbTipo.SelectedItem+"', TipoDePago= '"+CbMoneda.SelectedItem+"' where  ID_proveedor= '" + TxtIDProveedor.Text + "'";
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


        //Botón para modificar los datos del proveedor
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIDProveedor.Text) || string.IsNullOrEmpty(TxtNombreProv.Text) || string.IsNullOrEmpty(TxtRfc.Text)|| CbTipo.CheckedItems.Count == 0 || CbMoneda.CheckedItems.Count == 0)
            {
                MessageBox.Show("Colocar los datos faltantes antes de continuar");
            }
            else if (MessageBox.Show("¿Estas seguro que deseas modificar los datos este proveedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Modificar();
                this.Close();
                prov.Show();
            }
        }
    }
}
