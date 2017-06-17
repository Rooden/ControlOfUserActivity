namespace ControlOfUserActivity
{
    partial class RatingPageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.growLabel3 = new ControlOfUserActivity.GrowLabel();
            this.growLabel2 = new ControlOfUserActivity.GrowLabel();
            this.growLabel1 = new ControlOfUserActivity.GrowLabel();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.tbSuccess = new System.Windows.Forms.TrackBar();
            this.tbQuality = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.growLabel3);
            this.panel1.Controls.Add(this.growLabel2);
            this.panel1.Controls.Add(this.growLabel1);
            this.panel1.Controls.Add(this.tbSpeed);
            this.panel1.Controls.Add(this.tbSuccess);
            this.panel1.Controls.Add(this.tbQuality);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 150);
            this.panel1.TabIndex = 0;
            // 
            // growLabel3
            // 
            this.growLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.growLabel3.AutoSize = true;
            this.growLabel3.Location = new System.Drawing.Point(19, 117);
            this.growLabel3.Name = "growLabel3";
            this.growLabel3.Size = new System.Drawing.Size(55, 13);
            this.growLabel3.TabIndex = 5;
            this.growLabel3.Text = "Скорость";
            // 
            // growLabel2
            // 
            this.growLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.growLabel2.AutoSize = true;
            this.growLabel2.Location = new System.Drawing.Point(19, 67);
            this.growLabel2.Name = "growLabel2";
            this.growLabel2.Size = new System.Drawing.Size(70, 13);
            this.growLabel2.TabIndex = 4;
            this.growLabel2.Text = "Успешность";
            // 
            // growLabel1
            // 
            this.growLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.growLabel1.AutoSize = true;
            this.growLabel1.Location = new System.Drawing.Point(19, 18);
            this.growLabel1.Name = "growLabel1";
            this.growLabel1.Size = new System.Drawing.Size(54, 13);
            this.growLabel1.TabIndex = 3;
            this.growLabel1.Text = "Качество";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpeed.LargeChange = 2;
            this.tbSpeed.Location = new System.Drawing.Point(95, 102);
            this.tbSpeed.Maximum = 5;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(202, 45);
            this.tbSpeed.TabIndex = 2;
            this.tbSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbSuccess
            // 
            this.tbSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSuccess.LargeChange = 2;
            this.tbSuccess.Location = new System.Drawing.Point(95, 53);
            this.tbSuccess.Maximum = 5;
            this.tbSuccess.Name = "tbSuccess";
            this.tbSuccess.Size = new System.Drawing.Size(202, 45);
            this.tbSuccess.TabIndex = 1;
            this.tbSuccess.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbQuality
            // 
            this.tbQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuality.LargeChange = 2;
            this.tbQuality.Location = new System.Drawing.Point(95, 2);
            this.tbQuality.Maximum = 5;
            this.tbQuality.Name = "tbQuality";
            this.tbQuality.Size = new System.Drawing.Size(202, 45);
            this.tbQuality.TabIndex = 0;
            this.tbQuality.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // RatingPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "RatingPageControl";
            this.Size = new System.Drawing.Size(300, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GrowLabel growLabel3;
        private GrowLabel growLabel2;
        private GrowLabel growLabel1;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.TrackBar tbSuccess;
        private System.Windows.Forms.TrackBar tbQuality;
    }
}
