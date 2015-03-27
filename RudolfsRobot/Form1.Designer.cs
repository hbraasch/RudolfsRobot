namespace RudolfsRobot
{
    partial class frmStartup
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControlStartup = new System.Windows.Forms.TabControl();
            this.tabPageRun = new System.Windows.Forms.TabPage();
            this.tabPageSetup = new System.Windows.Forms.TabPage();
            this.tabPageExperimentation = new System.Windows.Forms.TabPage();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveMotors = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControlStartup.SuspendLayout();
            this.tabPageRun.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(822, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControlStartup
            // 
            this.tabControlStartup.Controls.Add(this.tabPageRun);
            this.tabControlStartup.Controls.Add(this.tabPageSetup);
            this.tabControlStartup.Controls.Add(this.tabPageExperimentation);
            this.tabControlStartup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStartup.Location = new System.Drawing.Point(0, 24);
            this.tabControlStartup.Name = "tabControlStartup";
            this.tabControlStartup.SelectedIndex = 0;
            this.tabControlStartup.Size = new System.Drawing.Size(822, 378);
            this.tabControlStartup.TabIndex = 2;
            // 
            // tabPageRun
            // 
            this.tabPageRun.Controls.Add(this.btnReset);
            this.tabPageRun.Controls.Add(this.btnMoveMotors);
            this.tabPageRun.Location = new System.Drawing.Point(4, 22);
            this.tabPageRun.Name = "tabPageRun";
            this.tabPageRun.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRun.Size = new System.Drawing.Size(814, 352);
            this.tabPageRun.TabIndex = 0;
            this.tabPageRun.Text = "Run";
            this.tabPageRun.UseVisualStyleBackColor = true;
            // 
            // tabPageSetup
            // 
            this.tabPageSetup.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetup.Name = "tabPageSetup";
            this.tabPageSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetup.Size = new System.Drawing.Size(814, 352);
            this.tabPageSetup.TabIndex = 1;
            this.tabPageSetup.Text = "Setup";
            this.tabPageSetup.UseVisualStyleBackColor = true;
            // 
            // tabPageExperimentation
            // 
            this.tabPageExperimentation.Location = new System.Drawing.Point(4, 22);
            this.tabPageExperimentation.Name = "tabPageExperimentation";
            this.tabPageExperimentation.Size = new System.Drawing.Size(814, 352);
            this.tabPageExperimentation.TabIndex = 2;
            this.tabPageExperimentation.Text = "Experimentation";
            this.tabPageExperimentation.UseVisualStyleBackColor = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnMoveMotors
            // 
            this.btnMoveMotors.Location = new System.Drawing.Point(273, 113);
            this.btnMoveMotors.Name = "btnMoveMotors";
            this.btnMoveMotors.Size = new System.Drawing.Size(140, 31);
            this.btnMoveMotors.TabIndex = 0;
            this.btnMoveMotors.Text = "Move motors";
            this.btnMoveMotors.UseVisualStyleBackColor = true;
            this.btnMoveMotors.Click += new System.EventHandler(this.btnMoveMotors_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(104, 113);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 31);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 424);
            this.Controls.Add(this.tabControlStartup);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStartup";
            this.Text = "Rudolf\'s Robot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlStartup.ResumeLayout(false);
            this.tabPageRun.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControlStartup;
        private System.Windows.Forms.TabPage tabPageRun;
        private System.Windows.Forms.TabPage tabPageSetup;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageExperimentation;
        private System.Windows.Forms.Button btnMoveMotors;
        private System.Windows.Forms.Button btnReset;
    }
}

