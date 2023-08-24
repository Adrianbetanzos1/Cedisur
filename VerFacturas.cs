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

namespace Cedisur
{
    public partial class VerFacturas : Form
    {
        public VerFacturas()
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

        readonly FacturasT fac = new FacturasT();
        private void Facturas_Load(object sender, EventArgs e)
        {
            DGVFacturas.DataSource = fac.MostrarFacturas();
            DGVFacturas.Columns[0].HeaderText = "ID factura";
            DGVFacturas.Columns[1].HeaderText = "Número factura";
            DGVFacturas.Columns[2].HeaderText = "Importe MXP";
            DGVFacturas.Columns[3].HeaderText = "Importe USD";
            DGVFacturas.Columns[4].HeaderText = "Fecha de pago";
            DGVFacturas.Columns[5].HeaderText = "SPEI";
            DGVFacturas.Columns[6].HeaderText = "Número de cuenta";
            DGVFacturas.Columns[7].HeaderText = "Número de contrato";
            DGVFacturas.Columns[8].HeaderText = "ID proveedor";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBusqueda.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un dato antes", "Advertencia");
            }
            else
            {
                DGVFacturas.DataSource = FacturasT.MostrarFactura(TxtBusqueda.Text);
            }
        }
    }
}
