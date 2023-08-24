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
    public partial class AgregarFacturas : Form
    {





        private SqlConnection conexion = new SqlConnection("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");
        public new Form ParentForm;
        public AgregarFacturas()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VerProveedores menu = new();
            menu.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LimpiarDatos()
        {

            TxtImporteMXP.Clear();
            TxtImporteUSD.Clear();
            DTPFechaPago.Value = DateTime.Now;
            CbSPEI.ClearSelected();
            TxtNumContrato.Clear();
            TxtNumeroCuenta.Clear();

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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            SqlCommand cmd = new SqlCommand("Insert into Facturas(facturaN,importePagoMXP,importePagoUSD, fechaPago, SPEI, numCuenta, numContrato,ID_proveedor) values (@facturaN,@importePagoMXP,@importePagoUSD,@fechaPago, @SPEI,@numCuenta, @numContrato,@ID_proveedor)");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@facturaN", TxtFacturaN.Text);
            cmd.Parameters.AddWithValue("@importePagoMXP", TxtImporteMXP.Text);
            cmd.Parameters.AddWithValue("@importePagoUSD", TxtImporteUSD.Text);
            cmd.Parameters.AddWithValue("@fechaPago", DTPFechaPago.Value);
            cmd.Parameters.AddWithValue("@SPEI", CbSPEI.SelectedItem);
            cmd.Parameters.AddWithValue("@numCuenta", TxtNumeroCuenta.Text);
            cmd.Parameters.AddWithValue("@numContrato", TxtNumContrato.Text);
            cmd.Parameters.AddWithValue("@ID_proveedor", TxtID.Text);


            conexion.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro agregado correctamente");
            LimpiarDatos();
            conexion.Close();



        }

        private void AgregarFacturas_Load(object sender, EventArgs e)
        {
            List<int> generatedNumbers = new List<int>();
            Random random = new();
            int newNumber = random.Next(10000, 100000);

            if (!generatedNumbers.Contains(newNumber))
            {
                generatedNumbers.Add(newNumber);
                TxtFacturaN.Text = "LCEDI" + newNumber.ToString();

            }
        }
    }
}
