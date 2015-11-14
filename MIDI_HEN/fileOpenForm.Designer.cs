namespace MIDI_HEN
{
    partial class fileOpenForm
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
            this.BUTTON_browse = new System.Windows.Forms.Button();
            this.TEXTBOX_fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectBinary = new System.Windows.Forms.RadioButton();
            this.selectPlay = new System.Windows.Forms.RadioButton();
            this.BUTTON_open = new System.Windows.Forms.Button();
            this.BUTTON_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BUTTON_browse
            // 
            this.BUTTON_browse.Location = new System.Drawing.Point(307, 40);
            this.BUTTON_browse.Name = "BUTTON_browse";
            this.BUTTON_browse.Size = new System.Drawing.Size(47, 23);
            this.BUTTON_browse.TabIndex = 0;
            this.BUTTON_browse.Text = "参照";
            this.BUTTON_browse.UseVisualStyleBackColor = true;
            this.BUTTON_browse.Click += new System.EventHandler(this.BUTTON_browse_Click);
            // 
            // TEXTBOX_fileName
            // 
            this.TEXTBOX_fileName.Location = new System.Drawing.Point(13, 42);
            this.TEXTBOX_fileName.Name = "TEXTBOX_fileName";
            this.TEXTBOX_fileName.Size = new System.Drawing.Size(288, 19);
            this.TEXTBOX_fileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "*ファイル名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "*形式選択";
            // 
            // selectBinary
            // 
            this.selectBinary.AutoSize = true;
            this.selectBinary.Checked = true;
            this.selectBinary.Location = new System.Drawing.Point(13, 96);
            this.selectBinary.Name = "selectBinary";
            this.selectBinary.Size = new System.Drawing.Size(59, 16);
            this.selectBinary.TabIndex = 4;
            this.selectBinary.TabStop = true;
            this.selectBinary.Text = "バイナリ";
            this.selectBinary.UseVisualStyleBackColor = true;
            // 
            // selectPlay
            // 
            this.selectPlay.AutoSize = true;
            this.selectPlay.Location = new System.Drawing.Point(13, 119);
            this.selectPlay.Name = "selectPlay";
            this.selectPlay.Size = new System.Drawing.Size(71, 16);
            this.selectPlay.TabIndex = 5;
            this.selectPlay.Text = "再生（爆）";
            this.selectPlay.UseVisualStyleBackColor = true;
            // 
            // BUTTON_open
            // 
            this.BUTTON_open.Location = new System.Drawing.Point(208, 137);
            this.BUTTON_open.Name = "BUTTON_open";
            this.BUTTON_open.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_open.TabIndex = 6;
            this.BUTTON_open.Text = "開く";
            this.BUTTON_open.UseVisualStyleBackColor = true;
            this.BUTTON_open.Click += new System.EventHandler(this.BUTTON_open_Click);
            // 
            // BUTTON_close
            // 
            this.BUTTON_close.Location = new System.Drawing.Point(289, 137);
            this.BUTTON_close.Name = "BUTTON_close";
            this.BUTTON_close.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_close.TabIndex = 7;
            this.BUTTON_close.Text = "キャンセル";
            this.BUTTON_close.UseVisualStyleBackColor = true;
            this.BUTTON_close.Click += new System.EventHandler(this.BUTTON_close_Click);
            // 
            // fileOpenForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 172);
            this.Controls.Add(this.BUTTON_close);
            this.Controls.Add(this.BUTTON_open);
            this.Controls.Add(this.selectPlay);
            this.Controls.Add(this.selectBinary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TEXTBOX_fileName);
            this.Controls.Add(this.BUTTON_browse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fileOpenForm";
            this.Text = "ファイルオープン";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fileOpenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUTTON_browse;
        private System.Windows.Forms.TextBox TEXTBOX_fileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton selectBinary;
        private System.Windows.Forms.RadioButton selectPlay;
        private System.Windows.Forms.Button BUTTON_open;
        private System.Windows.Forms.Button BUTTON_close;
    }
}