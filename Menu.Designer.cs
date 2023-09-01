namespace Cedisur
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            BtnCerrarSesion = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            LblPosicion = new Label();
            LblNombre = new Label();
            BtnUsuarios = new Button();
            BtnPagos = new Button();
            button1 = new Button();
            BtnProveedores = new Button();
            BtnSalir = new PictureBox();
            SubmenuPro = new Panel();
            BtnAgregar = new Button();
            BtnTodos = new Button();
            SubMenuFac = new Panel();
            BtnTodosFac = new Button();
            SubmenuPagos = new Panel();
            button2 = new Button();
            label2 = new Label();
            SubmenuUsuarios = new Panel();
            button3 = new Button();
            BtnAgregarNuevoU = new Button();
            ((System.ComponentModel.ISupportInitialize)BtnCerrarSesion).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            SubmenuPro.SuspendLayout();
            SubMenuFac.SuspendLayout();
            SubmenuPagos.SuspendLayout();
            SubmenuUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.Image = (Image)resources.GetObject("BtnCerrarSesion.Image");
            BtnCerrarSesion.Location = new Point(14, 29);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(29, 27);
            BtnCerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            BtnCerrarSesion.TabIndex = 1;
            BtnCerrarSesion.TabStop = false;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LblPosicion);
            panel1.Controls.Add(LblNombre);
            panel1.Controls.Add(BtnUsuarios);
            panel1.Controls.Add(BtnPagos);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnProveedores);
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(BtnCerrarSesion);
            panel1.Location = new Point(8, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1437, 77);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // LblPosicion
            // 
            LblPosicion.AutoSize = true;
            LblPosicion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblPosicion.ForeColor = SystemColors.ActiveCaptionText;
            LblPosicion.Location = new Point(119, 35);
            LblPosicion.Name = "LblPosicion";
            LblPosicion.Size = new Size(75, 21);
            LblPosicion.TabIndex = 13;
            LblPosicion.Text = "Posición";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblNombre.ForeColor = SystemColors.ActiveCaptionText;
            LblNombre.Location = new Point(121, 14);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(73, 21);
            LblNombre.TabIndex = 12;
            LblNombre.Text = "Nombre";
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = SystemColors.AppWorkspace;
            BtnUsuarios.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUsuarios.ForeColor = Color.Black;
            BtnUsuarios.Location = new Point(1182, 0);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(183, 77);
            BtnUsuarios.TabIndex = 7;
            BtnUsuarios.Text = "Usuarios";
            BtnUsuarios.UseVisualStyleBackColor = false;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // BtnPagos
            // 
            BtnPagos.BackColor = SystemColors.AppWorkspace;
            BtnPagos.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPagos.ForeColor = Color.Black;
            BtnPagos.Location = new Point(932, 0);
            BtnPagos.Name = "BtnPagos";
            BtnPagos.Size = new Size(183, 77);
            BtnPagos.TabIndex = 6;
            BtnPagos.Text = "Pagos";
            BtnPagos.UseVisualStyleBackColor = false;
            BtnPagos.Click += BtnPagos_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(698, 0);
            button1.Name = "button1";
            button1.Size = new Size(183, 77);
            button1.TabIndex = 5;
            button1.Text = "Facturas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // BtnProveedores
            // 
            BtnProveedores.BackColor = SystemColors.AppWorkspace;
            BtnProveedores.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnProveedores.ForeColor = Color.Black;
            BtnProveedores.Location = new Point(459, 0);
            BtnProveedores.Name = "BtnProveedores";
            BtnProveedores.Size = new Size(183, 77);
            BtnProveedores.TabIndex = 4;
            BtnProveedores.Text = "Proveedores";
            BtnProveedores.UseVisualStyleBackColor = false;
            BtnProveedores.Click += BtnProveedores_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(1388, 29);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(29, 27);
            BtnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSalir.TabIndex = 2;
            BtnSalir.TabStop = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // SubmenuPro
            // 
            SubmenuPro.BackColor = SystemColors.AppWorkspace;
            SubmenuPro.Controls.Add(BtnAgregar);
            SubmenuPro.Controls.Add(BtnTodos);
            SubmenuPro.Location = new Point(467, 72);
            SubmenuPro.Name = "SubmenuPro";
            SubmenuPro.Size = new Size(183, 121);
            SubmenuPro.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = SystemColors.AppWorkspace;
            BtnAgregar.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.ForeColor = Color.Black;
            BtnAgregar.Location = new Point(0, 0);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(183, 51);
            BtnAgregar.TabIndex = 5;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnTodos
            // 
            BtnTodos.BackColor = SystemColors.AppWorkspace;
            BtnTodos.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTodos.ForeColor = Color.Black;
            BtnTodos.Location = new Point(0, 71);
            BtnTodos.Name = "BtnTodos";
            BtnTodos.Size = new Size(183, 51);
            BtnTodos.TabIndex = 8;
            BtnTodos.Text = "Ver todos";
            BtnTodos.UseVisualStyleBackColor = false;
            BtnTodos.Click += BtnTodos_Click;
            // 
            // SubMenuFac
            // 
            SubMenuFac.BackColor = SystemColors.AppWorkspace;
            SubMenuFac.Controls.Add(BtnTodosFac);
            SubMenuFac.Location = new Point(706, 73);
            SubMenuFac.Name = "SubMenuFac";
            SubMenuFac.Size = new Size(183, 121);
            SubMenuFac.TabIndex = 9;
            // 
            // BtnTodosFac
            // 
            BtnTodosFac.BackColor = SystemColors.AppWorkspace;
            BtnTodosFac.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTodosFac.ForeColor = Color.Black;
            BtnTodosFac.Location = new Point(0, -1);
            BtnTodosFac.Name = "BtnTodosFac";
            BtnTodosFac.Size = new Size(183, 51);
            BtnTodosFac.TabIndex = 8;
            BtnTodosFac.Text = "Ver todas";
            BtnTodosFac.UseVisualStyleBackColor = false;
            BtnTodosFac.Click += BtnTodosFac_Click;
            // 
            // SubmenuPagos
            // 
            SubmenuPagos.BackColor = SystemColors.AppWorkspace;
            SubmenuPagos.Controls.Add(button2);
            SubmenuPagos.Location = new Point(940, 73);
            SubmenuPagos.Name = "SubmenuPagos";
            SubmenuPagos.Size = new Size(183, 121);
            SubmenuPagos.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(0, -1);
            button2.Name = "button2";
            button2.Size = new Size(183, 51);
            button2.TabIndex = 8;
            button2.Text = "Ver todos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(547, 341);
            label2.Name = "label2";
            label2.Size = new Size(330, 40);
            label2.TabIndex = 0;
            label2.Text = "BIENVENIDO AL MENU";
            // 
            // SubmenuUsuarios
            // 
            SubmenuUsuarios.BackColor = SystemColors.AppWorkspace;
            SubmenuUsuarios.Controls.Add(button3);
            SubmenuUsuarios.Controls.Add(BtnAgregarNuevoU);
            SubmenuUsuarios.Location = new Point(1190, 73);
            SubmenuUsuarios.Name = "SubmenuUsuarios";
            SubmenuUsuarios.Size = new Size(183, 121);
            SubmenuUsuarios.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(0, 70);
            button3.Name = "button3";
            button3.Size = new Size(183, 51);
            button3.TabIndex = 9;
            button3.Text = "Ver todos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // BtnAgregarNuevoU
            // 
            BtnAgregarNuevoU.BackColor = SystemColors.AppWorkspace;
            BtnAgregarNuevoU.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregarNuevoU.ForeColor = Color.Black;
            BtnAgregarNuevoU.Location = new Point(0, -1);
            BtnAgregarNuevoU.Name = "BtnAgregarNuevoU";
            BtnAgregarNuevoU.Size = new Size(183, 51);
            BtnAgregarNuevoU.TabIndex = 8;
            BtnAgregarNuevoU.Text = "Agregar";
            BtnAgregarNuevoU.UseVisualStyleBackColor = false;
            BtnAgregarNuevoU.Click += BtnAgregarNuevoU_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1457, 670);
            Controls.Add(SubmenuUsuarios);
            Controls.Add(SubmenuPagos);
            Controls.Add(SubMenuFac);
            Controls.Add(SubmenuPro);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)BtnCerrarSesion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            SubmenuPro.ResumeLayout(false);
            SubMenuFac.ResumeLayout(false);
            SubmenuPagos.ResumeLayout(false);
            SubmenuUsuarios.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox BtnCerrarSesion;
        private Panel panel1;
        private PictureBox BtnSalir;
        private Button BtnProveedores;
        private Panel SubmenuPro;
        private Button BtnTodos;
        private Button BtnAgregar;
        private Panel SubMenuFac;
        private Button BtnTodosFac;
        private Button button1;
        private Button BtnPagos;
        private Panel SubmenuPagos;
        private Button button2;
        private Label label2;
        private Button BtnUsuarios;
        private Panel SubmenuUsuarios;
        private Button BtnAgregarNuevoU;
        private Button button3;
        private Label LblNombre;
        private Label LblPosicion;
        private PictureBox pictureBox1;
    }
}