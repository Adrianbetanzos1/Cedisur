namespace CedisurB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtDolar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSaldoMXP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtAbono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDiasVencimiento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtImporteUSD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSaldoUSD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombreFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIdFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIDPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.BtnVolver);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 52);
            this.panel1.TabIndex = 7;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(0, 0);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(153, 52);
            this.BtnVolver.TabIndex = 8;
            this.BtnVolver.Text = "Volver a la ventana anterior";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1488, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(913, 642);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(128, 52);
            this.BtnAgregar.TabIndex = 59;
            this.BtnAgregar.Text = "Editar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label21.ForeColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(1174, 252);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 17);
            this.label21.TabIndex = 58;
            this.label21.Text = "Coloque el valor";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1286, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 25);
            this.button1.TabIndex = 36;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtDolar
            // 
            this.TxtDolar.Location = new System.Drawing.Point(1177, 189);
            this.TxtDolar.Name = "TxtDolar";
            this.TxtDolar.Size = new System.Drawing.Size(333, 20);
            this.TxtDolar.TabIndex = 57;
            this.TxtDolar.Leave += new System.EventHandler(this.TxtDolar_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(1291, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 25);
            this.label13.TabIndex = 56;
            this.label13.Text = "USD HOY";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(484, 445);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 25);
            this.label12.TabIndex = 55;
            this.label12.Text = "FECHA DE FACTURACIÓN";
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(489, 473);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(338, 20);
            this.DTPFecha.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(63, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 59);
            this.label10.TabIndex = 53;
            this.label10.Text = "Provisiones";
            // 
            // TxtSaldoMXP
            // 
            this.TxtSaldoMXP.Enabled = false;
            this.TxtSaldoMXP.Location = new System.Drawing.Point(73, 674);
            this.TxtSaldoMXP.Name = "TxtSaldoMXP";
            this.TxtSaldoMXP.Size = new System.Drawing.Size(333, 20);
            this.TxtSaldoMXP.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(68, 646);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 25);
            this.label11.TabIndex = 51;
            this.label11.Text = "SALDO MXP";
            // 
            // TxtAbono
            // 
            this.TxtAbono.Location = new System.Drawing.Point(913, 569);
            this.TxtAbono.Name = "TxtAbono";
            this.TxtAbono.Size = new System.Drawing.Size(333, 20);
            this.TxtAbono.TabIndex = 50;
            this.TxtAbono.Leave += new System.EventHandler(this.TxtAbono_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(908, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "ABONO";
            // 
            // TxtDiasVencimiento
            // 
            this.TxtDiasVencimiento.Location = new System.Drawing.Point(913, 473);
            this.TxtDiasVencimiento.Name = "TxtDiasVencimiento";
            this.TxtDiasVencimiento.Size = new System.Drawing.Size(333, 20);
            this.TxtDiasVencimiento.TabIndex = 48;
            this.TxtDiasVencimiento.Leave += new System.EventHandler(this.TxtDiasVencimiento_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(908, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "DIAS DE VENCIMIENTO";
            // 
            // TxtImporteUSD
            // 
            this.TxtImporteUSD.Enabled = false;
            this.TxtImporteUSD.Location = new System.Drawing.Point(494, 569);
            this.TxtImporteUSD.Name = "TxtImporteUSD";
            this.TxtImporteUSD.Size = new System.Drawing.Size(333, 20);
            this.TxtImporteUSD.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(489, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "IMPORTE USD";
            // 
            // TxtImporte
            // 
            this.TxtImporte.Location = new System.Drawing.Point(73, 569);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(333, 20);
            this.TxtImporte.TabIndex = 44;
            this.TxtImporte.Leave += new System.EventHandler(this.TxtImporte_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(68, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "IMPORTE MXP";
            // 
            // TxtSaldoUSD
            // 
            this.TxtSaldoUSD.Enabled = false;
            this.TxtSaldoUSD.Location = new System.Drawing.Point(494, 674);
            this.TxtSaldoUSD.Name = "TxtSaldoUSD";
            this.TxtSaldoUSD.Size = new System.Drawing.Size(333, 20);
            this.TxtSaldoUSD.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(489, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "SALDO USD";
            // 
            // TxtNombreFactura
            // 
            this.TxtNombreFactura.Location = new System.Drawing.Point(73, 473);
            this.TxtNombreFactura.Name = "TxtNombreFactura";
            this.TxtNombreFactura.Size = new System.Drawing.Size(333, 20);
            this.TxtNombreFactura.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(68, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "NOMBRE DE LA FACTURA";
            // 
            // TxtIdFactura
            // 
            this.TxtIdFactura.Enabled = false;
            this.TxtIdFactura.Location = new System.Drawing.Point(494, 298);
            this.TxtIdFactura.Name = "TxtIdFactura";
            this.TxtIdFactura.Size = new System.Drawing.Size(333, 20);
            this.TxtIdFactura.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(489, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "ID DE LA FACTURA";
            // 
            // TxtIDPro
            // 
            this.TxtIDPro.Enabled = false;
            this.TxtIDPro.Location = new System.Drawing.Point(73, 298);
            this.TxtIDPro.Name = "TxtIDPro";
            this.TxtIDPro.Size = new System.Drawing.Size(333, 20);
            this.TxtIDPro.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(68, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID DEL PROVEEDOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(479, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 59);
            this.label1.TabIndex = 33;
            this.label1.Text = "EDITAR FACTURA";
            // 
            // EditarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1573, 778);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtDolar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtSaldoMXP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtAbono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDiasVencimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtImporteUSD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtImporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSaldoUSD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombreFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtIdFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIDPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarFacturas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TxtDolar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox TxtSaldoMXP;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox TxtAbono;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TxtDiasVencimiento;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TxtImporteUSD;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtSaldoUSD;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtNombreFactura;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtIdFactura;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtIDPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}