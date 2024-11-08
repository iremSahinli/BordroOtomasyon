namespace BordroOtomasyon.UI
{
    partial class LoginPanel
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
            grpxLogin = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            btnGiris = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            grpxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grpxLogin
            // 
            grpxLogin.BackColor = SystemColors.ActiveCaption;
            grpxLogin.Controls.Add(label2);
            grpxLogin.Controls.Add(label1);
            grpxLogin.Controls.Add(btnGiris);
            grpxLogin.Controls.Add(txtPassword);
            grpxLogin.Controls.Add(txtEmail);
            grpxLogin.Location = new Point(86, 41);
            grpxLogin.Margin = new Padding(4);
            grpxLogin.Name = "grpxLogin";
            grpxLogin.Padding = new Padding(4);
            grpxLogin.Size = new Size(409, 539);
            grpxLogin.TabIndex = 0;
            grpxLogin.TabStop = false;
            grpxLogin.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 175);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 106);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 4;
            label1.Text = "Email:";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(122, 312);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(170, 46);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Login";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(122, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Şifrenizi Giriniz";
            txtPassword.Size = new Size(217, 29);
            txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email Giriniz";
            txtEmail.Size = new Size(217, 29);
            txtEmail.TabIndex = 2;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1675, 858);
            Controls.Add(grpxLogin);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "LoginPanel";
            Text = "LoginPanel";
            Load += LoginPanel_Load;
            grpxLogin.ResumeLayout(false);
            grpxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpxLogin;
        private Button btnGiris;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
    }
}