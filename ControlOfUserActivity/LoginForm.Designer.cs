namespace ControlOfUserActivity
{
    partial class LoginForm
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
            this.lblIP = new ControlOfUserActivity.GrowLabel();
            this.lblLogin = new ControlOfUserActivity.GrowLabel();
            this.lblPassword = new ControlOfUserActivity.GrowLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.gbLoginForm = new System.Windows.Forms.GroupBox();
            this.txtIP = new ControlOfUserActivity.WaterMarkTextBox();
            this.txtLogin = new ControlOfUserActivity.WaterMarkTextBox();
            this.txtPassword = new ControlOfUserActivity.WaterMarkTextBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.gbLoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(43, 22);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(17, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(22, 48);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 74);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Пароль";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(137, 147);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Вход";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // gbLoginForm
            // 
            this.gbLoginForm.Controls.Add(this.txtIP);
            this.gbLoginForm.Controls.Add(this.txtLogin);
            this.gbLoginForm.Controls.Add(this.txtPassword);
            this.gbLoginForm.Controls.Add(this.lblIP);
            this.gbLoginForm.Controls.Add(this.lblPassword);
            this.gbLoginForm.Controls.Add(this.lblLogin);
            this.gbLoginForm.Location = new System.Drawing.Point(12, 41);
            this.gbLoginForm.Name = "gbLoginForm";
            this.gbLoginForm.Size = new System.Drawing.Size(200, 100);
            this.gbLoginForm.TabIndex = 8;
            this.gbLoginForm.TabStop = false;
            this.gbLoginForm.Text = "Введите данные";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIP.Location = new System.Drawing.Point(79, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtIP.WaterMarkText = "127.0.0.1";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtLogin.Location = new System.Drawing.Point(79, 45);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtLogin.WaterMarkText = "Ivan";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPassword.Location = new System.Drawing.Point(79, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPassword.WaterMarkText = "********";
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(125, 12);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(87, 23);
            this.btnRegistration.TabIndex = 9;
            this.btnRegistration.Text = "Регистрация";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 188);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.gbLoginForm);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.MaximumSize = new System.Drawing.Size(240, 227);
            this.MinimumSize = new System.Drawing.Size(240, 227);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.gbLoginForm.ResumeLayout(false);
            this.gbLoginForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GrowLabel lblIP;
        private GrowLabel lblLogin;
        private GrowLabel lblPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.GroupBox gbLoginForm;
        private WaterMarkTextBox txtIP;
        private WaterMarkTextBox txtLogin;
        private WaterMarkTextBox txtPassword;
        private System.Windows.Forms.Button btnRegistration;
    }
}