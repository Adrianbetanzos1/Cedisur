using Cedisur.Clases;
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
    public partial class EditarPagos : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");
        VerPagos pagos = new();
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Modificar()
        {

            conexion.Open();
            string selectedDate = DTPFechaPago.Value.ToString("yyyy-MM-dd");
            string query = "update Cedisur.dbo.Pagos set importePagoMXP='" + TxtImporteMXP.Text + "', importePagoUSD = '" + TxtImporteUSD.Text + "' ,fechaPago=CAST('" + selectedDate + "' as datetime), SPEI='" + CbSPEI.SelectedItem + "',numCuenta='" + TxtNumeroCuenta.Text + "', numContrato='" + TxtNumContrato.Text + "' where  ID_pago= '" + TxtIdPago.Text + "'";
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

        private void button1_Click(object sender, EventArgs e)
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas editar los datos de este pago?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Modificar();
                this.Close();
                pagos.Show();
            }
        }
    }
}
