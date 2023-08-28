namespace Cedisur
{
    partial class EditarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProveedor));
            label1 = new Label();
            BtnAgregar = new Button();
            label4 = new Label();
            DTPFecha = new DateTimePicker();
            label3 = new Label();
            TxtNombreProv = new TextBox();
            label2 = new Label();
            TxtIDProveedor = new TextBox();
            panel1 = new Panel();
            BtnSalir = new PictureBox();
            BtnVolver = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(492, 125);
            label1.Name = "label1";
            label1.Size = new Size(561, 39);
            label1.TabIndex = 36;
            label1.Text = "EDITAR DATOS DEL PROVEEDOR";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = SystemColors.AppWorkspace;
            BtnAgregar.Font = new Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.Location = new Point(670, 498);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(121, 59);
            BtnAgregar.TabIndex = 35;
            BtnAgregar.Text = "Editar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(1057, 291);
            label4.Name = "label4";
            label4.Size = new Size(190, 25);
            label4.TabIndex = 34;
            label4.Text = "Fecha de registro";
            // 
            // DTPFecha
            // 
            DTPFecha.Location = new Point(1057, 319);
            DTPFecha.Name = "DTPFecha";
            DTPFecha.Size = new Size(229, 23);
            DTPFecha.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(549, 291);
            label3.Name = "label3";
            label3.Size = new Size(242, 25);
            label3.TabIndex = 32;
            label3.Text = "Nombre del proveedor";
            // 
            // TxtNombreProv
            // 
            TxtNombreProv.Location = new Point(550, 319);
            TxtNombreProv.Name = "TxtNombreProv";
            TxtNombreProv.Size = new Size(308, 23);
            TxtNombreProv.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(104, 291);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 30;
            label2.Text = "ID del proveedor";
            // 
            // TxtIDProveedor
            // 
            TxtIDProveedor.Enabled = false;
            TxtIDProveedor.Location = new Point(104, 319);
            TxtIDProveedor.Name = "TxtIDProveedor";
            TxtIDProveedor.Size = new Size(268, 23);
            TxtIDProveedor.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(BtnVolver);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1444, 67);
            panel1.TabIndex = 28;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(1361, 21);
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
            BtnVolver.Location = new Point(12, 3);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(141, 53);
            BtnVolver.TabIndex = 2;
            BtnVolver.Text = "Volver a la ventana anterior";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // EditarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1573, 778);
            Controls.Add(label1);
            Controls.Add(BtnAgregar);
            Controls.Add(label4);
            Controls.Add(DTPFecha);
            Controls.Add(label3);
            Controls.Add(TxtNombreProv);
            Controls.Add(label2);
            Controls.Add(TxtIDProveedor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarProveedor";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnAgregar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private PictureBox BtnSalir;
        private Button BtnVolver;
        public DateTimePicker DTPFecha;
        public TextBox TxtNombreProv;
        public TextBox TxtIDProveedor;
    }
}