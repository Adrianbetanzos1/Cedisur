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
            label1 = new Label();
            BtnCerrarSesion = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            BtnProveedores = new Button();
            BtnSalir = new PictureBox();
            SubmenuPro = new Panel();
            BtnTodos = new Button();
            BtnAgregar = new Button();
            SubMenuFac = new Panel();
            BtnTodosFac = new Button();
            ((System.ComponentModel.ISupportInitialize)BtnCerrarSesion).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            SubmenuPro.SuspendLayout();
            SubMenuFac.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 5);
            label1.Name = "label1";
            label1.Size = new Size(276, 32);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO AL MENU";
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.Image = (Image)resources.GetObject("BtnCerrarSesion.Image");
            BtnCerrarSesion.Location = new Point(4, 5);
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnProveedores);
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(BtnCerrarSesion);
            panel1.Location = new Point(8, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 43);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(315, 0);
            button1.Name = "button1";
            button1.Size = new Size(183, 44);
            button1.TabIndex = 5;
            button1.Text = "Facturas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtnProveedores
            // 
            BtnProveedores.BackColor = SystemColors.AppWorkspace;
            BtnProveedores.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnProveedores.ForeColor = Color.Black;
            BtnProveedores.Location = new Point(76, 0);
            BtnProveedores.Name = "BtnProveedores";
            BtnProveedores.Size = new Size(183, 44);
            BtnProveedores.TabIndex = 4;
            BtnProveedores.Text = "Proveedores";
            BtnProveedores.UseVisualStyleBackColor = false;
            BtnProveedores.Click += BtnProveedores_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(1015, 5);
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
            SubmenuPro.Controls.Add(BtnTodos);
            SubmenuPro.Controls.Add(BtnAgregar);
            SubmenuPro.Location = new Point(84, 53);
            SubmenuPro.Name = "SubmenuPro";
            SubmenuPro.Size = new Size(183, 122);
            SubmenuPro.TabIndex = 3;
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
            // SubMenuFac
            // 
            SubMenuFac.BackColor = SystemColors.AppWorkspace;
            SubMenuFac.Controls.Add(BtnTodosFac);
            SubMenuFac.Controls.Add(label1);
            SubMenuFac.Location = new Point(323, 54);
            SubMenuFac.Name = "SubMenuFac";
            SubMenuFac.Size = new Size(183, 121);
            SubMenuFac.TabIndex = 9;
            // 
            // BtnTodosFac
            // 
            BtnTodosFac.BackColor = SystemColors.AppWorkspace;
            BtnTodosFac.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTodosFac.ForeColor = Color.Black;
            BtnTodosFac.Location = new Point(0, 0);
            BtnTodosFac.Name = "BtnTodosFac";
            BtnTodosFac.Size = new Size(183, 51);
            BtnTodosFac.TabIndex = 8;
            BtnTodosFac.Text = "Ver todas";
            BtnTodosFac.UseVisualStyleBackColor = false;
            BtnTodosFac.Click += BtnTodosFac_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1067, 670);
            Controls.Add(SubMenuFac);
            Controls.Add(SubmenuPro);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)BtnCerrarSesion).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            SubmenuPro.ResumeLayout(false);
            SubMenuFac.ResumeLayout(false);
            SubMenuFac.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
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
    }
}