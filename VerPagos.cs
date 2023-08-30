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
    public partial class VerPagos : Form
    {

        private SqlConnection conexion = new SqlConnection("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");

        public VerPagos()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        readonly Pagos pago = new Pagos();
        private void Facturas_Load(object sender, EventArgs e)
        {
            DGVpagos.DataSource = pago.MostrarFacturas();
            DGVpagos.Columns[0].HeaderText = "ID pago";
            DGVpagos.Columns[1].HeaderText = "Número factura";
            DGVpagos.Columns[2].HeaderText = "Importe MXP";
            DGVpagos.Columns[3].HeaderText = "Importe USD";
            DGVpagos.Columns[4].HeaderText = "Fecha de pago";
            DGVpagos.Columns[5].HeaderText = "SPEI";
            DGVpagos.Columns[6].HeaderText = "Número de cuenta";
            DGVpagos.Columns[7].HeaderText = "Número de contrato";
            DGVpagos.Columns[8].HeaderText = "ID proveedor";
            DGVpagos.Columns[9].HeaderText = "ID factura";
            DGVpagos.Columns[10].HeaderText = "Tipo de cambio el día del pago";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBusqueda.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un dato antes", "Advertencia");
            }
            else
            {
                DGVpagos.DataSource = Pagos.MostrarPago(TxtBusqueda.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (DGVpagos.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else
            {
                var pagos = new EditarPagos();
                conexion.Open();
                string query = "select ID_pago, nombreProveedor, SaldoAnterior, SaldoAnteriorUSD, AbonoAnterior " +
                    "from Pagos inner join Factura " +
                    "on Factura.ID_factura = Pagos.ID_factura " +
                    "inner join Proveedor " +
                    "on Proveedor.ID_proveedor = Pagos.ID_proveedor " +
                    "where Pagos.ID_pago ='" + DGVpagos.SelectedRows[0].Cells[0].Value.ToString() + "'";



                using (SqlCommand comando = new SqlCommand(query, conexion))
                {

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            pagos.TxtNombrePro.Text = reader["nombreProveedor"].ToString();
                            pagos.txtSaldoPendiente.Text = reader["SaldoAnterior"].ToString();
                            pagos.txtSaldoUSD.Text = reader["SaldoAnteriorUSD"].ToString();
                            pagos.txtAbono.Text = reader["AbonoAnterior"].ToString();



                        }
                    }


                }
                conexion.Close();

                
                pagos.ParentForm = this;
                pagos.TxtIdPago.Text = DGVpagos.SelectedRows[0].Cells[0].Value.ToString();
                pagos.TxtNombreFactura.Text = DGVpagos.SelectedRows[0].Cells[1].Value.ToString();
                pagos.TxtImporteMXP.Text = DGVpagos.SelectedRows[0].Cells[2].Value.ToString();
                pagos.TxtImporteUSD.Text = DGVpagos.SelectedRows[0].Cells[3].Value.ToString();
                pagos.DTPFechaPago.Value = (DateTime)DGVpagos.SelectedRows[0].Cells[4].Value;
                pagos.CbSPEI.SelectedValue = DGVpagos.SelectedRows[0].Cells[5].Value.ToString();
                pagos.TxtNumeroCuenta.Text = DGVpagos.SelectedRows[0].Cells[6].Value.ToString();
                pagos.TxtNumContrato.Text = DGVpagos.SelectedRows[0].Cells[7].Value.ToString();
                pagos.TxtID.Text = DGVpagos.SelectedRows[0].Cells[8].Value.ToString();
                pagos.TxtIdFactura.Text = DGVpagos.SelectedRows[0].Cells[9].Value.ToString();
                pagos.TxtDolar.Text = DGVpagos.SelectedRows[0].Cells[10].Value.ToString();

                this.Hide();
                pagos.ShowDialog();
            }
            
        }
    }
}
