﻿using CedisurB.Clases;
using Microsoft.Reporting.WinForms;
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
    public partial class VerFacturas : Form
    {
        
        private readonly SqlConnection conexion = new SqlConnection("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");

        public VerFacturas()
        {
            InitializeComponent();
        }

        private void RestringirAccesos()
        {
            if (CacheInicioSesionUsuario.Nivel_seguridad == Cargos.usuario)
            {
                BtnEditar.Enabled = false;

            }
        }


      
       
            private void VerFacturas_Load(object sender, EventArgs e)
        {
            RestringirAccesos();
            DGVfacturas.DataSource = Facturas.MostrarFactura();
            DGVfacturas.Columns[0].HeaderText = "ID factura";
            DGVfacturas.Columns[1].HeaderText = "Nombre factura";
            DGVfacturas.Columns[2].HeaderText = "Fecha facturación";
            DGVfacturas.Columns[3].HeaderText = "Días vencimiento";
            DGVfacturas.Columns[4].HeaderText = "Importe MXP";
            DGVfacturas.Columns[5].HeaderText = "Importe USD";
            DGVfacturas.Columns[6].HeaderText = "Abono";
            DGVfacturas.Columns[7].HeaderText = "Saldo MXP";
            DGVfacturas.Columns[8].HeaderText = "Saldo USD";
            DGVfacturas.Columns[9].HeaderText = "ID proveedor";
            DGVfacturas.Columns[10].HeaderText = "Tipo de cambio del día facturado";

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBusqueda.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un dato antes", "Advertencia");
            }
            else
            {
                DGVfacturas.DataSource = Facturas.Mostrar(TxtBusqueda.Text);
            }
        }

        private void BtnBuscarID_Click(object sender, EventArgs e)
        {
            if (TxtBuscarID.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un dato antes", "Advertencia");
            }
            else
            {
                DGVfacturas.DataSource = Facturas.MostrarIDProveedor(TxtBuscarID.Text);
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (DGVfacturas.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else if (MessageBox.Show("Está seguro que desea generar un pago a la factura seleccionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var pago = new AgregarPagos
                {
                    ParentForm = this
                };
                pago.TxtIdFactura.Text = DGVfacturas.SelectedRows[0].Cells[0].Value.ToString();
                pago.txtSaldoPendiente.Text = DGVfacturas.SelectedRows[0].Cells[7].Value.ToString();
                pago.txtSaldoUSD.Text = DGVfacturas.SelectedRows[0].Cells[8].Value.ToString();

                conexion.Open();
                string query = "select proveedor.ID_proveedor, Factura.FacturaN, Proveedor.nombreProveedor, Factura.abono " +
                    "from Factura " +
                    "inner join Proveedor on Factura.ID_proveedor = Proveedor.ID_proveedor " +
                    "where ID_factura ='" + DGVfacturas.SelectedRows[0].Cells[0].Value.ToString() + "'";



                using (SqlCommand comando = new SqlCommand(query, conexion))
                {

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pago.TxtNombrePro.Text = reader["nombreProveedor"].ToString();
                            pago.TxtNombreFactura.Text = reader["FacturaN"].ToString();
                            pago.TxtID.Text = reader["ID_proveedor"].ToString();
                            pago.TxtAbono.Text = reader["abono"].ToString();
                        }
                    }
                        


                }

                conexion.Close();
                this.Hide();
                pago.ShowDialog();
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DGVfacturas.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else
            {
                var facturas = new EditarFacturas
                {
                    ParentForm = this
                };

                facturas.TxtIdFactura.Text = DGVfacturas.SelectedRows[0].Cells[0].Value.ToString();
                facturas.TxtNombreFactura.Text = DGVfacturas.SelectedRows[0].Cells[1].Value.ToString();
                facturas.DTPFecha.Value = (DateTime)DGVfacturas.SelectedRows[0].Cells[2].Value;
                facturas.TxtDiasVencimiento.Text = DGVfacturas.SelectedRows[0].Cells[3].Value.ToString();
                facturas.TxtImporte.Text = DGVfacturas.SelectedRows[0].Cells[4].Value.ToString();
                facturas.TxtImporteUSD.Text = DGVfacturas.SelectedRows[0].Cells[5].Value.ToString();
                facturas.TxtAbono.Text = DGVfacturas.SelectedRows[0].Cells[6].Value.ToString();
                facturas.TxtSaldoMXP.Text = DGVfacturas.SelectedRows[0].Cells[7].Value.ToString();
                facturas.TxtSaldoUSD.Text = DGVfacturas.SelectedRows[0].Cells[8].Value.ToString();
                facturas.TxtIDPro.Text = DGVfacturas.SelectedRows[0].Cells[9].Value.ToString();
                facturas.TxtDolar.Text = DGVfacturas.SelectedRows[0].Cells[10].Value.ToString();

                this.Hide();
                facturas.ShowDialog();
            }
        }

        


        
        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.ReportesFacturas reporte =  new Reportes.ReportesFacturas();
            reporte.ShowDialog();
        }
        
    }
}
