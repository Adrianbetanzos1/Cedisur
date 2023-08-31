using MySql.Data.MySqlClient;
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
    public partial class EditarFacturas : Form
    {
        private readonly SqlConnection conexion = new("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");
        readonly VerFacturas factura = new();
        
        public new Form? ParentForm;
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
                "importeMXP='" + TxtImporte.Text + "', importeUSD='" + TxtImporteUSD.Text + "', abono='" + TxtAbono.Text + "'," +
                "saldoMXP='" + TxtSaldoMXP.Text + "', saldoUSD='" + TxtSaldoUSD.Text + "', SaldoAnterior= '" + TxtSaldoMXP.Text + "', " +
                "SaldoAnteriorUSD= '" + TxtSaldoUSD.Text + "', AbonoAnterior= '" + TxtAbono.Text + "' where  ID_factura= '" + TxtIdFactura.Text + "'";
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Botón para calcular el valor del importe, saldo en USD
        private void Button1_Click(object sender, EventArgs e)
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

        //Método para asignar el saldo pendiente de acuerdo al abono y el importe
        private void TxtAbono_Leave(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(TxtImporte.Text))
            {
                MessageBox.Show("Por favor coloque el importe", "AVISO");
            }
            else if (string.IsNullOrEmpty(TxtAbono.Text))
            {
                TxtAbono.Text = "0";
                TxtSaldoUSD.Text = TxtImporteUSD.Text;
                TxtSaldoMXP.Text = TxtImporte.Text;
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

        //Botón para modificar los datos de la factura que se seleccionó
        private void BtnModificar_Click(object sender, EventArgs e)
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

    }
}
