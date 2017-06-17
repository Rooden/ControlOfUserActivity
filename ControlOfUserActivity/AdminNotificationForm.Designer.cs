namespace ControlOfUserActivity
{
    partial class AdminNotificationForm
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
            this.lblName = new ControlOfUserActivity.GrowLabel();
            this.txtHeader = new ControlOfUserActivity.WaterMarkTextBox();
            this.txtBody = new ControlOfUserActivity.WaterMarkTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Создание сообщения";
            // 
            // txtHeader
            // 
            this.txtHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtHeader.Location = new System.Drawing.Point(12, 30);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(260, 20);
            this.txtHeader.TabIndex = 7;
            this.txtHeader.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtHeader.WaterMarkText = "Заголовок";
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBody.Location = new System.Drawing.Point(12, 56);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(260, 164);
            this.txtBody.TabIndex = 8;
            this.txtBody.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtBody.WaterMarkText = "Текст сообщения";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(197, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AdminNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.btnSave);
            this.Name = "AdminNotificationForm";
            this.Text = "AdminNotificationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GrowLabel lblName;
        private WaterMarkTextBox txtHeader;
        private WaterMarkTextBox txtBody;
        private System.Windows.Forms.Button btnSave;
    }
}