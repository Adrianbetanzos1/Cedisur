namespace Cedisur
{
    partial class AgregarFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarFacturas));
            label1 = new Label();
            panel1 = new Panel();
            BtnSalir = new PictureBox();
            BtnVolver = new Button();
            TxtIDProveedor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TxtNombreFactura = new TextBox();
            DTPFecha = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            TxtDiasVencimiento = new TextBox();
            label6 = new Label();
            TxtImporte = new TextBox();
            label7 = new Label();
            TxtDolar = new TextBox();
            label8 = new Label();
            TxtSaldoMXP = new TextBox();
            label9 = new Label();
            TxtSaldoUSD = new TextBox();
            label11 = new Label();
            BtnAgregar = new Button();
            button1 = new Button();
            label20 = new Label();
            TxtAbono = new TextBox();
            label21 = new Label();
            label10 = new Label();
            TxtNombrePro = new TextBox();
            label12 = new Label();
            TxtImporteUSD = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(593, 101);
            label1.Name = "label1";
            label1.Size = new Size(347, 39);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR FACTURA";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(BtnVolver);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1565, 67);
            panel1.TabIndex = 1;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(1519, 20);
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
            BtnVolver.Location = new Point(3, 7);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(141, 53);
            BtnVolver.TabIndex = 2;
            BtnVolver.Text = "Volver a la ventana anterior";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // TxtIDProveedor
            // 
            TxtIDProveedor.Enabled = false;
            TxtIDProveedor.Location = new Point(136, 286);
            TxtIDProveedor.Name = "TxtIDProveedor";
            TxtIDProveedor.Size = new Size(268, 23);
            TxtIDProveedor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(136, 258);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 3;
            label2.Text = "ID del proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(135, 417);
            label3.Name = "label3";
            label3.Size = new Size(227, 25);
            label3.TabIndex = 5;
            label3.Text = "Nombre de la factura";
            // 
            // TxtNombreFactura
            // 
            TxtNombreFactura.Location = new Point(136, 445);
            TxtNombreFactura.Name = "TxtNombreFactura";
            TxtNombreFactura.Size = new Size(202, 23);
            TxtNombreFactura.TabIndex = 4;
            // 
            // DTPFecha
            // 
            DTPFecha.Location = new Point(385, 445);
            DTPFecha.Name = "DTPFecha";
            DTPFecha.Size = new Size(229, 23);
            DTPFecha.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(385, 417);
            label4.Name = "label4";
            label4.Size = new Size(206, 25);
            label4.TabIndex = 7;
            label4.Text = "Fecha de la factura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(661, 417);
            label5.Name = "label5";
            label5.Size = new Size(222, 25);
            label5.TabIndex = 9;
            label5.Text = "Dias de vencimiento";
            // 
            // TxtDiasVencimiento
            // 
            TxtDiasVencimiento.Location = new Point(661, 445);
            TxtDiasVencimiento.Name = "TxtDiasVencimiento";
            TxtDiasVencimiento.Size = new Size(166, 23);
            TxtDiasVencimiento.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(917, 417);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 11;
            label6.Text = "Importe MXP";
            // 
            // TxtImporte
            // 
            TxtImporte.Location = new Point(917, 445);
            TxtImporte.Name = "TxtImporte";
            TxtImporte.Size = new Size(166, 23);
            TxtImporte.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(1180, 101);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 13;
            label7.Text = "USD hoy";
            // 
            // TxtDolar
            // 
            TxtDolar.Location = new Point(1180, 125);
            TxtDolar.Name = "TxtDolar";
            TxtDolar.Size = new Size(101, 23);
            TxtDolar.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(385, 496);
            label8.Name = "label8";
            label8.Size = new Size(124, 25);
            label8.TabIndex = 15;
            label8.Text = "Saldo MXP";
            // 
            // TxtSaldoMXP
            // 
            TxtSaldoMXP.Enabled = false;
            TxtSaldoMXP.Location = new Point(385, 524);
            TxtSaldoMXP.Name = "TxtSaldoMXP";
            TxtSaldoMXP.Size = new Size(229, 23);
            TxtSaldoMXP.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(661, 496);
            label9.Name = "label9";
            label9.Size = new Size(114, 25);
            label9.TabIndex = 17;
            label9.Text = "Saldo USD";
            // 
            // TxtSaldoUSD
            // 
            TxtSaldoUSD.Enabled = false;
            TxtSaldoUSD.Location = new Point(661, 524);
            TxtSaldoUSD.Name = "TxtSaldoUSD";
            TxtSaldoUSD.Size = new Size(166, 23);
            TxtSaldoUSD.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(136, 349);
            label11.Name = "label11";
            label11.Size = new Size(161, 25);
            label11.TabIndex = 19;
            label11.Text = "PROVISIONES";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = SystemColors.AppWorkspace;
            BtnAgregar.Font = new Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.Location = new Point(661, 617);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(121, 59);
            BtnAgregar.TabIndex = 3;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1180, 154);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 37;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ButtonFace;
            label20.Location = new Point(136, 496);
            label20.Name = "label20";
            label20.Size = new Size(77, 25);
            label20.TabIndex = 39;
            label20.Text = "Abono";
            // 
            // TxtAbono
            // 
            TxtAbono.Location = new Point(136, 524);
            TxtAbono.Name = "TxtAbono";
            TxtAbono.Size = new Size(202, 23);
            TxtAbono.TabIndex = 38;
            TxtAbono.Leave += TxtAbono_Leave;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ButtonFace;
            label21.Location = new Point(1170, 198);
            label21.Name = "label21";
            label21.Size = new Size(104, 17);
            label21.TabIndex = 40;
            label21.Text = "Coloque el valor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(448, 258);
            label10.Name = "label10";
            label10.Size = new Size(242, 25);
            label10.TabIndex = 55;
            label10.Text = "Nombre del proveedor";
            // 
            // TxtNombrePro
            // 
            TxtNombrePro.Enabled = false;
            TxtNombrePro.Location = new Point(448, 286);
            TxtNombrePro.Name = "TxtNombrePro";
            TxtNombrePro.Size = new Size(268, 23);
            TxtNombrePro.TabIndex = 54;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(1141, 417);
            label12.Name = "label12";
            label12.Size = new Size(141, 25);
            label12.TabIndex = 56;
            label12.Text = "Importe USD";
            // 
            // TxtImporteUSD
            // 
            TxtImporteUSD.Enabled = false;
            TxtImporteUSD.Location = new Point(1141, 445);
            TxtImporteUSD.Name = "TxtImporteUSD";
            TxtImporteUSD.Size = new Size(166, 23);
            TxtImporteUSD.TabIndex = 57;
            // 
            // AgregarFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1589, 817);
            Controls.Add(label12);
            Controls.Add(TxtImporteUSD);
            Controls.Add(label10);
            Controls.Add(TxtNombrePro);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(TxtAbono);
            Controls.Add(button1);
            Controls.Add(BtnAgregar);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(TxtSaldoUSD);
            Controls.Add(label8);
            Controls.Add(TxtSaldoMXP);
            Controls.Add(label7);
            Controls.Add(TxtDolar);
            Controls.Add(label6);
            Controls.Add(TxtImporte);
            Controls.Add(label5);
            Controls.Add(TxtDiasVencimiento);
            Controls.Add(label4);
            Controls.Add(DTPFecha);
            Controls.Add(label3);
            Controls.Add(TxtNombreFactura);
            Controls.Add(label2);
            Controls.Add(TxtIDProveedor);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarFactura";
            Load += AgregarFacturas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button BtnVolver;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtDolar;
        private Label label8;
        private Label label9;
        private Label label11;
        private Button BtnAgregar;
        private PictureBox BtnSalir;
        private Button button1;
        private Label label20;
        private Label label21;
        private Label label10;
        public TextBox TxtNombrePro;
        public TextBox TxtIDProveedor;
        public TextBox TxtNombreFactura;
        public DateTimePicker DTPFecha;
        public TextBox TxtDiasVencimiento;
        public TextBox TxtImporte;
        public TextBox TxtSaldoMXP;
        public TextBox TxtSaldoUSD;
        public TextBox TxtAbono;
        private Label label12;
        public TextBox TxtImporteUSD;
    }
}