namespace Cedisur
{
    partial class VerUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerUsuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            BtnSalir = new PictureBox();
            BtnVolver = new Button();
            Button1 = new Button();
            BtnEditarPro = new Button();
            DGVusuarios = new DataGridView();
            BtnBuscar = new Button();
            label14 = new Label();
            TxtBusqueda = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVusuarios).BeginInit();
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
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(742, 15);
            label2.Name = "label2";
            label2.Size = new Size(136, 29);
            label2.TabIndex = 50;
            label2.Text = "USUARIOS";
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
            // Button1
            // 
            Button1.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Button1.Location = new Point(1322, 422);
            Button1.Name = "Button1";
            Button1.Size = new Size(161, 67);
            Button1.TabIndex = 50;
            Button1.Text = "Eliminar datos seleccionados\r\n";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // BtnEditarPro
            // 
            BtnEditarPro.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEditarPro.Location = new Point(1322, 182);
            BtnEditarPro.Name = "BtnEditarPro";
            BtnEditarPro.Size = new Size(161, 67);
            BtnEditarPro.TabIndex = 49;
            BtnEditarPro.Text = "Editar datos\r\n";
            BtnEditarPro.UseVisualStyleBackColor = true;
            BtnEditarPro.Click += BtnEditarPro_Click;
            // 
            // DGVusuarios
            // 
            DGVusuarios.AllowUserToAddRows = false;
            DGVusuarios.AllowUserToDeleteRows = false;
            DGVusuarios.AllowUserToResizeColumns = false;
            DGVusuarios.AllowUserToResizeRows = false;
            DGVusuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVusuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVusuarios.DefaultCellStyle = dataGridViewCellStyle2;
            DGVusuarios.Location = new Point(15, 216);
            DGVusuarios.Name = "DGVusuarios";
            DGVusuarios.ReadOnly = true;
            DGVusuarios.RowHeadersVisible = false;
            DGVusuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 192, 0);
            DGVusuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGVusuarios.RowTemplate.Height = 25;
            DGVusuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVusuarios.Size = new Size(1204, 550);
            DGVusuarios.TabIndex = 47;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscar.Location = new Point(453, 114);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(104, 58);
            BtnBuscar.TabIndex = 53;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(688, 114);
            label14.Name = "label14";
            label14.Size = new Size(0, 29);
            label14.TabIndex = 70;
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Location = new Point(18, 149);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.Size = new Size(398, 23);
            TxtBusqueda.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(18, 114);
            label1.Name = "label1";
            label1.Size = new Size(358, 29);
            label1.TabIndex = 71;
            label1.Text = "Buscar por nombre completo";
            // 
            // VerUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1573, 778);
            Controls.Add(label1);
            Controls.Add(BtnBuscar);
            Controls.Add(label14);
            Controls.Add(TxtBusqueda);
            Controls.Add(Button1);
            Controls.Add(BtnEditarPro);
            Controls.Add(DGVusuarios);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerUsuarios";
            Load += VerUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVusuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox BtnSalir;
        private Button BtnVolver;
        private Button Button1;
        private Button BtnEditarPro;
        public DataGridView DGVusuarios;
        private Button BtnBuscar;
        private Label label14;
        private TextBox TxtBusqueda;
        private Label label1;
    }
}