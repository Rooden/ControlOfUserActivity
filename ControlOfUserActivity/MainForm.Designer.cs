namespace ControlOfUserActivity
{
    partial class MainForm
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
            this.flowNewsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.panelLastNews = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelLastNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowNewsPanel
            // 
            this.flowNewsPanel.AutoSize = true;
            this.flowNewsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowNewsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowNewsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNewsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNewsPanel.Location = new System.Drawing.Point(0, 0);
            this.flowNewsPanel.Name = "flowNewsPanel";
            this.flowNewsPanel.Size = new System.Drawing.Size(284, 321);
            this.flowNewsPanel.TabIndex = 0;
            this.flowNewsPanel.WrapContents = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(18, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Последние \r\nновости";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(18, 70);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(55, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(18, 117);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(55, 13);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "linkLabel3";
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(18, 94);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(55, 13);
            this.linkLabel4.TabIndex = 8;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "linkLabel4";
            // 
            // panelLastNews
            // 
            this.panelLastNews.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLastNews.Controls.Add(this.label1);
            this.panelLastNews.Controls.Add(this.linkLabel4);
            this.panelLastNews.Controls.Add(this.linkLabel1);
            this.panelLastNews.Controls.Add(this.linkLabel3);
            this.panelLastNews.Controls.Add(this.linkLabel2);
            this.panelLastNews.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLastNews.Location = new System.Drawing.Point(284, 0);
            this.panelLastNews.Name = "panelLastNews";
            this.panelLastNews.Size = new System.Drawing.Size(100, 321);
            this.panelLastNews.TabIndex = 9;
            // 
            // panelControls
            // 
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 321);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(384, 40);
            this.panelControls.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.flowNewsPanel);
            this.Controls.Add(this.panelLastNews);
            this.Controls.Add(this.panelControls);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelLastNews.ResumeLayout(false);
            this.panelLastNews.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowNewsPanel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Panel panelLastNews;
        private System.Windows.Forms.Panel panelControls;
    }
}

