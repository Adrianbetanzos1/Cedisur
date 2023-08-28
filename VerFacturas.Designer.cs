namespace Cedisur
{
    partial class VerFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerFacturas));
            panel1 = new Panel();
            BtnSalir = new PictureBox();
            BtnVolver = new Button();
            DGVfacturas = new DataGridView();
            BtnPagar = new Button();
            BtnEditar = new Button();
            label14 = new Label();
            TxtBusqueda = new TextBox();
            BtnBuscar = new Button();
            BtnBuscarID = new Button();
            label1 = new Label();
            TxtBuscarID = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVfacturas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(BtnVolver);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1565, 63);
            panel1.TabIndex = 2;
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
            BtnVolver.Location = new Point(3, 3);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(96, 53);
            BtnVolver.TabIndex = 2;
            BtnVolver.Text = "Volver al menú";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // DGVfacturas
            // 
            DGVfacturas.AllowUserToAddRows = false;
            DGVfacturas.AllowUserToDeleteRows = false;
            DGVfacturas.AllowUserToResizeColumns = false;
            DGVfacturas.AllowUserToResizeRows = false;
            DGVfacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVfacturas.Location = new Point(15, 182);
            DGVfacturas.Name = "DGVfacturas";
            DGVfacturas.ReadOnly = true;
            DGVfacturas.RowTemplate.Height = 25;
            DGVfacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVfacturas.Size = new Size(1204, 584);
            DGVfacturas.TabIndex = 3;
            // 
            // BtnPagar
            // 
            BtnPagar.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPagar.Location = new Point(1333, 557);
            BtnPagar.Name = "BtnPagar";
            BtnPagar.Size = new Size(161, 67);
            BtnPagar.TabIndex = 4;
            BtnPagar.Text = "Generar pago";
            BtnPagar.UseVisualStyleBackColor = true;
            BtnPagar.Click += BtnPagar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEditar.Location = new Point(1333, 315);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(161, 67);
            BtnEditar.TabIndex = 5;
            BtnEditar.Text = "Editar datos factura";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(12, 107);
            label14.Name = "label14";
            label14.Size = new Size(241, 29);
            label14.TabIndex = 41;
            label14.Text = "Buscar por nombre";
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Location = new Point(15, 142);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.Size = new Size(398, 23);
            TxtBusqueda.TabIndex = 40;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscar.Location = new Point(450, 107);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(104, 58);
            BtnBuscar.TabIndex = 42;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnBuscarID
            // 
            BtnBuscarID.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscarID.Location = new Point(1114, 107);
            BtnBuscarID.Name = "BtnBuscarID";
            BtnBuscarID.Size = new Size(104, 58);
            BtnBuscarID.TabIndex = 45;
            BtnBuscarID.Text = "Buscar";
            BtnBuscarID.UseVisualStyleBackColor = true;
            BtnBuscarID.Click += BtnBuscarID_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(676, 107);
            label1.Name = "label1";
            label1.Size = new Size(182, 29);
            label1.TabIndex = 44;
            label1.Text = "Buscar por ID ";
            // 
            // TxtBuscarID
            // 
            TxtBuscarID.Location = new Point(679, 142);
            TxtBuscarID.Name = "TxtBuscarID";
            TxtBuscarID.Size = new Size(398, 23);
            TxtBuscarID.TabIndex = 43;
            // 
            // VerFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1589, 817);
            Controls.Add(BtnBuscarID);
            Controls.Add(label1);
            Controls.Add(TxtBuscarID);
            Controls.Add(BtnBuscar);
            Controls.Add(label14);
            Controls.Add(TxtBusqueda);
            Controls.Add(BtnEditar);
            Controls.Add(BtnPagar);
            Controls.Add(DGVfacturas);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "VerFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proveedores";
            Load += Proveedores_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVfacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox BtnSalir;
        private Button BtnVolver;
        private Button BtnPagar;
        private Button BtnEditar;
        private Label label14;
        private TextBox TxtBusqueda;
        private Button BtnBuscar;
        private Button BtnBuscarID;
        private Label label1;
        private TextBox TxtBuscarID;
        public DataGridView DGVfacturas;
    }
}