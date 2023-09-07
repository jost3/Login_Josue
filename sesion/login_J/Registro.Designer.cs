namespace login_J
{
    partial class Registro
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
            panel1 = new Panel();
            btnCerrar1 = new Button();
            textBoxuser1 = new TextBox();
            textPassword1 = new TextBox();
            labelUsuar = new Label();
            labelContra = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnCerrar1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 45);
            panel1.TabIndex = 0;
            // 
            // btnCerrar1
            // 
            btnCerrar1.BackColor = Color.Red;
            btnCerrar1.ForeColor = Color.White;
            btnCerrar1.Location = new Point(420, 12);
            btnCerrar1.Name = "btnCerrar1";
            btnCerrar1.Size = new Size(28, 23);
            btnCerrar1.TabIndex = 1;
            btnCerrar1.Text = "X";
            btnCerrar1.UseVisualStyleBackColor = false;
            // 
            // textBoxuser1
            // 
            textBoxuser1.Location = new Point(145, 108);
            textBoxuser1.Multiline = true;
            textBoxuser1.Name = "textBoxuser1";
            textBoxuser1.Size = new Size(173, 33);
            textBoxuser1.TabIndex = 1;
            // 
            // textPassword1
            // 
            textPassword1.Location = new Point(145, 185);
            textPassword1.Multiline = true;
            textPassword1.Name = "textPassword1";
            textPassword1.Size = new Size(173, 33);
            textPassword1.TabIndex = 2;
            // 
            // labelUsuar
            // 
            labelUsuar.AutoSize = true;
            labelUsuar.BackColor = Color.White;
            labelUsuar.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuar.Location = new Point(84, 110);
            labelUsuar.Name = "labelUsuar";
            labelUsuar.Size = new Size(55, 17);
            labelUsuar.TabIndex = 3;
            labelUsuar.Text = "Usuario";
            // 
            // labelContra
            // 
            labelContra.AutoSize = true;
            labelContra.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelContra.Location = new Point(61, 187);
            labelContra.Name = "labelContra";
            labelContra.Size = new Size(78, 17);
            labelContra.TabIndex = 4;
            labelContra.Text = "Contraseña";
            labelContra.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(163, 259);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 5;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 330);
            Controls.Add(button1);
            Controls.Add(labelContra);
            Controls.Add(labelUsuar);
            Controls.Add(textPassword1);
            Controls.Add(textBoxuser1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            Text = "Registro";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCerrar1;
        private TextBox textBoxuser1;
        private TextBox textPassword1;
        private Label labelUsuar;
        private Label labelContra;
        private Button button1;
    }
}