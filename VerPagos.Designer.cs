namespace Cedisur
{
    partial class VerPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPagos));
            panel1 = new Panel();
            BtnSalir = new PictureBox();
            BtnVolver = new Button();
            DGVpagos = new DataGridView();
            BtnBuscar = new Button();
            label14 = new Label();
            TxtBusqueda = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVpagos).BeginInit();
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
            panel1.TabIndex = 3;
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
            // DGVpagos
            // 
            DGVpagos.AllowUserToAddRows = false;
            DGVpagos.AllowUserToDeleteRows = false;
            DGVpagos.AllowUserToResizeColumns = false;
            DGVpagos.AllowUserToResizeRows = false;
            DGVpagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVpagos.Location = new Point(12, 182);
            DGVpagos.Name = "DGVpagos";
            DGVpagos.ReadOnly = true;
            DGVpagos.RowTemplate.Height = 25;
            DGVpagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVpagos.Size = new Size(1204, 584);
            DGVpagos.TabIndex = 4;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscar.Location = new Point(453, 98);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(104, 58);
            BtnBuscar.TabIndex = 45;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(15, 98);
            label14.Name = "label14";
            label14.Size = new Size(340, 29);
            label14.TabIndex = 44;
            label14.Text = "Buscar por número de pago";
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Location = new Point(18, 133);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.Size = new Size(398, 23);
            TxtBusqueda.TabIndex = 43;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1307, 250);
            button1.Name = "button1";
            button1.Size = new Size(125, 74);
            button1.TabIndex = 46;
            button1.Text = "Editar datos del pago";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VerPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1589, 817);
            Controls.Add(button1);
            Controls.Add(BtnBuscar);
            Controls.Add(label14);
            Controls.Add(TxtBusqueda);
            Controls.Add(DGVpagos);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturas";
            Load += Facturas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVpagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox BtnSalir;
        private Button BtnVolver;
        private Button BtnBuscar;
        private Label label14;
        private TextBox TxtBusqueda;
        public DataGridView DGVpagos;
        private Button button1;
    }
}