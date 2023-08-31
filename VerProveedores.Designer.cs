namespace Cedisur
{
    partial class VerProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProveedores));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            BtnSalir = new PictureBox();
            BtnVolver = new Button();
            DGVproveedores = new DataGridView();
            BtnEditarPro = new Button();
            BtnPagar = new Button();
            BtnBuscar = new Button();
            label14 = new Label();
            TxtBusqueda = new TextBox();
            Button1 = new Button();
            Button2 = new Button();
            label1 = new Label();
            TxtBusquedaRfc = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVproveedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(BtnVolver);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1565, 63);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(618, 15);
            label2.Name = "label2";
            label2.Size = new Size(389, 29);
            label2.TabIndex = 50;
            label2.Text = "PROVEEDORES/ACREEDORES";
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
            // DGVproveedores
            // 
            DGVproveedores.AllowUserToAddRows = false;
            DGVproveedores.AllowUserToDeleteRows = false;
            DGVproveedores.AllowUserToResizeColumns = false;
            DGVproveedores.AllowUserToResizeRows = false;
            DGVproveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVproveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVproveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVproveedores.DefaultCellStyle = dataGridViewCellStyle2;
            DGVproveedores.Location = new Point(15, 216);
            DGVproveedores.Name = "DGVproveedores";
            DGVproveedores.ReadOnly = true;
            DGVproveedores.RowHeadersVisible = false;
            DGVproveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 192, 0);
            DGVproveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGVproveedores.RowTemplate.Height = 25;
            DGVproveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVproveedores.Size = new Size(1204, 550);
            DGVproveedores.TabIndex = 4;
            // 
            // BtnEditarPro
            // 
            BtnEditarPro.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEditarPro.Location = new Point(1322, 182);
            BtnEditarPro.Name = "BtnEditarPro";
            BtnEditarPro.Size = new Size(161, 67);
            BtnEditarPro.TabIndex = 7;
            BtnEditarPro.Text = "Editar datos\r\n";
            BtnEditarPro.UseVisualStyleBackColor = true;
            BtnEditarPro.Click += BtnEditarPro_Click;
            // 
            // BtnPagar
            // 
            BtnPagar.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPagar.Location = new Point(1322, 422);
            BtnPagar.Name = "BtnPagar";
            BtnPagar.Size = new Size(161, 67);
            BtnPagar.TabIndex = 6;
            BtnPagar.Text = "Generar factura";
            BtnPagar.UseVisualStyleBackColor = true;
            BtnPagar.Click += BtnPagar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscar.Location = new Point(450, 104);
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
            label14.Location = new Point(12, 104);
            label14.Name = "label14";
            label14.Size = new Size(247, 29);
            label14.TabIndex = 44;
            label14.Text = "Buscar por nombre \r\n";
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Location = new Point(15, 139);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.Size = new Size(398, 23);
            TxtBusqueda.TabIndex = 43;
            // 
            // Button1
            // 
            Button1.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Button1.Location = new Point(1322, 699);
            Button1.Name = "Button1";
            Button1.Size = new Size(161, 67);
            Button1.TabIndex = 46;
            Button1.Text = "Eliminar datos seleccionados\r\n";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // Button2
            // 
            Button2.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Button2.Location = new Point(1065, 104);
            Button2.Name = "Button2";
            Button2.Size = new Size(104, 58);
            Button2.TabIndex = 49;
            Button2.Text = "Buscar";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(627, 104);
            label1.Name = "label1";
            label1.Size = new Size(201, 29);
            label1.TabIndex = 48;
            label1.Text = "Buscar por RFC";
            // 
            // TxtBusquedaRfc
            // 
            TxtBusquedaRfc.Location = new Point(630, 139);
            TxtBusquedaRfc.Name = "TxtBusquedaRfc";
            TxtBusquedaRfc.Size = new Size(398, 23);
            TxtBusquedaRfc.TabIndex = 47;
            // 
            // VerProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1573, 778);
            Controls.Add(Button2);
            Controls.Add(label1);
            Controls.Add(TxtBusquedaRfc);
            Controls.Add(Button1);
            Controls.Add(BtnBuscar);
            Controls.Add(label14);
            Controls.Add(TxtBusqueda);
            Controls.Add(BtnEditarPro);
            Controls.Add(BtnPagar);
            Controls.Add(DGVproveedores);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerProveedores";
            Load += VerProveedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVproveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox BtnSalir;
        private Button BtnVolver;
        public DataGridView DGVproveedores;
        private Button BtnEditarPro;
        private Button BtnPagar;
        private Button BtnBuscar;
        private Label label14;
        private TextBox TxtBusqueda;
        private Button Button1;
        private Button Button2;
        private Label label1;
        private TextBox TxtBusquedaRfc;
        private Label label2;
    }
}