namespace MIDI_HEN
{
    partial class FORM_main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MakeNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OverwriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MIDIopenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.MakeNewToolStripMenuItem,
            this.OverwriteToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.MIDIopenToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ExitToolStripMenuItem.Text = "終了";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MakeNewToolStripMenuItem
            // 
            this.MakeNewToolStripMenuItem.Name = "MakeNewToolStripMenuItem";
            this.MakeNewToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.MakeNewToolStripMenuItem.Text = "新規作成（未）";
            this.MakeNewToolStripMenuItem.Click += new System.EventHandler(this.MakeNewToolStripMenuItem_Click);
            // 
            // OverwriteToolStripMenuItem
            // 
            this.OverwriteToolStripMenuItem.Name = "OverwriteToolStripMenuItem";
            this.OverwriteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.OverwriteToolStripMenuItem.Text = "上書き保存（未）";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.SaveToolStripMenuItem.Text = "名前を付けて保存（未）";
            // 
            // MIDIopenToolStripMenuItem
            // 
            this.MIDIopenToolStripMenuItem.Name = "MIDIopenToolStripMenuItem";
            this.MIDIopenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.MIDIopenToolStripMenuItem.Text = "MIDIファイルを開く";
            this.MIDIopenToolStripMenuItem.Click += new System.EventHandler(this.MIDIopenToolStripMenuItem_Click);
            // 
            // FORM_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 428);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FORM_main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "MIDI_HEN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OverwriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MakeNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MIDIopenToolStripMenuItem;
    }
}

