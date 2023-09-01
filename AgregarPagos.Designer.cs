namespace Cedisur
{
    partial class AgregarPagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPagos));
            panel1 = new Panel();
            BtnSalir = new PictureBox();
            BtnVolver = new Button();
            label17 = new Label();
            TxtNumContrato = new TextBox();
            label16 = new Label();
            TxtNumeroCuenta = new TextBox();
            label15 = new Label();
            CbSPEI = new CheckedListBox();
            label14 = new Label();
            TxtImporteUSD = new TextBox();
            label13 = new Label();
            DTPFechaPago = new DateTimePicker();
            label12 = new Label();
            TxtImporteMXP = new TextBox();
            label10 = new Label();
            label21 = new Label();
            button1 = new Button();
            label7 = new Label();
            TxtDolar = new TextBox();
            BtnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            TxtNombrePro = new TextBox();
            label3 = new Label();
            TxtID = new TextBox();
            label4 = new Label();
            txtSaldoPendiente = new TextBox();
            label5 = new Label();
            TxtNombreFactura = new TextBox();
            label6 = new Label();
            TxtIdFactura = new TextBox();
            txtABono = new TextBox();
            label8 = new Label();
            txtSaldoUSD = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(BtnVolver);
            panel1.Location = new Point(-4, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1581, 63);
            panel1.TabIndex = 2;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(1537, 15);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(29, 27);
            BtnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSalir.TabIndex = 37;
            BtnSalir.TabStop = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = SystemColors.AppWorkspace;
            BtnVolver.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVolver.Location = new Point(29, 3);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(141, 53);
            BtnVolver.TabIndex = 2;
            BtnVolver.Text = "Volver a la ventana anterior";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonFace;
            label17.Location = new Point(356, 552);
            label17.Name = "label17";
            label17.Size = new Size(301, 29);
            label17.TabIndex = 45;
            label17.Text = "Número de contrato/OC";
            // 
            // TxtNumContrato
            // 
            TxtNumContrato.Location = new Point(357, 584);
            TxtNumContrato.Name = "TxtNumContrato";
            TxtNumContrato.Size = new Size(300, 23);
            TxtNumContrato.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(65, 552);
            label16.Name = "label16";
            label16.Size = new Size(231, 29);
            label16.TabIndex = 43;
            label16.Text = "Número de cuenta";
            // 
            // TxtNumeroCuenta
            // 
            TxtNumeroCuenta.Location = new Point(65, 584);
            TxtNumeroCuenta.Name = "TxtNumeroCuenta";
            TxtNumeroCuenta.Size = new Size(233, 23);
            TxtNumeroCuenta.TabIndex = 42;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(947, 447);
            label15.Name = "label15";
            label15.Size = new Size(67, 29);
            label15.TabIndex = 41;
            label15.Text = "SPEI";
            // 
            // CbSPEI
            // 
            CbSPEI.FormattingEnabled = true;
            CbSPEI.Items.AddRange(new object[] { "Dolar", "Peso Mexicano" });
            CbSPEI.Location = new Point(947, 479);
            CbSPEI.Name = "CbSPEI";
            CbSPEI.Size = new Size(129, 58);
            CbSPEI.TabIndex = 40;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(356, 447);
            label14.Name = "label14";
            label14.Size = new Size(226, 29);
            label14.TabIndex = 39;
            label14.Text = "Importe pago USD";
            // 
            // TxtImporteUSD
            // 
            TxtImporteUSD.Enabled = false;
            TxtImporteUSD.Location = new Point(356, 479);
            TxtImporteUSD.Name = "TxtImporteUSD";
            TxtImporteUSD.Size = new Size(248, 23);
            TxtImporteUSD.TabIndex = 38;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(654, 447);
            label13.Name = "label13";
            label13.Size = new Size(193, 29);
            label13.TabIndex = 37;
            label13.Text = "Fecha del pago";
            // 
            // DTPFechaPago
            // 
            DTPFechaPago.Location = new Point(655, 479);
            DTPFechaPago.Name = "DTPFechaPago";
            DTPFechaPago.Size = new Size(229, 23);
            DTPFechaPago.TabIndex = 36;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(65, 447);
            label12.Name = "label12";
            label12.Size = new Size(237, 29);
            label12.TabIndex = 35;
            label12.Text = "Importe pago MXP";
            // 
            // TxtImporteMXP
            // 
            TxtImporteMXP.Location = new Point(65, 479);
            TxtImporteMXP.Name = "TxtImporteMXP";
            TxtImporteMXP.Size = new Size(233, 23);
            TxtImporteMXP.TabIndex = 34;
            TxtImporteMXP.Leave += TxtImporteMXP_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(549, 88);
            label10.Name = "label10";
            label10.Size = new Size(230, 29);
            label10.TabIndex = 33;
            label10.Text = "GENERAR PAGOS";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ButtonFace;
            label21.Location = new Point(1197, 219);
            label21.Name = "label21";
            label21.Size = new Size(104, 17);
            label21.TabIndex = 53;
            label21.Text = "Coloque el valor";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1197, 177);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 52;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(1197, 124);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 51;
            label7.Text = "USD hoy";
            // 
            // TxtDolar
            // 
            TxtDolar.Location = new Point(1197, 148);
            TxtDolar.Name = "TxtDolar";
            TxtDolar.Size = new Size(101, 23);
            TxtDolar.TabIndex = 50;
            TxtDolar.Leave += TxtDolar_Leave;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = SystemColors.AppWorkspace;
            BtnAgregar.Font = new Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.Location = new Point(755, 664);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(129, 63);
            BtnAgregar.TabIndex = 54;
            BtnAgregar.Text = "Aplicar pago";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 275);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(356, 346);
            label2.Name = "label2";
            label2.Size = new Size(238, 29);
            label2.TabIndex = 60;
            label2.Text = "Nombre proveedor";
            // 
            // TxtNombrePro
            // 
            TxtNombrePro.Enabled = false;
            TxtNombrePro.Location = new Point(356, 378);
            TxtNombrePro.Name = "TxtNombrePro";
            TxtNombrePro.Size = new Size(248, 23);
            TxtNombrePro.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(65, 346);
            label3.Name = "label3";
            label3.Size = new Size(169, 29);
            label3.TabIndex = 58;
            label3.Text = "ID proveedor";
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(65, 378);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(233, 23);
            TxtID.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(655, 259);
            label4.Name = "label4";
            label4.Size = new Size(419, 29);
            label4.TabIndex = 62;
            label4.Text = "Saldo pendiente de la factura MXP";
            // 
            // txtSaldoPendiente
            // 
            txtSaldoPendiente.Enabled = false;
            txtSaldoPendiente.Location = new Point(654, 291);
            txtSaldoPendiente.Name = "txtSaldoPendiente";
            txtSaldoPendiente.Size = new Size(355, 23);
            txtSaldoPendiente.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(357, 259);
            label5.Name = "label5";
            label5.Size = new Size(263, 29);
            label5.TabIndex = 64;
            label5.Text = "Nombre de la factura";
            // 
            // TxtNombreFactura
            // 
            TxtNombreFactura.Enabled = false;
            TxtNombreFactura.Location = new Point(357, 291);
            TxtNombreFactura.Name = "TxtNombreFactura";
            TxtNombreFactura.Size = new Size(248, 23);
            TxtNombreFactura.TabIndex = 63;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(65, 259);
            label6.Name = "label6";
            label6.Size = new Size(131, 29);
            label6.TabIndex = 66;
            label6.Text = "ID factura";
            // 
            // TxtIdFactura
            // 
            TxtIdFactura.Enabled = false;
            TxtIdFactura.Location = new Point(65, 291);
            TxtIdFactura.Name = "TxtIdFactura";
            TxtIdFactura.Size = new Size(233, 23);
            TxtIdFactura.TabIndex = 65;
            // 
            // txtABono
            // 
            txtABono.Enabled = false;
            txtABono.Location = new Point(12, 74);
            txtABono.Name = "txtABono";
            txtABono.Size = new Size(355, 23);
            txtABono.TabIndex = 67;
            txtABono.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(655, 346);
            label8.Name = "label8";
            label8.Size = new Size(408, 29);
            label8.TabIndex = 69;
            label8.Text = "Saldo pendiente de la factura USD";
            // 
            // txtSaldoUSD
            // 
            txtSaldoUSD.Enabled = false;
            txtSaldoUSD.Location = new Point(654, 378);
            txtSaldoUSD.Name = "txtSaldoUSD";
            txtSaldoUSD.Size = new Size(355, 23);
            txtSaldoUSD.TabIndex = 68;
            // 
            // AgregarPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1589, 817);
            Controls.Add(label8);
            Controls.Add(txtSaldoUSD);
            Controls.Add(txtABono);
            Controls.Add(label6);
            Controls.Add(TxtIdFactura);
            Controls.Add(label5);
            Controls.Add(TxtNombreFactura);
            Controls.Add(label4);
            Controls.Add(txtSaldoPendiente);
            Controls.Add(label2);
            Controls.Add(TxtNombrePro);
            Controls.Add(label3);
            Controls.Add(TxtID);
            Controls.Add(label1);
            Controls.Add(BtnAgregar);
            Controls.Add(label21);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(TxtDolar);
            Controls.Add(label17);
            Controls.Add(TxtNumContrato);
            Controls.Add(label16);
            Controls.Add(TxtNumeroCuenta);
            Controls.Add(label15);
            Controls.Add(CbSPEI);
            Controls.Add(label14);
            Controls.Add(TxtImporteUSD);
            Controls.Add(label13);
            Controls.Add(DTPFechaPago);
            Controls.Add(label12);
            Controls.Add(TxtImporteMXP);
            Controls.Add(label10);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarFacturas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox BtnSalir;
        private Button BtnVolver;
        private Label label17;
        private TextBox TxtNumContrato;
        private Label label16;
        private TextBox TxtNumeroCuenta;
        private Label label15;
        private CheckedListBox CbSPEI;
        private Label label14;
        private TextBox TxtImporteUSD;
        private Label label13;
        private DateTimePicker DTPFechaPago;
        private Label label12;
        private TextBox TxtImporteMXP;
        private Label label10;
        private Label label21;
        private Button button1;
        private Label label7;
        private TextBox TxtDolar;
        private Button BtnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox TxtNombrePro;
        public TextBox TxtID;
        public TextBox txtSaldoPendiente;
        private Label label5;
        public TextBox TxtNombreFactura;
        private Label label6;
        public TextBox TxtIdFactura;
        public TextBox txtABono;
        private Label label8;
        public TextBox txtSaldoUSD;
    }
}