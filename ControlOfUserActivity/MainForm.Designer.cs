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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Создать сообщение");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Просмотреть сообщения");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Создать новость");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Список пользователей");
            this.panelControls = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.flowNewsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.trvNotification = new System.Windows.Forms.TreeView();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.panelControls.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControls.Controls.Add(this.maskedTextBox1);
            this.panelControls.Controls.Add(this.btnMinus);
            this.panelControls.Controls.Add(this.btnPlus);
            this.panelControls.Controls.Add(this.btnBack);
            this.panelControls.Controls.Add(this.btnForward);
            this.panelControls.Controls.Add(this.btnExit);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 321);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(384, 40);
            this.panelControls.TabIndex = 10;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox1.Location = new System.Drawing.Point(152, 9);
            this.maskedTextBox1.Mask = "000/2\\0\\0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(56, 20);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.Visible = false;
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMinus.Location = new System.Drawing.Point(117, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(29, 29);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Visible = false;
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlus.Location = new System.Drawing.Point(214, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(29, 29);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(260, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 29);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForward.Enabled = false;
            this.btnForward.Location = new System.Drawing.Point(317, 4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(53, 29);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = "Вперёд";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(10, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flowNewsPanel
            // 
            this.flowNewsPanel.AutoScroll = true;
            this.flowNewsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowNewsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowNewsPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowNewsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNewsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNewsPanel.Location = new System.Drawing.Point(0, 34);
            this.flowNewsPanel.Name = "flowNewsPanel";
            this.flowNewsPanel.Size = new System.Drawing.Size(384, 287);
            this.flowNewsPanel.TabIndex = 11;
            this.flowNewsPanel.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnNotification);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 34);
            this.panel1.TabIndex = 12;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.Location = new System.Drawing.Point(308, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(62, 24);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Главная";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.Location = new System.Drawing.Point(10, 3);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(24, 24);
            this.btnNotification.TabIndex = 8;
            this.btnNotification.Text = "֍";
            this.btnNotification.UseVisualStyleBackColor = true;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(50, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(24, 24);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "=";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // trvNotification
            // 
            this.trvNotification.Location = new System.Drawing.Point(53, 30);
            this.trvNotification.Name = "trvNotification";
            treeNode9.Name = "Create";
            treeNode9.Tag = "Create";
            treeNode9.Text = "Создать сообщение";
            treeNode10.Name = "Open";
            treeNode10.Tag = "Open";
            treeNode10.Text = "Просмотреть сообщения";
            this.trvNotification.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            this.trvNotification.Size = new System.Drawing.Size(65535, 0);
            this.trvNotification.TabIndex = 14;
            this.trvNotification.Visible = false;
            this.trvNotification.DoubleClick += new System.EventHandler(this.trvNotification_DoubleClick);
            this.trvNotification.Leave += new System.EventHandler(this.trvNotification_Leave);
            // 
            // trvMenu
            // 
            this.trvMenu.Location = new System.Drawing.Point(13, 30);
            this.trvMenu.Name = "trvMenu";
            treeNode11.Name = "CreateNews";
            treeNode11.Tag = "CreateNews";
            treeNode11.Text = "Создать новость";
            treeNode12.Name = "UsersList";
            treeNode12.Tag = "UsersList";
            treeNode12.Text = "Список пользователей";
            this.trvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            this.trvMenu.Size = new System.Drawing.Size(65535, 0);
            this.trvMenu.TabIndex = 13;
            this.trvMenu.Visible = false;
            this.trvMenu.DoubleClick += new System.EventHandler(this.trvMenu_DoubleClick);
            this.trvMenu.Leave += new System.EventHandler(this.trvMenu_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.trvMenu);
            this.Controls.Add(this.trvNotification);
            this.Controls.Add(this.flowNewsPanel);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.FlowLayoutPanel flowNewsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.TreeView trvNotification;
        private System.Windows.Forms.Button btnHome;
    }
}

