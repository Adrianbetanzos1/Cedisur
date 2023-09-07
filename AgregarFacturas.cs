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
    public partial class AgregarFacturas : Form
    {
        public new Form ParentForm;
        public AgregarFacturas()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
                {
                    SqlCommand cmd = new SqlCommand("Insert into Factura(facturaN, fechaFactura, diasVencimiento, importeMXP,importeUSD, abono, saldoMXP, saldoUSD,ID_proveedor, TipoDeCambio, SaldoAnterior, SaldoAnteriorUSD,AbonoAnterior) values (@facturaN, @fechaFactura, @diasVencimiento, @importe,@importeUSD, @abono, @saldoMXP, @saldoUSD,@ID_proveedor,@TipoDeCambio, @saldoAnterior, @saldoAnteriorUSD, @abonoAnterior)")
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
        }

        //Botón para calcular el saldo restante de la factura
        private void TxtAbono_Leave_1(object sender, EventArgs e)
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
        private void AgregarFacturas_Load_1(object sender, EventArgs e)
        {
            List<int> generatedNumbers = new List<int>();
            Random random = new Random();
            int newNumber = random.Next(10000, 100000);

            if (!generatedNumbers.Contains(newNumber))
            {
                generatedNumbers.Add(newNumber);
                TxtNombreFactura.Text = "LCEDI" + newNumber.ToString();

            }
        }


        //Valida que sea un valor númerico el que se está poniendo
        private void TxtDiasVencimiento_Leave_1(object sender, EventArgs e)
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


        //Valida que sea un valor númerico el que se está poniendo
        private void TxtImporte_Leave_1(object sender, EventArgs e)
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
            else
            {
                TxtAbono.Focus();
            }

        }


        //Valida que sea un valor númerico el que se está poniendo
        private void TxtDolar_Leave_1(object sender, EventArgs e)
        {
            if (!float.TryParse(TxtDolar.Text, out float _))
            {
                MessageBox.Show("Ingrese un valor númerico");
                TxtDolar.Focus();
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        
    }
}
