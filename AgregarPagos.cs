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


        //Método para calcular el dolar correspondiente en el importe y el saldo a pagar
        private void Button1_Click(object sender, EventArgs e)
        {
            float importeMXP;
            float importeUSD;
            float dolar;


            if (string.IsNullOrEmpty(TxtDolar.Text) || string.IsNullOrEmpty(TxtImporteMXP.Text))
            {

                label21.Text = "Por favor coloque un número donde debe antes de darle click";
            }
            else
            {
                dolar = float.Parse(TxtDolar.Text);
                importeMXP = float.Parse(TxtImporteMXP.Text);
                importeUSD = importeMXP / dolar;
                TxtImporteUSD.Text = importeUSD.ToString();
            }

        }




        //Método para obtener los datos de la suma de los importes de pesos ya existentes
        private float ObtenerSumaTotalActualSaldo()
        {
            float sumaTotalSaldo = 0;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT saldoMXP FROM Factura where ID_factura ='" + TxtIdFactura.Text + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        sumaTotalSaldo = Convert.ToSingle(result);
                    }
                }
            }

            return sumaTotalSaldo;
        }

        //Método para obtener los datos de la suma de los importes de dolar ya existentes
        private float ObtenerSumaTotalActualSaldoUSD()
        {
            float sumaTotalSaldo = 0;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT saldoUSD FROM Factura where ID_factura ='" + TxtIdFactura.Text + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        sumaTotalSaldo = Convert.ToSingle(result);
                    }
                }
            }

            return sumaTotalSaldo;
        }


        //Método para obtener los datos de la suma de los abonos ya existentes
        private float ObtenerSumaTotalActualAbono()
        {
            float sumaTotalAbono = 0;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT abono FROM Factura where ID_factura ='" + TxtIdFactura.Text + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        sumaTotalAbono = Convert.ToSingle(result);
                    }
                }
            }

            return sumaTotalAbono;
        }



        //Método para actualizar los datos de la suma del abono
        private void ActualizarSumaTotalAbono(float nuevoSumaTotalAbono)
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

        //Método para actualizar los datos de la suma de los importes de pesos
        private void ActualizarSumaTotal(float nuevoSumaTotalSaldo)
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

        //Método para actualizar los datos de la suma de los importes de dolar
        private void ActualizarSumaTotalUSD(float nuevoSumaTotalSaldoUSD)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string updateQuery = "UPDATE Factura SET saldoUSD = @nuevoSumaTotalSaldoUSD where ID_factura ='" + TxtIdFactura.Text + "'";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@nuevoSumaTotalSaldoUSD", nuevoSumaTotalSaldoUSD);
                    command.ExecuteNonQuery();
                }
            }
        }




        //Método para agregar un registro de un pago nuevo
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtImporteMXP.Text) || string.IsNullOrEmpty(TxtImporteUSD.Text) || string.IsNullOrEmpty(TxtNumContrato.Text) || string.IsNullOrEmpty(TxtNumeroCuenta.Text) || CbSPEI.CheckedItems.Count == 0)
            {
                MessageBox.Show("Colocar los datos faltantes antes de continuar");
            }
            else if (float.Parse(TxtImporteMXP.Text) > float.Parse(txtSaldoPendiente.Text))
            {
                MessageBox.Show("No puede proseguir debido a que el importe que se desea agregar es mayor al saldo pendiente", "Advertencia");

            }
            else if (MessageBox.Show("Estas seguro que deseas aplicar este pago?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                using SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
                SqlCommand cmd = new SqlCommand("Insert into Pagos(facturaN,importePagoMXP,importePagoUSD, fechaPago, SPEI, numCuenta, numContrato,ID_proveedor,ID_factura,TipoDeCambio) values (@facturaN,@importePagoMXP,@importePagoUSD,@fechaPago, @SPEI,@numCuenta, @numContrato,@ID_proveedor,@ID_factura,@tipoDeCambio)");
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
                cmd.Parameters.AddWithValue("@tipoDeCambio", TxtDolar.Text);

                //Datos del saldo en dls y mxp
                float sumaTotalActual = ObtenerSumaTotalActualSaldo();
                float nuevoValorSaldo = float.Parse(TxtImporteMXP.Text);
                float sumaTotalActualUSD = ObtenerSumaTotalActualSaldoUSD();
                float nuevoValorSaldoUSD = float.Parse(TxtImporteUSD.Text);

                //Datos del abono
                float sumaAbono = ObtenerSumaTotalActualAbono();


                if (sumaTotalActual < nuevoValorSaldo)
                {
                    MessageBox.Show("No se puede ingresar una cantidad mayor a la que se debe");
                }
                else
                {

                    //Métodos para actualizar el saldo, y los importes de usd y mxp
                    ActualizarSumaTotal(sumaTotalActual - nuevoValorSaldo);
                    ActualizarSumaTotalUSD(sumaTotalActualUSD - nuevoValorSaldoUSD);
                    ActualizarSumaTotalAbono(sumaAbono + nuevoValorSaldo);


                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Pago registrado correctamente");
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
