namespace login_J
{
    partial class Form1
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
            panel1 = new Panel();
            btnCerrar = new Button();
            textBox1 = new TextBox();
            textPassword = new TextBox();
            Muestra = new CheckBox();
            Entrar = new Button();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 43);
            panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.Red;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(499, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(156, 195);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 30);
            textBox1.TabIndex = 2;
            textBox1.Text = "Ingrese su Usuaio";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textPassword
            // 
            textPassword.BorderStyle = BorderStyle.FixedSingle;
            textPassword.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(156, 267);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(216, 30);
            textPassword.TabIndex = 3;
            textPassword.Text = "Ingrese su Contraseña";
            textPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // Muestra
            // 
            Muestra.AutoSize = true;
            Muestra.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Muestra.Location = new Point(303, 318);
            Muestra.Name = "Muestra";
            Muestra.Size = new Size(69, 20);
            Muestra.TabIndex = 4;
            Muestra.Text = "Mostrar";
            Muestra.UseVisualStyleBackColor = true;
            // 
            // Entrar
            // 
            Entrar.BackColor = Color.DodgerBlue;
            Entrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Entrar.ForeColor = Color.White;
            Entrar.Location = new Point(212, 353);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(99, 36);
            Entrar.TabIndex = 5;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = false;
            Entrar.Click += Entrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(197, 404);
            label2.Name = "label2";
            label2.Size = new Size(137, 17);
            label2.TabIndex = 6;
            label2.Text = "¿No estas registrado?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(212, 435);
            button1.Name = "button1";
            button1.Size = new Size(99, 33);
            button1.TabIndex = 7;
            button1.Text = "Registrarse";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.segundo;
            pictureBox1.Location = new Point(197, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(541, 480);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Entrar);
            Controls.Add(Muestra);
            Controls.Add(textPassword);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCerrar;
        private TextBox textBox1;
        private TextBox textPassword;
        private CheckBox Muestra;
        private Button Entrar;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}