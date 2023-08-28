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

        public new Form ParentForm;
        public AgregarFacturas()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            float dolar;
            float saldoMXP;
            float saldoUSD;

            if (string.IsNullOrEmpty(TxtDolar.Text))
            {

                label21.Text = "Por favor coloque un número donde debe antes de darle click";
            }
            else if (string.IsNullOrEmpty(TxtSaldoMXP.Text))
            {
                label21.Text = "Coloque el dato del saldo aportado";
            }
            else
            {

                dolar = float.Parse(TxtDolar.Text);

                saldoMXP = float.Parse(TxtSaldoMXP.Text);

                saldoUSD = saldoMXP / dolar;


                TxtSaldoUSD.Text = saldoUSD.ToString();


            }

        }


        private void LimpiarDatos()
        {

            TxtIDProveedor.Clear();
            TxtNombreFactura.Clear();
            DTPFecha.Value = DateTime.Now;
            TxtDiasVencimiento.Clear();

            TxtImporte.Clear();
            TxtAbono.Clear();
            TxtSaldoMXP.Clear();
            TxtSaldoUSD.Clear();
           

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas agregar esta factura?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
                {
                    SqlCommand cmd = new SqlCommand("Insert into Factura(facturaN, fechaFactura, diasVencimiento, importe, abono, saldoMXP, saldoUSD,ID_proveedor) values (@facturaN, @fechaFactura, @diasVencimiento, @importe, @abono, @saldoMXP, @saldoUSD,@ID_proveedor)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conexion;

                    cmd.Parameters.AddWithValue("@facturaN", TxtNombreFactura.Text);
                    cmd.Parameters.AddWithValue("@fechaFactura", DTPFecha.Value);
                    cmd.Parameters.AddWithValue("@diasVencimiento", TxtDiasVencimiento.Text);
                    cmd.Parameters.AddWithValue("@importe", TxtImporte.Text);
                    cmd.Parameters.AddWithValue("@abono", TxtAbono.Text);
                    cmd.Parameters.AddWithValue("@saldoMXP", TxtSaldoMXP.Text);
                    cmd.Parameters.AddWithValue("@saldoUSD", TxtSaldoUSD.Text);

                    cmd.Parameters.AddWithValue("@ID_proveedor", TxtIDProveedor.Text);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado correctamente");
                    conexion.Close();
                    LimpiarDatos();

                }
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtAbono_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtImporte.Text))
            {
                MessageBox.Show("Por favor coloque el importe", "AVISO");
            }
            float abono = float.Parse(TxtAbono.Text);
            float importe = float.Parse(TxtImporte.Text);
            float saldo;

            saldo = +importe - abono;

            TxtSaldoMXP.Text = saldo.ToString();
        }

        private void AgregarFacturas_Load(object sender, EventArgs e)
        {
            List<int> generatedNumbers = new List<int>();
            Random random = new();
            int newNumber = random.Next(10000, 100000);

            if (!generatedNumbers.Contains(newNumber))
            {
                generatedNumbers.Add(newNumber);
                TxtNombreFactura.Text = "LCEDI" + newNumber.ToString();

            }
        }

        
    }
}
