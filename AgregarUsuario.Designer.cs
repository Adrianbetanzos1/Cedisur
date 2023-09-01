namespace Cedisur
{
    partial class AgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            panel1 = new Panel();
            BtnSalir = new PictureBox();
            BtnVolver = new Button();
            label1 = new Label();
            label6 = new Label();
            CbTipoAutorizacion = new CheckedListBox();
            label5 = new Label();
            TxtContraseña = new TextBox();
            label3 = new Label();
            TxtNombre = new TextBox();
            label2 = new Label();
            TxtNombreCompleto = new TextBox();
            BtnAgregar = new Button();
            label4 = new Label();
            TxtConfirmar = new TextBox();
            label7 = new Label();
            TxtEmail = new TextBox();
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
            panel1.Size = new Size(1549, 67);
            panel1.TabIndex = 3;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(1502, 16);
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
            BtnVolver.Size = new Size(96, 53);
            BtnVolver.TabIndex = 2;
            BtnVolver.Text = "Volver al menú";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(601, 129);
            label1.Name = "label1";
            label1.Size = new Size(336, 39);
            label1.TabIndex = 28;
            label1.Text = "AGREGAR USUARIO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(912, 449);
            label6.Name = "label6";
            label6.Size = new Size(295, 25);
            label6.TabIndex = 50;
            label6.Text = "Tipo de permisos otorgados";
            // 
            // CbTipoAutorizacion
            // 
            CbTipoAutorizacion.FormattingEnabled = true;
            CbTipoAutorizacion.Items.AddRange(new object[] { "Administrador", "Usuario" });
            CbTipoAutorizacion.Location = new Point(984, 491);
            CbTipoAutorizacion.Name = "CbTipoAutorizacion";
            CbTipoAutorizacion.Size = new Size(129, 40);
            CbTipoAutorizacion.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(153, 475);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 48;
            label5.Text = "Contraseña";
            // 
            // TxtContraseña
            // 
            TxtContraseña.Location = new Point(153, 503);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.Size = new Size(316, 23);
            TxtContraseña.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(524, 301);
            label3.Name = "label3";
            label3.Size = new Size(208, 25);
            label3.TabIndex = 46;
            label3.Text = "Nombre de usuario";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(525, 329);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(308, 23);
            TxtNombre.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(153, 301);
            label2.Name = "label2";
            label2.Size = new Size(316, 25);
            label2.TabIndex = 44;
            label2.Text = "Nombre completo del usuario";
            // 
            // TxtNombreCompleto
            // 
            TxtNombreCompleto.Location = new Point(153, 329);
            TxtNombreCompleto.Name = "TxtNombreCompleto";
            TxtNombreCompleto.Size = new Size(316, 23);
            TxtNombreCompleto.TabIndex = 43;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = SystemColors.AppWorkspace;
            BtnAgregar.Font = new Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.Location = new Point(421, 662);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(121, 59);
            BtnAgregar.TabIndex = 51;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(524, 475);
            label4.Name = "label4";
            label4.Size = new Size(236, 25);
            label4.TabIndex = 53;
            label4.Text = "Confirmar contraseña";
            // 
            // TxtConfirmar
            // 
            TxtConfirmar.Location = new Point(525, 503);
            TxtConfirmar.Name = "TxtConfirmar";
            TxtConfirmar.Size = new Size(308, 23);
            TxtConfirmar.TabIndex = 52;
            TxtConfirmar.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(898, 301);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 55;
            label7.Text = "Email";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(899, 329);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(308, 23);
            TxtEmail.TabIndex = 54;
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1573, 778);
            Controls.Add(label7);
            Controls.Add(TxtEmail);
            Controls.Add(label4);
            Controls.Add(TxtConfirmar);
            Controls.Add(BtnAgregar);
            Controls.Add(label6);
            Controls.Add(CbTipoAutorizacion);
            Controls.Add(label5);
            Controls.Add(TxtContraseña);
            Controls.Add(label3);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(TxtNombreCompleto);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "s";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox BtnSalir;
        private Button BtnVolver;
        private Label label1;
        private Label label6;
        private CheckedListBox CbTipoAutorizacion;
        private Label label5;
        private TextBox TxtContraseña;
        private Label label3;
        private TextBox TxtNombre;
        private Label label2;
        private TextBox TxtNombreCompleto;
        private Button BtnAgregar;
        private Label label4;
        private TextBox TxtConfirmar;
        private Label label7;
        private TextBox TxtEmail;
    }
}