namespace DailyReminderApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加事件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除事件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgImportThing = new System.Windows.Forms.TabPage();
            this.tbgThingTable = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(611, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "提示";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加事件ToolStripMenuItem,
            this.删除事件ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 添加事件ToolStripMenuItem
            // 
            this.添加事件ToolStripMenuItem.Name = "添加事件ToolStripMenuItem";
            this.添加事件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加事件ToolStripMenuItem.Text = "添加事件";
            // 
            // 删除事件ToolStripMenuItem
            // 
            this.删除事件ToolStripMenuItem.Name = "删除事件ToolStripMenuItem";
            this.删除事件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除事件ToolStripMenuItem.Text = "删除事件";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgImportThing);
            this.tabControl1.Controls.Add(this.tbgThingTable);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 340);
            this.tabControl1.TabIndex = 2;
            // 
            // tbgImportThing
            // 
            this.tbgImportThing.Location = new System.Drawing.Point(4, 22);
            this.tbgImportThing.Name = "tbgImportThing";
            this.tbgImportThing.Padding = new System.Windows.Forms.Padding(3);
            this.tbgImportThing.Size = new System.Drawing.Size(603, 314);
            this.tbgImportThing.TabIndex = 0;
            this.tbgImportThing.Text = "重要事件";
            this.tbgImportThing.UseVisualStyleBackColor = true;
            // 
            // tbgThingTable
            // 
            this.tbgThingTable.Location = new System.Drawing.Point(4, 22);
            this.tbgThingTable.Name = "tbgThingTable";
            this.tbgThingTable.Padding = new System.Windows.Forms.Padding(3);
            this.tbgThingTable.Size = new System.Drawing.Size(603, 314);
            this.tbgThingTable.TabIndex = 1;
            this.tbgThingTable.Text = "添加提醒事件";
            this.tbgThingTable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 387);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "事件提醒系统";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加事件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除事件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbgImportThing;
        private System.Windows.Forms.TabPage tbgThingTable;
    }
}

