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
            label1 = new Label();
            textBox1 = new TextBox();
            textPassword = new TextBox();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 116);
            label1.Name = "label1";
            label1.Size = new Size(176, 42);
            label1.TabIndex = 1;
            label1.Text = "LOGION";
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(305, 323);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Mostrar";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 462);
            Controls.Add(checkBox1);
            Controls.Add(textPassword);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCerrar;
        private Label label1;
        private TextBox textBox1;
        private TextBox textPassword;
        private CheckBox checkBox1;
    }
}