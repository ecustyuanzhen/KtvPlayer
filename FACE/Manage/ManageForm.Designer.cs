namespace FACE
{
    partial class ManageForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.歌词管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.歌手管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.类型管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员管理ToolStripMenuItem,
            this.歌词管理ToolStripMenuItem,
            this.歌手管理ToolStripMenuItem,
            this.类型管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理员管理ToolStripMenuItem
            // 
            this.管理员管理ToolStripMenuItem.Name = "管理员管理ToolStripMenuItem";
            this.管理员管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.管理员管理ToolStripMenuItem.Text = "用户管理";
            this.管理员管理ToolStripMenuItem.Click += new System.EventHandler(this.管理员管理ToolStripMenuItem_Click);
            // 
            // 歌词管理ToolStripMenuItem
            // 
            this.歌词管理ToolStripMenuItem.Name = "歌词管理ToolStripMenuItem";
            this.歌词管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.歌词管理ToolStripMenuItem.Text = "歌曲管理";
            this.歌词管理ToolStripMenuItem.Click += new System.EventHandler(this.歌词管理ToolStripMenuItem_Click);
            // 
            // 歌手管理ToolStripMenuItem
            // 
            this.歌手管理ToolStripMenuItem.Name = "歌手管理ToolStripMenuItem";
            this.歌手管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.歌手管理ToolStripMenuItem.Text = "歌手管理";
            // 
            // 类型管理ToolStripMenuItem
            // 
            this.类型管理ToolStripMenuItem.Name = "类型管理ToolStripMenuItem";
            this.类型管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.类型管理ToolStripMenuItem.Text = "类型管理";
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageForm";
            this.Text = "管理员界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 歌词管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 歌手管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 类型管理ToolStripMenuItem;
    }
}