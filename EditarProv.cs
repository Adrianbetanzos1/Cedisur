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
    public partial class EditarProv : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");
        VerProveedores prov = new();

        public new Form ParentForm;
        public EditarProv() => InitializeComponent();




        private void BtnVolver_Click(object sender, EventArgs e)
        {

            this.Close();
            prov.Show();

        }



        private void Modificar()
        {

            conexion.Open();
            string selectedDate = DTPFecha.Value.ToString("yyyy-MM-dd");
            string query = "update Cedisur.dbo.Proveedores set nombreProveedor='" + TxtNombrePro.Text + "', fechaFactura=CAST('" + selectedDate + "' as datetime), diasVencimiento='" + TxtDiasVencimiento.Text + "',importe='" + TxtImporte.Text + "', abono='" + TxtAbono.Text + "', saldoMXP='" + TxtSaldoMXP.Text + "', saldoUSD='" + TxtSaldoUSD.Text + "', saldoPendiente='" + TxtSaldoPendiente.Text + "', provisionesAportadas='" + TxtProvTotal.Text + "' where  ID_proveedor= '" + TxtId.Text + "'";
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

        private void button1_Click(object sender, EventArgs e)
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
            this.Close();
            prov.Show();
        }

    }
}
