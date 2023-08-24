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
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");

        public VerProveedores()
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

       

        



        readonly Proveedor prov = new();
        private void Proveedores_Load(object sender, EventArgs e)
        {
            DGVproveedores.DataSource = prov.MostrarProveedores();
            DGVproveedores.Columns[0].HeaderText = "ID proveedor";
            DGVproveedores.Columns[1].HeaderText = "Nombre proveedor";

            DGVproveedores.Columns[2].HeaderText = "Fecha Adquisición";
            DGVproveedores.Columns[3].HeaderText = "Días vencimiento";
            DGVproveedores.Columns[4].HeaderText = "Importe";
            DGVproveedores.Columns[5].HeaderText = "Abono";
            DGVproveedores.Columns[6].HeaderText = "Saldo MXP";
            DGVproveedores.Columns[7].HeaderText = "Saldo USD";
            DGVproveedores.Columns[8].HeaderText = "Saldo pendiente";
            DGVproveedores.Columns[9].HeaderText = "Provisiones Aportadas";
            

        }
       

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBusqueda.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un dato antes", "Advertencia");
            }
            else
            {
                DGVproveedores.DataSource = Proveedor.Mostrar(TxtBusqueda.Text);
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
                DGVproveedores.DataSource = Proveedor.MostrarID(TxtBuscarID.Text);
            }
        }


        int LastIdPlusOne
        {
            get
            {
                int id = 0;
                if (DGVproveedores.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in DGVproveedores.Rows)
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


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var prov = new EditarProv();
            prov.ParentForm = this;
            prov.TxtId.Text = DGVproveedores.SelectedRows[0].Cells[0].Value.ToString();
            prov.TxtNombrePro.Text = DGVproveedores.SelectedRows[0].Cells[1].Value.ToString();
            prov.DTPFecha.Value = (DateTime)DGVproveedores.SelectedRows[0].Cells[2].Value;
            prov.TxtDiasVencimiento.Text = DGVproveedores.SelectedRows[0].Cells[3].Value.ToString();
            prov.TxtImporte.Text = DGVproveedores.SelectedRows[0].Cells[4].Value.ToString();
            prov.TxtAbono.Text = DGVproveedores.SelectedRows[0].Cells[5].Value.ToString();
            prov.TxtSaldoMXP.Text = DGVproveedores.SelectedRows[0].Cells[6].Value.ToString();
            prov.TxtSaldoUSD.Text = DGVproveedores.SelectedRows[0].Cells[7].Value.ToString();
            prov.TxtSaldoPendiente.Text = DGVproveedores.SelectedRows[0].Cells[8].Value.ToString();
            prov.TxtProvTotal.Text = DGVproveedores.SelectedRows[0].Cells[9].Value.ToString();
            this.Hide();
            prov.ShowDialog();
            
        }





        private void BtnPagar_Click(object sender, EventArgs e)
        {

            var pago = new AgregarFacturas();
            pago.ParentForm = this;
            pago.TxtID.Text = DGVproveedores.SelectedRows[0].Cells[0].Value.ToString();

            conexion.Open();
            string query = "select nombreProveedor, saldoPendiente " +
                "from Proveedores " +
                "where Proveedores.ID_proveedor='" + DGVproveedores.SelectedRows[0].Cells[0].Value.ToString() + "'";

            using (SqlCommand comando = new SqlCommand(query, conexion))
            {

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pago.TxtNombrePro.Text = reader["nombreProveedor"].ToString();

                        pago.txtSaldoPendiente.Text = reader["saldoPendiente"].ToString();
                    }
                }


            }
            conexion.Close();
            this.Hide();
            pago.ShowDialog();
            
        }
    }



}
