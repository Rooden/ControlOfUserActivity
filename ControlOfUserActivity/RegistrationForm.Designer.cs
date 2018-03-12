namespace ControlOfUserActivity
{
    partial class RegistrationForm
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
            this.gbLoginForm = new System.Windows.Forms.GroupBox();
            this.chkbAdmin = new System.Windows.Forms.CheckBox();
            this.txtName = new ControlOfUserActivity.WaterMarkTextBox();
            this.txtSurname = new ControlOfUserActivity.WaterMarkTextBox();
            this.growLabel1 = new ControlOfUserActivity.GrowLabel();
            this.growLabel2 = new ControlOfUserActivity.GrowLabel();
            this.txtLogin = new ControlOfUserActivity.WaterMarkTextBox();
            this.txtPassword = new ControlOfUserActivity.WaterMarkTextBox();
            this.lblPassword = new ControlOfUserActivity.GrowLabel();
            this.lblLogin = new ControlOfUserActivity.GrowLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbLoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLoginForm
            // 
            this.gbLoginForm.Controls.Add(this.chkbAdmin);
            this.gbLoginForm.Controls.Add(this.txtName);
            this.gbLoginForm.Controls.Add(this.txtSurname);
            this.gbLoginForm.Controls.Add(this.growLabel1);
            this.gbLoginForm.Controls.Add(this.growLabel2);
            this.gbLoginForm.Controls.Add(this.txtLogin);
            this.gbLoginForm.Controls.Add(this.txtPassword);
            this.gbLoginForm.Controls.Add(this.lblPassword);
            this.gbLoginForm.Controls.Add(this.lblLogin);
            this.gbLoginForm.Location = new System.Drawing.Point(12, 12);
            this.gbLoginForm.Name = "gbLoginForm";
            this.gbLoginForm.Size = new System.Drawing.Size(200, 169);
            this.gbLoginForm.TabIndex = 11;
            this.gbLoginForm.TabStop = false;
            this.gbLoginForm.Text = "Введите данные";
            // 
            // chkbAdmin
            // 
            this.chkbAdmin.AutoSize = true;
            this.chkbAdmin.Location = new System.Drawing.Point(80, 146);
            this.chkbAdmin.Name = "chkbAdmin";
            this.chkbAdmin.Size = new System.Drawing.Size(59, 17);
            this.chkbAdmin.TabIndex = 4;
            this.chkbAdmin.Text = "Админ";
            this.chkbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtName.Location = new System.Drawing.Point(80, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtName.WaterMarkText = "Ivan";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSurname.Location = new System.Drawing.Point(80, 45);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtSurname.WaterMarkText = "Petuh";
            // 
            // growLabel1
            // 
            this.growLabel1.AutoSize = true;
            this.growLabel1.Location = new System.Drawing.Point(5, 48);
            this.growLabel1.Name = "growLabel1";
            this.growLabel1.Size = new System.Drawing.Size(56, 13);
            this.growLabel1.TabIndex = 6;
            this.growLabel1.Text = "Фамилия";
            // 
            // growLabel2
            // 
            this.growLabel2.AutoSize = true;
            this.growLabel2.Location = new System.Drawing.Point(32, 22);
            this.growLabel2.Name = "growLabel2";
            this.growLabel2.Size = new System.Drawing.Size(29, 13);
            this.growLabel2.TabIndex = 4;
            this.growLabel2.Text = "Имя";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtLogin.Location = new System.Drawing.Point(80, 71);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtLogin.WaterMarkText = "Ivan";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPassword.Location = new System.Drawing.Point(80, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPassword.WaterMarkText = "********";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(23, 74);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(126, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 218);
            this.Controls.Add(this.gbLoginForm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.MaximumSize = new System.Drawing.Size(241, 257);
            this.MinimumSize = new System.Drawing.Size(241, 257);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.gbLoginForm.ResumeLayout(false);
            this.gbLoginForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLoginForm;
        private WaterMarkTextBox txtLogin;
        private WaterMarkTextBox txtPassword;
        private GrowLabel lblPassword;
        private GrowLabel lblLogin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private WaterMarkTextBox txtName;
        private WaterMarkTextBox txtSurname;
        private GrowLabel growLabel1;
        private GrowLabel growLabel2;
        private System.Windows.Forms.CheckBox chkbAdmin;
    }
}