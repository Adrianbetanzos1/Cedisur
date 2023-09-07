using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class EditarPagos : Form
    {

        private readonly string conexion = "server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true";

        readonly VerPagos pagos = new VerPagos();
        public new Form ParentForm;
        public EditarPagos()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            pagos.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Método para obtener los datos de la suma de los importes de pesos ya existentes
        private float ObtenerSumaTotalActualSaldo()
        {
            float sumaTotalSaldo = 0;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT saldoAnterior FROM Factura where ID_factura ='" + TxtIdFactura.Text + "'";
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

                string query = "SELECT saldoAnteriorUSD FROM Factura where ID_factura ='" + TxtIdFactura.Text + "'";
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


        //Método para obtener la suma del abono que ya se ha realizado
        private float ObtenerSumaTotalActualAbono()
        {
            float sumaTotalAbono = 0;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT AbonoAnterior FROM Factura where ID_factura ='" + TxtIdFactura.Text + "'";
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



        //Termina 


        //Método para modificar los datos de los pagos, rectificando los datos anteriores de la factura
        private void Modificar()
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                //Datos del saldo en dls y mxp
                float sumaTotalActual = ObtenerSumaTotalActualSaldo();
                float nuevoValorSaldo = float.Parse(TxtImporteMXP.Text);
                float sumaTotalActualUSD = ObtenerSumaTotalActualSaldoUSD();
                float nuevoValorSaldoUSD = float.Parse(TxtImporteUSD.Text);

                float sumaAbono = ObtenerSumaTotalActualAbono();


                ActualizarSumaTotal(sumaTotalActual - nuevoValorSaldo);
                ActualizarSumaTotalUSD(sumaTotalActualUSD - nuevoValorSaldoUSD);
                ActualizarSumaTotalAbono(sumaAbono + nuevoValorSaldo);


                string selectedDate = DTPFechaPago.Value.ToString("yyyy-MM-dd");
                string query = "update Cedisur.dbo.Pagos set importePagoMXP='" + float.Parse(TxtImporteMXP.Text).ToString("F2") + "'," +
                " importePagoUSD = '" + float.Parse(TxtImporteUSD.Text).ToString("F2") + "' ,fechaPago=CAST('" + selectedDate + "' as datetime)," +
                " SPEI='" + CbSPEI.SelectedItem + "', numCuenta='" + TxtNumeroCuenta.Text + "', numContrato='" + TxtNumContrato.Text + "' " +
                ",TipoDeCambio= '" + TxtDolar.Text + "' where  ID_pago= '" + TxtIdPago.Text + "'";
                SqlCommand comando = new SqlCommand(query, connection);
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
                connection.Close();
            }
               
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
            else if (string.IsNullOrEmpty(TxtImporteMXP.Text))
            {
                label21.Text = "Coloque el dato del saldo aportado";
            }
            else
            {

                dolar = float.Parse(TxtDolar.Text);

                saldoMXP = float.Parse(TxtImporteMXP.Text);

                saldoUSD = saldoMXP / dolar;


                TxtImporteUSD.Text = saldoUSD.ToString();


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

        private void TxtImporteMXP_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(TxtImporteMXP.Text, out _))
            {
                MessageBox.Show("Ingrese un valor númerico");
                TxtImporteMXP.Focus();
            }
            else
            {
                DTPFechaPago.Focus();
            }
        }

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
                Modificar();
                this.Close();
                pagos.Show();
            }
        }
    }
}
