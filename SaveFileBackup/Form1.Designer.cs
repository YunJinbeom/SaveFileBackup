namespace SaveFileBackup
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackUpPanel = new System.Windows.Forms.Panel();
            this.count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TimerTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.setBackupFolderPath = new System.Windows.Forms.Button();
            this.backupPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setSaveFolderPath = new System.Windows.Forms.Button();
            this.savePath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BackUpPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Location = new System.Drawing.Point(13, 13);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(157, 356);
            this.MenuPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SaveFileBackup.Properties.Resources.menu2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BackUpPanel
            // 
            this.BackUpPanel.Controls.Add(this.count);
            this.BackUpPanel.Controls.Add(this.label2);
            this.BackUpPanel.Controls.Add(this.start);
            this.BackUpPanel.Controls.Add(this.groupBox3);
            this.BackUpPanel.Controls.Add(this.groupBox2);
            this.BackUpPanel.Controls.Add(this.groupBox1);
            this.BackUpPanel.Location = new System.Drawing.Point(179, 13);
            this.BackUpPanel.Name = "BackUpPanel";
            this.BackUpPanel.Size = new System.Drawing.Size(498, 356);
            this.BackUpPanel.TabIndex = 1;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(78, 323);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(36, 12);
            this.count.TabIndex = 5;
            this.count.Text = "count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "실행 횟수";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Location = new System.Drawing.Point(14, 222);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(122, 39);
            this.start.TabIndex = 3;
            this.start.Text = "시작";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TimerTextBox);
            this.groupBox3.Location = new System.Drawing.Point(14, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "저장 주기(분)";
            // 
            // TimerTextBox
            // 
            this.TimerTextBox.Location = new System.Drawing.Point(19, 20);
            this.TimerTextBox.Name = "TimerTextBox";
            this.TimerTextBox.Size = new System.Drawing.Size(81, 21);
            this.TimerTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.setBackupFolderPath);
            this.groupBox2.Controls.Add(this.backupPath);
            this.groupBox2.Location = new System.Drawing.Point(14, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 55);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "저장 폴더";
            // 
            // setBackupFolderPath
            // 
            this.setBackupFolderPath.Location = new System.Drawing.Point(406, 20);
            this.setBackupFolderPath.Name = "setBackupFolderPath";
            this.setBackupFolderPath.Size = new System.Drawing.Size(52, 21);
            this.setBackupFolderPath.TabIndex = 1;
            this.setBackupFolderPath.Text = "열기";
            this.setBackupFolderPath.UseVisualStyleBackColor = true;
            this.setBackupFolderPath.Click += new System.EventHandler(this.setBackupFolderPath_Click);
            // 
            // backupPath
            // 
            this.backupPath.Location = new System.Drawing.Point(19, 20);
            this.backupPath.Name = "backupPath";
            this.backupPath.Size = new System.Drawing.Size(371, 21);
            this.backupPath.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setSaveFolderPath);
            this.groupBox1.Controls.Add(this.savePath);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "세이브 파일 경로";
            // 
            // setSaveFolderPath
            // 
            this.setSaveFolderPath.Location = new System.Drawing.Point(406, 20);
            this.setSaveFolderPath.Name = "setSaveFolderPath";
            this.setSaveFolderPath.Size = new System.Drawing.Size(52, 21);
            this.setSaveFolderPath.TabIndex = 1;
            this.setSaveFolderPath.Text = "열기";
            this.setSaveFolderPath.UseVisualStyleBackColor = true;
            this.setSaveFolderPath.Click += new System.EventHandler(this.setSaveFolderPath_Click);
            // 
            // savePath
            // 
            this.savePath.Location = new System.Drawing.Point(19, 20);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(371, 21);
            this.savePath.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(171, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 356);
            this.panel1.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackUpPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BackUpPanel.ResumeLayout(false);
            this.BackUpPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel BackUpPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setSaveFolderPath;
        private System.Windows.Forms.TextBox savePath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TimerTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button setBackupFolderPath;
        private System.Windows.Forms.TextBox backupPath;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    }
}

