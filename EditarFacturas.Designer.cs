namespace Cedisur
{
    partial class EditarFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarFacturas));
            panel1 = new Panel();
            BtnSalir = new PictureBox();
            BtnVolver = new Button();
            label20 = new Label();
            TxtAbono = new TextBox();
            BtnModificar = new Button();
            label11 = new Label();
            label9 = new Label();
            TxtSaldoUSD = new TextBox();
            label8 = new Label();
            TxtSaldoMXP = new TextBox();
            label6 = new Label();
            TxtImporte = new TextBox();
            label5 = new Label();
            TxtDiasVencimiento = new TextBox();
            label4 = new Label();
            DTPFecha = new DateTimePicker();
            label3 = new Label();
            TxtNombreFactura = new TextBox();
            label2 = new Label();
            TxtIDPro = new TextBox();
            label21 = new Label();
            button1 = new Button();
            label7 = new Label();
            TxtDolar = new TextBox();
            label1 = new Label();
            label10 = new Label();
            TxtIdFactura = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(BtnVolver);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1565, 63);
            panel1.TabIndex = 4;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(1511, 15);
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
            BtnVolver.Location = new Point(20, 3);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(141, 53);
            BtnVolver.TabIndex = 2;
            BtnVolver.Text = "Volver a la ventana anterior";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ButtonFace;
            label20.Location = new Point(80, 412);
            label20.Name = "label20";
            label20.Size = new Size(77, 25);
            label20.TabIndex = 71;
            label20.Text = "Abono";
            // 
            // TxtAbono
            // 
            TxtAbono.Location = new Point(80, 440);
            TxtAbono.Name = "TxtAbono";
            TxtAbono.Size = new Size(202, 23);
            TxtAbono.TabIndex = 70;
            TxtAbono.Leave += TxtAbono_Leave;
            // 
            // BtnModificar
            // 
            BtnModificar.BackColor = SystemColors.AppWorkspace;
            BtnModificar.Font = new Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnModificar.Location = new Point(605, 600);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(121, 59);
            BtnModificar.TabIndex = 55;
            BtnModificar.Text = "Editar datos";
            BtnModificar.UseVisualStyleBackColor = false;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(80, 265);
            label11.Name = "label11";
            label11.Size = new Size(161, 25);
            label11.TabIndex = 68;
            label11.Text = "PROVISIONES";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(605, 412);
            label9.Name = "label9";
            label9.Size = new Size(114, 25);
            label9.TabIndex = 67;
            label9.Text = "Saldo USD";
            // 
            // TxtSaldoUSD
            // 
            TxtSaldoUSD.Enabled = false;
            TxtSaldoUSD.Location = new Point(605, 440);
            TxtSaldoUSD.Name = "TxtSaldoUSD";
            TxtSaldoUSD.Size = new Size(166, 23);
            TxtSaldoUSD.TabIndex = 66;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(329, 412);
            label8.Name = "label8";
            label8.Size = new Size(124, 25);
            label8.TabIndex = 65;
            label8.Text = "Saldo MXP";
            // 
            // TxtSaldoMXP
            // 
            TxtSaldoMXP.Enabled = false;
            TxtSaldoMXP.Location = new Point(329, 440);
            TxtSaldoMXP.Name = "TxtSaldoMXP";
            TxtSaldoMXP.Size = new Size(229, 23);
            TxtSaldoMXP.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(861, 333);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 63;
            label6.Text = "Importe";
            // 
            // TxtImporte
            // 
            TxtImporte.Location = new Point(861, 361);
            TxtImporte.Name = "TxtImporte";
            TxtImporte.Size = new Size(166, 23);
            TxtImporte.TabIndex = 69;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(605, 333);
            label5.Name = "label5";
            label5.Size = new Size(222, 25);
            label5.TabIndex = 62;
            label5.Text = "Dias de vencimiento";
            // 
            // TxtDiasVencimiento
            // 
            TxtDiasVencimiento.Location = new Point(605, 361);
            TxtDiasVencimiento.Name = "TxtDiasVencimiento";
            TxtDiasVencimiento.Size = new Size(166, 23);
            TxtDiasVencimiento.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(329, 333);
            label4.Name = "label4";
            label4.Size = new Size(206, 25);
            label4.TabIndex = 60;
            label4.Text = "Fecha de la factura";
            // 
            // DTPFecha
            // 
            DTPFecha.CustomFormat = "yyyy-MM-dd";
            DTPFecha.DropDownAlign = LeftRightAlignment.Right;
            DTPFecha.Format = DateTimePickerFormat.Custom;
            DTPFecha.Location = new Point(329, 361);
            DTPFecha.Name = "DTPFecha";
            DTPFecha.Size = new Size(229, 23);
            DTPFecha.TabIndex = 59;
            DTPFecha.Value = new DateTime(2023, 10, 22, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(79, 333);
            label3.Name = "label3";
            label3.Size = new Size(227, 25);
            label3.TabIndex = 58;
            label3.Text = "Nombre de la factura";
            // 
            // TxtNombreFactura
            // 
            TxtNombreFactura.Location = new Point(80, 361);
            TxtNombreFactura.Name = "TxtNombreFactura";
            TxtNombreFactura.Size = new Size(202, 23);
            TxtNombreFactura.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(80, 174);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 56;
            label2.Text = "ID del proveedor";
            // 
            // TxtIDPro
            // 
            TxtIDPro.Location = new Point(80, 202);
            TxtIDPro.Name = "TxtIDPro";
            TxtIDPro.Size = new Size(268, 23);
            TxtIDPro.TabIndex = 54;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ButtonFace;
            label21.Location = new Point(1250, 218);
            label21.Name = "label21";
            label21.Size = new Size(104, 17);
            label21.TabIndex = 79;
            label21.Text = "Coloque el valor";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1260, 174);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 78;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(1260, 121);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 77;
            label7.Text = "USD hoy";
            // 
            // TxtDolar
            // 
            TxtDolar.Location = new Point(1260, 145);
            TxtDolar.Name = "TxtDolar";
            TxtDolar.Size = new Size(101, 23);
            TxtDolar.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(564, 106);
            label1.Name = "label1";
            label1.Size = new Size(431, 39);
            label1.TabIndex = 80;
            label1.Text = "EDITAR DATOS FACTURA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(390, 174);
            label10.Name = "label10";
            label10.Size = new Size(114, 25);
            label10.TabIndex = 82;
            label10.Text = "ID factura";
            // 
            // TxtIdFactura
            // 
            TxtIdFactura.Location = new Point(390, 202);
            TxtIdFactura.Name = "TxtIdFactura";
            TxtIdFactura.Size = new Size(268, 23);
            TxtIdFactura.TabIndex = 81;
            // 
            // EditarFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1589, 817);
            Controls.Add(label10);
            Controls.Add(TxtIdFactura);
            Controls.Add(label1);
            Controls.Add(label21);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(TxtDolar);
            Controls.Add(label20);
            Controls.Add(TxtAbono);
            Controls.Add(BtnModificar);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(TxtSaldoUSD);
            Controls.Add(label8);
            Controls.Add(TxtSaldoMXP);
            Controls.Add(label6);
            Controls.Add(TxtImporte);
            Controls.Add(label5);
            Controls.Add(TxtDiasVencimiento);
            Controls.Add(label4);
            Controls.Add(DTPFecha);
            Controls.Add(label3);
            Controls.Add(TxtNombreFactura);
            Controls.Add(label2);
            Controls.Add(TxtIDPro);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarProv";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox BtnSalir;
        private Button BtnVolver;
        private Label label20;
        private Button BtnModificar;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label21;
        private Button button1;
        private Label label7;
        private TextBox TxtDolar;
        private Label label1;
        public TextBox TxtAbono;
        public TextBox TxtSaldoUSD;
        public TextBox TxtSaldoMXP;
        public TextBox TxtImporte;
        public TextBox TxtDiasVencimiento;
        public TextBox TxtNombreFactura;
        public TextBox TxtIDPro;
        private Label label10;
        public TextBox TxtIdFactura;
        public DateTimePicker DTPFecha;
    }
}