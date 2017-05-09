namespace ControlOfUserActivity
{
    partial class NewsControl
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
            this.flowPanel = new System.Windows.Forms.Panel();
            this.lblHeader = new ControlOfUserActivity.GrowLabel();
            this.lblBody = new ControlOfUserActivity.GrowLabel();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.AutoSize = true;
            this.flowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanel.Controls.Add(this.lblHeader);
            this.flowPanel.Controls.Add(this.lblBody);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(58, 39);
            this.flowPanel.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(3, 4);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(52, 13);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "lblHeader";
            // 
            // lblBody
            // 
            this.lblBody.Location = new System.Drawing.Point(3, 23);
            this.lblBody.Margin = new System.Windows.Forms.Padding(3);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(41, 13);
            this.lblBody.TabIndex = 5;
            this.lblBody.Text = "lblBody";
            // 
            // NewsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowPanel);
            this.Name = "NewsControl";
            this.Size = new System.Drawing.Size(58, 39);
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel flowPanel;
        private GrowLabel lblHeader;
        private GrowLabel lblBody;
    }
}
