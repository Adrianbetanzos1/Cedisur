using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CedisurB.Reportes
{
    public partial class ReportesFacturas : Form
    {
        public ReportesFacturas()
        {
            InitializeComponent();
        }

        private void ReportesFacturas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSistema.DT_MostrarFacturasActualizada' table. You can move, or remove it, as needed.
            this.dT_MostrarFacturasActualizadaTableAdapter.Fill(this.dsSistema.DT_MostrarFacturasActualizada);

            this.reportViewer1.RefreshReport();
        }
    }
}
