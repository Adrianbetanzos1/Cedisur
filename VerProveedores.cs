﻿using CedisurB.Clases;
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
    public partial class VerProveedores : Form
    {

        private readonly SqlConnection conexion = new SqlConnection("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");

        public VerProveedores()
        {
            InitializeComponent();
        }


        //Método asociado para restringir el acceso a los usuarios a la hora de seleccionar acciones
        private void RestringirAccesos()
        {
            if (CacheInicioSesionUsuario.Nivel_seguridad == Cargos.usuario)
            {
                BtnEditarPro.Enabled = false;
                Button1.Enabled = false;
                BtnPagar.Enabled = false;

            }
        }

        //Método que carga los valores del DGV con sus header text establecidos
        private void VerProveedores_Load(object sender, EventArgs e)
        {
            RestringirAccesos();
            DGVproveedores.DataSource = Proveedor.MostrarProveedores();
            DGVproveedores.Columns[0].HeaderText = "ID proveedor";
            DGVproveedores.Columns[1].HeaderText = "RFC del proveedor";
            DGVproveedores.Columns[2].HeaderText = "Nombre del proveedor";
            DGVproveedores.Columns[3].HeaderText = "Fecha de registro";
            DGVproveedores.Columns[4].HeaderText = "Tipo";
            DGVproveedores.Columns[5].HeaderText = "Tipo de moneda de pago";
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Métodos para llevar los datos seleccionados para generar una factura a ese proveedor
        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (DGVproveedores.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else
            {
                var factura = new AgregarFacturas
                {
                    ParentForm = this
                };
                factura.TxtIDProveedor.Text = DGVproveedores.SelectedRows[0].Cells[0].Value.ToString();
                conexion.Open();
                string query = "select nombreProveedor " +
                    "from Proveedor " +
                    "where Proveedor.ID_proveedor='" + DGVproveedores.SelectedRows[0].Cells[0].Value.ToString() + "'";


                using (SqlCommand comando = new SqlCommand(query, conexion))
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


        //Método para eliminar los datos seleccionados.
        private void Button1_Click(object sender, EventArgs e)
        {
            if (DGVproveedores.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else if (MessageBox.Show("Estás seguro que deseas eliminar a este proveedor/Acreedor? Los datos y facturas afiliadas a este también se eliminarán", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                conexion.Open();
                string query = "delete from Proveedor where ID_proveedor = " + DGVproveedores.SelectedRows[0].Cells[0].Value.ToString();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor eliminado correctamente");
                conexion.Close();

                this.Close();
                VerProveedores ver = new VerProveedores();
                ver.Show();
            }

        }

        //Método para buscar según el RFC del proveedor
        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (TxtBusqueda.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un dato antes", "Advertencia");
            }
            else
            {
                DGVproveedores.DataSource = Proveedor.MostrarRFCProveedores(TxtBusquedaRfc.Text);
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
                var proveedores = new EditarProveedores
                {
                    ParentForm = this
                };
                proveedores.TxtIDProveedor.Text = DGVproveedores.SelectedRows[0].Cells[0].Value.ToString();
                proveedores.TxtRfc.Text = DGVproveedores.SelectedRows[0].Cells[1].Value.ToString();
                proveedores.TxtNombreProv.Text = DGVproveedores.SelectedRows[0].Cells[2].Value.ToString();
                proveedores.DTPFecha.Value = (DateTime)DGVproveedores.SelectedRows[0].Cells[3].Value;
                proveedores.CbTipo.SelectedValue = DGVproveedores.SelectedRows[0].Cells[4].Value.ToString();
                proveedores.CbMoneda.SelectedValue = DGVproveedores.SelectedRows[0].Cells[5].Value.ToString();

                this.Hide();
                proveedores.ShowDialog();
            }
        }

        
    }
}
