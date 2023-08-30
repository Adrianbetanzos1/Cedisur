namespace Cedisur
{
    partial class EditarPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPagos));
            panel1 = new Panel();
            BtnSalir = new PictureBox();
            BtnVolver = new Button();
            label6 = new Label();
            TxtIdFactura = new TextBox();
            label5 = new Label();
            TxtNombreFactura = new TextBox();
            label4 = new Label();
            txtSaldoPendiente = new TextBox();
            label2 = new Label();
            TxtNombrePro = new TextBox();
            label3 = new Label();
            TxtID = new TextBox();
            label1 = new Label();
            BtnAgregar = new Button();
            label21 = new Label();
            button1 = new Button();
            label7 = new Label();
            TxtDolar = new TextBox();
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
            label8 = new Label();
            TxtIdPago = new TextBox();
            label9 = new Label();
            label11 = new Label();
            txtSaldoUSD = new TextBox();
            txtAbono = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(BtnVolver);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1549, 63);
            panel1.TabIndex = 3;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(1502, 15);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(144, 299);
            label6.Name = "label6";
            label6.Size = new Size(131, 29);
            label6.TabIndex = 95;
            label6.Text = "ID factura";
            // 
            // TxtIdFactura
            // 
            TxtIdFactura.Enabled = false;
            TxtIdFactura.Location = new Point(144, 331);
            TxtIdFactura.Name = "TxtIdFactura";
            TxtIdFactura.Size = new Size(233, 23);
            TxtIdFactura.TabIndex = 94;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(436, 299);
            label5.Name = "label5";
            label5.Size = new Size(263, 29);
            label5.TabIndex = 93;
            label5.Text = "Nombre de la factura";
            // 
            // TxtNombreFactura
            // 
            TxtNombreFactura.Enabled = false;
            TxtNombreFactura.Location = new Point(436, 331);
            TxtNombreFactura.Name = "TxtNombreFactura";
            TxtNombreFactura.Size = new Size(248, 23);
            TxtNombreFactura.TabIndex = 92;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(734, 299);
            label4.Name = "label4";
            label4.Size = new Size(419, 29);
            label4.TabIndex = 91;
            label4.Text = "Saldo pendiente de la factura MXP";
            // 
            // txtSaldoPendiente
            // 
            txtSaldoPendiente.Enabled = false;
            txtSaldoPendiente.Location = new Point(734, 331);
            txtSaldoPendiente.Name = "txtSaldoPendiente";
            txtSaldoPendiente.Size = new Size(354, 23);
            txtSaldoPendiente.TabIndex = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(435, 386);
            label2.Name = "label2";
            label2.Size = new Size(238, 29);
            label2.TabIndex = 89;
            label2.Text = "Nombre proveedor";
            // 
            // TxtNombrePro
            // 
            TxtNombrePro.Enabled = false;
            TxtNombrePro.Location = new Point(435, 418);
            TxtNombrePro.Name = "TxtNombrePro";
            TxtNombrePro.Size = new Size(248, 23);
            TxtNombrePro.TabIndex = 88;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(144, 386);
            label3.Name = "label3";
            label3.Size = new Size(169, 29);
            label3.TabIndex = 87;
            label3.Text = "ID proveedor";
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(144, 418);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(233, 23);
            TxtID.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 315);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 85;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = SystemColors.AppWorkspace;
            BtnAgregar.Font = new Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.Location = new Point(868, 646);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(129, 63);
            BtnAgregar.TabIndex = 84;
            BtnAgregar.Text = "Editar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ButtonFace;
            label21.Location = new Point(1276, 259);
            label21.Name = "label21";
            label21.Size = new Size(104, 17);
            label21.TabIndex = 83;
            label21.Text = "Coloque el valor";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1276, 217);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 82;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(1276, 164);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 81;
            label7.Text = "USD hoy";
            // 
            // TxtDolar
            // 
            TxtDolar.Location = new Point(1276, 188);
            TxtDolar.Name = "TxtDolar";
            TxtDolar.Size = new Size(101, 23);
            TxtDolar.TabIndex = 80;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonFace;
            label17.Location = new Point(435, 614);
            label17.Name = "label17";
            label17.Size = new Size(301, 29);
            label17.TabIndex = 79;
            label17.Text = "Número de contrato/OC";
            // 
            // TxtNumContrato
            // 
            TxtNumContrato.Location = new Point(436, 646);
            TxtNumContrato.Name = "TxtNumContrato";
            TxtNumContrato.Size = new Size(300, 23);
            TxtNumContrato.TabIndex = 78;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(144, 614);
            label16.Name = "label16";
            label16.Size = new Size(231, 29);
            label16.TabIndex = 77;
            label16.Text = "Número de cuenta";
            // 
            // TxtNumeroCuenta
            // 
            TxtNumeroCuenta.Location = new Point(144, 646);
            TxtNumeroCuenta.Name = "TxtNumeroCuenta";
            TxtNumeroCuenta.Size = new Size(233, 23);
            TxtNumeroCuenta.TabIndex = 76;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(1026, 487);
            label15.Name = "label15";
            label15.Size = new Size(67, 29);
            label15.TabIndex = 75;
            label15.Text = "SPEI";
            // 
            // CbSPEI
            // 
            CbSPEI.FormattingEnabled = true;
            CbSPEI.Items.AddRange(new object[] { "Dolar", "Peso Mexicano" });
            CbSPEI.Location = new Point(1026, 519);
            CbSPEI.Name = "CbSPEI";
            CbSPEI.Size = new Size(129, 58);
            CbSPEI.TabIndex = 74;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(435, 487);
            label14.Name = "label14";
            label14.Size = new Size(226, 29);
            label14.TabIndex = 73;
            label14.Text = "Importe pago USD";
            // 
            // TxtImporteUSD
            // 
            TxtImporteUSD.Enabled = false;
            TxtImporteUSD.Location = new Point(435, 519);
            TxtImporteUSD.Name = "TxtImporteUSD";
            TxtImporteUSD.Size = new Size(248, 23);
            TxtImporteUSD.TabIndex = 72;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(733, 487);
            label13.Name = "label13";
            label13.Size = new Size(193, 29);
            label13.TabIndex = 71;
            label13.Text = "Fecha del pago";
            // 
            // DTPFechaPago
            // 
            DTPFechaPago.Location = new Point(734, 519);
            DTPFechaPago.Name = "DTPFechaPago";
            DTPFechaPago.Size = new Size(229, 23);
            DTPFechaPago.TabIndex = 70;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(144, 487);
            label12.Name = "label12";
            label12.Size = new Size(237, 29);
            label12.TabIndex = 69;
            label12.Text = "Importe pago MXP";
            // 
            // TxtImporteMXP
            // 
            TxtImporteMXP.Location = new Point(144, 519);
            TxtImporteMXP.Name = "TxtImporteMXP";
            TxtImporteMXP.Size = new Size(233, 23);
            TxtImporteMXP.TabIndex = 68;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(628, 128);
            label10.Name = "label10";
            label10.Size = new Size(201, 29);
            label10.TabIndex = 67;
            label10.Text = "EDITAR PAGOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(144, 219);
            label8.Name = "label8";
            label8.Size = new Size(105, 29);
            label8.TabIndex = 98;
            label8.Text = "ID pago";
            // 
            // TxtIdPago
            // 
            TxtIdPago.Enabled = false;
            TxtIdPago.Location = new Point(144, 251);
            TxtIdPago.Name = "TxtIdPago";
            TxtIdPago.Size = new Size(233, 23);
            TxtIdPago.TabIndex = 97;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(162, 235);
            label9.Name = "label9";
            label9.Size = new Size(0, 32);
            label9.TabIndex = 96;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(734, 386);
            label11.Name = "label11";
            label11.Size = new Size(408, 29);
            label11.TabIndex = 100;
            label11.Text = "Saldo pendiente de la factura USD";
            // 
            // txtSaldoUSD
            // 
            txtSaldoUSD.Enabled = false;
            txtSaldoUSD.Location = new Point(733, 418);
            txtSaldoUSD.Name = "txtSaldoUSD";
            txtSaldoUSD.Size = new Size(355, 23);
            txtSaldoUSD.TabIndex = 99;
            // 
            // txtAbono
            // 
            txtAbono.Enabled = false;
            txtAbono.Location = new Point(21, 101);
            txtAbono.Name = "txtAbono";
            txtAbono.Size = new Size(354, 23);
            txtAbono.TabIndex = 101;
            // 
            // EditarPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1573, 778);
            Controls.Add(txtAbono);
            Controls.Add(label11);
            Controls.Add(txtSaldoUSD);
            Controls.Add(label8);
            Controls.Add(TxtIdPago);
            Controls.Add(label9);
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
            Name = "EditarPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarPagos";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox BtnSalir;
        private Button BtnVolver;
        private Label label6;
        public TextBox TxtIdFactura;
        private Label label5;
        public TextBox TxtNombreFactura;
        private Label label4;
        public TextBox txtSaldoPendiente;
        private Label label2;
        public TextBox TxtNombrePro;
        private Label label3;
        public TextBox TxtID;
        private Label label1;
        private Button BtnAgregar;
        private Label label21;
        private Button button1;
        private Label label7;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label10;
        public TextBox TxtNumContrato;
        public TextBox TxtNumeroCuenta;
        public CheckedListBox CbSPEI;
        public TextBox TxtImporteUSD;
        public DateTimePicker DTPFechaPago;
        public TextBox TxtImporteMXP;
        private Label label8;
        public TextBox TxtIdPago;
        private Label label9;
        private Label label11;
        public TextBox txtSaldoUSD;
        public TextBox TxtDolar;
        public TextBox txtAbono;
    }
}