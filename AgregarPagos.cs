using Cedisur.Clases;
using Microsoft.Win32;
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
    public partial class AgregarPagos : Form
    {

        private string conexion = "server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true";
        public new Form ParentForm;
        public AgregarPagos()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VerFacturas menu = new();
            menu.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LimpiarDatos()
        {
            TxtIdFactura.Clear();
            TxtID.Clear();
            TxtNombreFactura.Clear();
            TxtNombrePro.Clear();
            TxtImporteMXP.Clear();
            TxtImporteUSD.Clear();
            DTPFechaPago.Value = DateTime.Now;
            CbSPEI.ClearSelected();
            TxtNumContrato.Clear();
            TxtNumeroCuenta.Clear();
            txtSaldoPendiente.Clear();


        }



        private void Button1_Click(object sender, EventArgs e)
        {
            float importeMXP;
            float importeUSD;
            float dolar;


            if (string.IsNullOrEmpty(TxtDolar.Text))
            {

                label21.Text = "Por favor coloque un número donde debe antes de darle click";
            }
            else if (string.IsNullOrEmpty(TxtImporteMXP.Text))
            {
                label21.Text = "Coloque el dato del saldo aportado";
            }
            else
            {
                dolar = float.Parse(TxtDolar.Text);
                importeMXP = float.Parse(TxtImporteMXP.Text);
                importeUSD = importeMXP / dolar;
                TxtImporteUSD.Text = importeUSD.ToString();
            }

        }

        //Empieza codigo prueba


        private int ObtenerSumaTotalActualSaldo()
        {
            int sumaTotalSaldo = 0;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT saldoMXP FROM Factura where ID_factura ='" + TxtIdFactura.Text + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        sumaTotalSaldo = Convert.ToInt32(result);
                    }
                }
            }

            return sumaTotalSaldo;
        }

        private int ObtenerSumaTotalActualAbono()
        {
            int sumaTotalAbono = 0;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT abono FROM Factura where ID_factura ='" + TxtIdFactura.Text + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        sumaTotalAbono = Convert.ToInt32(result);
                    }
                }
            }

            return sumaTotalAbono;
        }



        private void ActualizarSumaTotalAbono(int nuevoSumaTotalAbono)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string updateQuery = "UPDATE Factura SET abono = @nuevoSumaTotalAbono where ID_factura ='" + TxtIdFactura.Text + "'";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@nuevoSumaTotalAbono", nuevoSumaTotalAbono);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void ActualizarSumaTotal(int nuevoSumaTotalSaldo)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string updateQuery = "UPDATE Factura SET saldoMXP = @nuevoSumaTotalSaldo where ID_factura ='" + TxtIdFactura.Text + "'";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@nuevoSumaTotalSaldo", nuevoSumaTotalSaldo);
                    command.ExecuteNonQuery();
                }
            }
        }




        //

        private void BtnAgregar_Click(object sender, EventArgs e)
        {




            if (MessageBox.Show("Estas seguro que deseas aplicar este pago?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {




                using SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
                SqlCommand cmd = new SqlCommand("Insert into Pagos(facturaN,importePagoMXP,importePagoUSD, fechaPago, SPEI, numCuenta, numContrato,ID_proveedor,ID_factura) values (@facturaN,@importePagoMXP,@importePagoUSD,@fechaPago, @SPEI,@numCuenta, @numContrato,@ID_proveedor,@ID_factura)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexion;

                cmd.Parameters.AddWithValue("@facturaN", TxtNombreFactura.Text);
                cmd.Parameters.AddWithValue("@importePagoMXP", TxtImporteMXP.Text);
                cmd.Parameters.AddWithValue("@importePagoUSD", TxtImporteUSD.Text);
                cmd.Parameters.AddWithValue("@fechaPago", DTPFechaPago.Value);
                cmd.Parameters.AddWithValue("@SPEI", CbSPEI.SelectedItem);
                cmd.Parameters.AddWithValue("@numCuenta", TxtNumeroCuenta.Text);
                cmd.Parameters.AddWithValue("@numContrato", TxtNumContrato.Text);
                cmd.Parameters.AddWithValue("@ID_proveedor", TxtID.Text);
                cmd.Parameters.AddWithValue("@ID_factura", TxtIdFactura.Text);

                //Datos del saldo 
                int sumaTotalActual = ObtenerSumaTotalActualSaldo();
                int nuevoValorSaldo = int.Parse(TxtImporteMXP.Text);

                //Datos del abono
                int sumaAbono = ObtenerSumaTotalActualAbono();
                

                if (sumaTotalActual < nuevoValorSaldo)
                {
                    MessageBox.Show("No se puede ingresar una cantidad mayor a la que se debe");
                }
                else
                {
                    
                    ActualizarSumaTotal(sumaTotalActual - nuevoValorSaldo);
                    ActualizarSumaTotalAbono(sumaAbono + nuevoValorSaldo);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado correctamente");
                    LimpiarDatos();
                    conexion.Close();
                    VerFacturas menu = new();
                    menu.Show();
                    this.Close();
                }

                

            }


        }

       
    }
}
