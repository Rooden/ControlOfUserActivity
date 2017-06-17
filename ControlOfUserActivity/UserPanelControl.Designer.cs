namespace ControlOfUserActivity
{
    partial class UserPanelControl
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
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNickname = new ControlOfUserActivity.GrowLabel();
            this.lblRealFullName = new ControlOfUserActivity.GrowLabel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.AutoSize = true;
            this.flowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanel.Controls.Add(this.lblNickname);
            this.flowPanel.Controls.Add(this.lblRealFullName);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(49, 26);
            this.flowPanel.TabIndex = 6;
            // 
            // lblHeader
            // 
            this.lblNickname.Location = new System.Drawing.Point(3, 0);
            this.lblNickname.Name = "lblHeader";
            this.lblNickname.Size = new System.Drawing.Size(43, 13);
            this.lblNickname.TabIndex = 0;
            this.lblNickname.Text = "lblHeader";
            // 
            // lblBody
            // 
            this.lblRealFullName.Location = new System.Drawing.Point(3, 13);
            this.lblRealFullName.Name = "lblBody";
            this.lblRealFullName.Size = new System.Drawing.Size(41, 13);
            this.lblRealFullName.TabIndex = 1;
            this.lblRealFullName.Text = "lblBoby";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOpen.Location = new System.Drawing.Point(-18, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(84, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 30);
            this.panel1.TabIndex = 7;
            // 
            // UserPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.panel1);
            this.Name = "UserPanelControl";
            this.Size = new System.Drawing.Size(49, 56);
            this.flowPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private GrowLabel lblNickname;
        private GrowLabel lblRealFullName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel1;
    }
}
