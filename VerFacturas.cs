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
    public partial class VerFacturas : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");

        public VerFacturas()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }







        readonly Facturas facturas = new();

        //Al momento de cargar el formulario se cargar el DGV con los nombres preestablecidos
        private void Proveedores_Load(object sender, EventArgs e)
        {
            DGVfacturas.DataSource = facturas.MostrarFactura();
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

        //Método para búsqueda por medio del nombre de la factura 
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

        //Método para búsqueda por medio del ID de la factura
        private void BtnBuscarID_Click(object sender, EventArgs e)
        {
            if (TxtBuscarID.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un dato antes", "Advertencia");
            }
            else
            {
                DGVfacturas.DataSource = Facturas.MostrarID(TxtBuscarID.Text);
            }
        }


        int LastIdPlusOne
        {
            get
            {
                int id = 0;
                if (DGVfacturas.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in DGVfacturas.Rows)
                    {
                        var _id = int.Parse(row.Cells[0].Value.ToString());
                        if (_id > id)
                        {
                            id = _id;
                        }
                    }
                }
                return id + 1;
            }
        }


        //Método para editar los datos en otro formulario, llevandose los datos
        private void BtnEditar_Click(object sender, EventArgs e)
        {

            

            if (DGVfacturas.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else
            {
                var facturas = new EditarFacturas();
                facturas.ParentForm = this;

                

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




        //Método para llevar ciertos datos seleccionados al formulario de agregar pago
        private void BtnPagar_Click(object sender, EventArgs e)
        {

            if (DGVfacturas.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else if (MessageBox.Show("Está seguro que desea generar un pago a la factura seleccionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var pago = new AgregarPagos();
                pago.ParentForm = this;
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
                            pago.txtABono.Text = reader["abono"].ToString();
                        }
                    }


                }

                conexion.Close();
                this.Hide();
                pago.ShowDialog();
            }
                
            
        }
    }



}
