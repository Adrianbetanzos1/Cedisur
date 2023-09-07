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
    public partial class EditarFacturas : Form
    {
        private readonly SqlConnection conexion = new SqlConnection("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");
        readonly VerFacturas factura = new VerFacturas();

        public new Form ParentForm;
        public EditarFacturas()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            factura.Show();
        }

        //Método para modificar los datos de la factura
        private void Modificar()
        {

            conexion.Open();
            string selectedDate = DTPFecha.Value.ToString("yyyy-MM-dd");
            string query = "update Cedisur.dbo.Factura set facturaN='" + TxtNombreFactura.Text + "', " +
                "fechaFactura=CAST('" + selectedDate + "' as datetime), diasVencimiento='" + TxtDiasVencimiento.Text + "'," +
                "importeMXP='" + float.Parse(TxtImporte.Text).ToString("F2") + "', importeUSD='" + float.Parse(TxtImporteUSD.Text).ToString("F2") + "', abono='" + float.Parse(TxtAbono.Text).ToString("F2") + "'," +
                "saldoMXP='" + float.Parse(TxtSaldoMXP.Text).ToString("F2") + "', saldoUSD='" + float.Parse(TxtSaldoUSD.Text).ToString("F2") + "', SaldoAnterior= '" + float.Parse(TxtSaldoMXP.Text).ToString("F2") + "', " +
                "SaldoAnteriorUSD= '" + float.Parse(TxtSaldoUSD.Text).ToString("F2") + "', AbonoAnterior= '" + float.Parse(TxtAbono.Text).ToString("F2") + "' where  ID_factura= '" + TxtIdFactura.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
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

        private void button1_Click(object sender, EventArgs e)
        {
            float dolar = float.Parse(TxtDolar.Text);
            float saldoMXP = float.Parse(TxtSaldoMXP.Text);
            float saldoUSD = saldoMXP / dolar;
            float importeMXP = float.Parse(TxtImporte.Text);
            float importeUSD = importeMXP / dolar;

            if (string.IsNullOrEmpty(TxtDolar.Text) || string.IsNullOrEmpty(TxtSaldoMXP.Text) || string.IsNullOrEmpty(TxtImporte.Text))
            {

                label21.Text = "Por favor coloque un número donde debe antes de darle click";
            }
            else
            {

                TxtSaldoUSD.Text = saldoUSD.ToString();
                TxtImporteUSD.Text = importeUSD.ToString();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtAbono_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAbono.Text))
            {
                TxtAbono.Text = "0";
                TxtSaldoUSD.Text = TxtImporteUSD.Text;
                TxtSaldoMXP.Text = TxtImporte.Text;
            }
            else if (!float.TryParse(TxtAbono.Text, out float _))
            {

                MessageBox.Show("Ingrese un valor númerico");
                TxtAbono.Focus();

            }
            else if (float.Parse(TxtAbono.Text) > float.Parse(TxtImporte.Text))
            {
                MessageBox.Show("No puede proseguir debido a que el abono es mayor al importe", "Advertencia");
            }
            else
            {
                float saldo = +float.Parse(TxtImporte.Text) - float.Parse(TxtAbono.Text);
                TxtSaldoMXP.Text = saldo.ToString();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombreFactura.Text) || string.IsNullOrEmpty(TxtAbono.Text) || string.IsNullOrEmpty(TxtDiasVencimiento.Text) || string.IsNullOrEmpty(TxtImporte.Text) || TxtDolar.Text == "")
            {
                MessageBox.Show("Colocar los datos faltantes antes de continuar");
            }
            else if (float.Parse(TxtAbono.Text) > float.Parse(TxtImporte.Text))
            {
                MessageBox.Show("No puede proseguir debido a que el abono es mayor al importe", "Advertencia");

            }
            else if (MessageBox.Show("Estas seguro que deseas editar los datos de esta factura?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Modificar();
                this.Close();
                factura.Show();
            }
        }

        private void TxtDiasVencimiento_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(TxtDiasVencimiento.Text, out float _))
            {
                MessageBox.Show("Ingrese un valor númerico");
                TxtDiasVencimiento.Focus();
            }
            else
            {
                TxtImporte.Focus();
            }
        }

        private void TxtDolar_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(TxtDolar.Text, out float _))
            {
                MessageBox.Show("Ingrese un valor númerico");
                TxtDolar.Focus();
            }
        }

        private void TxtImporte_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtImporte.Text))
            {
                MessageBox.Show("Por favor coloque el importe", "AVISO");
            }
            else if (!float.TryParse(TxtImporte.Text, out float _))
            {
                MessageBox.Show("Ingrese un valor númerico");
                TxtImporte.Focus();
            }
            else
            {
                TxtSaldoMXP.Focus();
            }
        }
    }
}
