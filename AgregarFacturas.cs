using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cedisur
{

    public partial class AgregarFacturas : Form
    {

        public new Form? ParentForm;
        public AgregarFacturas() => InitializeComponent();
        //Botón para regresar al menú anterior
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new();
            menu.Show();
            this.Close();
        }



        //Boton para convertir de pesos a dolares
        private void Button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(TxtDolar.Text) || string.IsNullOrEmpty(TxtSaldoMXP.Text) || string.IsNullOrEmpty(TxtImporte.Text))
            {

                label21.Text = "Por favor coloque un número donde debe antes de darle click";
            }
            else
            {
                float dolar = float.Parse(TxtDolar.Text);
                float saldoMXP = float.Parse(TxtSaldoMXP.Text);
                float saldoUSD = saldoMXP / dolar;
                float importeMXP = float.Parse(TxtImporte.Text);
                float importeUSD = importeMXP / dolar;

                TxtSaldoUSD.Text = saldoUSD.ToString();
                TxtImporteUSD.Text = importeUSD.ToString();

            }

        }


        private void LimpiarDatos()
        {

            TxtIDProveedor.Clear();
            TxtNombreFactura.Clear();
            DTPFecha.Value = DateTime.Now;
            TxtDiasVencimiento.Clear();
            TxtImporte.Clear();
            TxtImporteUSD.Clear();
            TxtAbono.Clear();
            TxtSaldoMXP.Clear();
            TxtSaldoUSD.Clear();
            TxtDolar.Clear();
            TxtNombrePro.Clear();

        }

        //Método para agregar los datos de las facturas conectada a la base de datos
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtNombreFactura.Text) || string.IsNullOrEmpty(TxtAbono.Text) || string.IsNullOrEmpty(TxtDiasVencimiento.Text) || string.IsNullOrEmpty(TxtImporte.Text) || string.IsNullOrEmpty(TxtImporteUSD.Text) || string.IsNullOrEmpty(TxtSaldoUSD.Text) || TxtDolar.Text == "")
            {
                MessageBox.Show("Colocar los datos faltantes antes de continuar");
            }
            else if (float.Parse(TxtAbono.Text) > float.Parse(TxtImporte.Text))
            {
                MessageBox.Show("No puede proseguir debido a que el abono es mayor al importe", "Advertencia");

            }
            else if (MessageBox.Show("Estas seguro que deseas agregar esta factura? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using SqlConnection conexion = new("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
                SqlCommand cmd = new("Insert into Factura(facturaN, fechaFactura, diasVencimiento, importeMXP,importeUSD, abono, saldoMXP, saldoUSD,ID_proveedor, TipoDeCambio, SaldoAnterior, SaldoAnteriorUSD,AbonoAnterior) values (@facturaN, @fechaFactura, @diasVencimiento, @importe,@importeUSD, @abono, @saldoMXP, @saldoUSD,@ID_proveedor,@TipoDeCambio, @saldoAnterior, @saldoAnteriorUSD, @abonoAnterior)")
                {
                    CommandType = CommandType.Text,
                    Connection = conexion
                };

                cmd.Parameters.AddWithValue("@facturaN", TxtNombreFactura.Text);
                cmd.Parameters.AddWithValue("@fechaFactura", DTPFecha.Value);
                cmd.Parameters.AddWithValue("@diasVencimiento", TxtDiasVencimiento.Text);
                cmd.Parameters.AddWithValue("@importe", float.Parse(TxtImporte.Text).ToString("F2"));
                cmd.Parameters.AddWithValue("@importeUSD", float.Parse(TxtImporteUSD.Text).ToString("F2"));
                cmd.Parameters.AddWithValue("@abono", float.Parse(TxtAbono.Text).ToString("F2"));
                cmd.Parameters.AddWithValue("@saldoMXP", float.Parse(TxtSaldoMXP.Text).ToString("F2"));
                cmd.Parameters.AddWithValue("@saldoUSD", float.Parse(TxtSaldoUSD.Text).ToString("F2"));
                cmd.Parameters.AddWithValue("@ID_proveedor", TxtIDProveedor.Text);
                cmd.Parameters.AddWithValue("@TipoDeCambio", TxtDolar.Text);
                cmd.Parameters.AddWithValue("@saldoAnterior", float.Parse(TxtSaldoMXP.Text).ToString("F2"));
                cmd.Parameters.AddWithValue("@saldoAnteriorUSD", float.Parse(TxtSaldoUSD.Text).ToString("F2"));
                cmd.Parameters.AddWithValue("@abonoAnterior", float.Parse(TxtAbono.Text).ToString("F2"));

                conexion.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado correctamente");
                conexion.Close();
                LimpiarDatos();
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Botón para calcular el saldo restante de la factura
        private void TxtAbono_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(TxtAbono.Text, out float _))
            {
                MessageBox.Show("Ingrese un valor númerico");
                TxtAbono.Focus();
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
                float saldo = float.Parse(TxtImporte.Text) - float.Parse(TxtAbono.Text);
                TxtSaldoMXP.Text = saldo.ToString();
            }

        }


        //Al iniciar el formulario, se genera el número de factura
        private void AgregarFacturas_Load(object sender, EventArgs e)
        {
            List<int> generatedNumbers = new();
            Random random = new();
            int newNumber = random.Next(10000, 100000);

            if (!generatedNumbers.Contains(newNumber))
            {
                generatedNumbers.Add(newNumber);
                TxtNombreFactura.Text = "LCEDI" + newNumber.ToString();

            }
        }

        //Valida que sea un valor númerico el que se está poniendo
        private void TxtDiasVencimiento_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(TxtDiasVencimiento.Text, out float _))
            {
                MessageBox.Show("Ingrese un valor númerico");
                TxtDiasVencimiento.Focus();
            }
        }

        //Valida que sea un valor númerico el que se está poniendo
        private void TxtImporte_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtImporte.Text))
            {
                MessageBox.Show("Por favor coloque el importe", "Aviso");

            }
            else if (!float.TryParse(TxtImporte.Text, out float _))
            {
                MessageBox.Show("Ingrese un valor númerico");
                TxtImporte.Focus();
            }

        }

        //Valida que sea un valor númerico el que se está poniendo
        private void TxtDolar_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(TxtDolar.Text, out float _))
            {
                MessageBox.Show("Ingrese un valor númerico");
                TxtDolar.Focus();
            }
        }
    }
}
