using System.DirectoryServices;

namespace Cedisur
{
    partial class InicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            userTxt = new TextBox();
            passTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnAceptar = new Herramientas.ButtonA();
            Lbl1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            PictureBox3 = new PictureBox();
            PictureBox2 = new PictureBox();
            LblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // userTxt
            // 
            userTxt.Location = new Point(38, 251);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(350, 23);
            userTxt.TabIndex = 0;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(38, 315);
            passTxt.Name = "passTxt";
            passTxt.PasswordChar = '*';
            passTxt.Size = new Size(350, 23);
            passTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(38, 291);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 2;
            label1.Text = "CONTRASEÑA";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(38, 227);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 3;
            label2.Text = "USUARIO";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackColor = Color.DarkSlateGray;
            BtnAceptar.FlatAppearance.BorderSize = 0;
            BtnAceptar.FlatStyle = FlatStyle.Flat;
            BtnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAceptar.ForeColor = Color.White;
            BtnAceptar.Location = new Point(38, 455);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(350, 50);
            BtnAceptar.TabIndex = 7;
            BtnAceptar.Text = "INICIAR SESIÓN";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += Buttona1_Click;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.BackColor = Color.Transparent;
            Lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl1.ForeColor = Color.Transparent;
            Lbl1.Location = new Point(135, 624);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(177, 21);
            Lbl1.TabIndex = 8;
            Lbl1.Text = "Olvidó su contraseña?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(41, 609);
            label3.Name = "label3";
            label3.Size = new Size(347, 15);
            label3.TabIndex = 9;
            label3.Text = "____________________________________________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(83, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(PictureBox3);
            panel1.Controls.Add(PictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 33);
            panel1.TabIndex = 11;
            // 
            // PictureBox3
            // 
            PictureBox3.Image = (Image)resources.GetObject("PictureBox3.Image");
            PictureBox3.Location = new Point(399, 0);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(28, 33);
            PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox3.TabIndex = 13;
            PictureBox3.TabStop = false;
            PictureBox3.Click += PictureBox3_Click;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = (Image)resources.GetObject("PictureBox2.Image");
            PictureBox2.Location = new Point(368, 0);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(28, 33);
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox2.TabIndex = 12;
            PictureBox2.TabStop = false;
            PictureBox2.Click += PictureBox2_Click;
            // 
            // LblError
            // 
            LblError.AutoSize = true;
            LblError.ForeColor = SystemColors.ButtonFace;
            LblError.Location = new Point(39, 370);
            LblError.Name = "LblError";
            LblError.Size = new Size(144, 15);
            LblError.TabIndex = 12;
            LblError.Text = "Introduzca los parametros";
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(430, 680);
            Controls.Add(LblError);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(Lbl1);
            Controls.Add(BtnAceptar);
            Controls.Add(passTxt);
            Controls.Add(label2);
            Controls.Add(userTxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTxt;
        private TextBox passTxt;
        private Label label1;
        private Label label2;
        private Herramientas.ButtonA BtnAceptar;
        private Label Lbl1;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox PictureBox3;
        private PictureBox PictureBox2;
        private Label LblError;


    }
}