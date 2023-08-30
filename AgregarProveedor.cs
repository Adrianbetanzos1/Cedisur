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
    public partial class AgregarProveedor : Form
    {
        public AgregarProveedor()
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

        private void LimpiarDatos()
        {
            TxtRfc.Clear();
            TxtIDProveedor.Clear();
            TxtNombreProv.Clear();
            DTPFecha.Value = DateTime.Now;
            CbTipo.ClearSelected();
            CbMoneda.ClearSelected();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIDProveedor.Text) || string.IsNullOrEmpty(TxtNombreProv.Text) || string.IsNullOrEmpty(TxtRfc.Text) || CbTipo.CheckedItems.Count == 0 || CbMoneda.CheckedItems.Count == 0)
            {
                MessageBox.Show("Colocar los datos faltantes antes de continuar");
            }
            else if (MessageBox.Show("Estas seguro que deseas agregar este nuevo proveedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using SqlConnection conexion = new("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
                SqlCommand cmd = new("Insert into Proveedor(RfcProveedor, nombreProveedor, fechaDeRegistro, TipoDeProveedor, TipoDePago) values (@RfcProveedor, @nombreProveedor, @fechaDeRegistro, @TipoDeProveedor, @TipoDePago)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexion;

                cmd.Parameters.AddWithValue("@RfcProveedor", TxtRfc.Text);
                cmd.Parameters.AddWithValue("@nombreProveedor", TxtNombreProv.Text);
                cmd.Parameters.AddWithValue("@fechaDeRegistro", DTPFecha.Value);
                cmd.Parameters.AddWithValue("@TipoDeProveedor", CbTipo.SelectedItem);
                cmd.Parameters.AddWithValue("@TipoDePago", CbMoneda.SelectedItem);

                conexion.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado correctamente");
                conexion.Close();
                LimpiarDatos();
            }

        }

        private void AgregarProveedor_Load(object sender, EventArgs e)
        {
            TxtIDProveedor.Focus();
        }


    }
}
