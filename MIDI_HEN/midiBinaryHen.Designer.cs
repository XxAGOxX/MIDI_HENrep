namespace MIDI_HEN
{
    partial class midiBinaryHen
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
            this.dataShowTextBox = new System.Windows.Forms.RichTextBox();
            this.BUTTON_playBinary = new System.Windows.Forms.Button();
            this.BUTTON_overwrite = new System.Windows.Forms.Button();
            this.BUTTON_RenameSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataShowTextBox
            // 
            this.dataShowTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataShowTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataShowTextBox.Location = new System.Drawing.Point(12, 42);
            this.dataShowTextBox.Name = "dataShowTextBox";
            this.dataShowTextBox.Size = new System.Drawing.Size(660, 457);
            this.dataShowTextBox.TabIndex = 0;
            this.dataShowTextBox.Text = "";
            this.dataShowTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // BUTTON_playBinary
            // 
            this.BUTTON_playBinary.Location = new System.Drawing.Point(13, 13);
            this.BUTTON_playBinary.Name = "BUTTON_playBinary";
            this.BUTTON_playBinary.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_playBinary.TabIndex = 1;
            this.BUTTON_playBinary.Text = "再生（未）";
            this.BUTTON_playBinary.UseVisualStyleBackColor = true;
            this.BUTTON_playBinary.Click += new System.EventHandler(this.BUTTON_playBinary_Click);
            // 
            // BUTTON_overwrite
            // 
            this.BUTTON_overwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUTTON_overwrite.Location = new System.Drawing.Point(575, 12);
            this.BUTTON_overwrite.Name = "BUTTON_overwrite";
            this.BUTTON_overwrite.Size = new System.Drawing.Size(97, 23);
            this.BUTTON_overwrite.TabIndex = 2;
            this.BUTTON_overwrite.Text = "上書き保存（未）";
            this.BUTTON_overwrite.UseVisualStyleBackColor = true;
            this.BUTTON_overwrite.Click += new System.EventHandler(this.BUTTON_overwrite_Click);
            // 
            // BUTTON_RenameSave
            // 
            this.BUTTON_RenameSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUTTON_RenameSave.Location = new System.Drawing.Point(474, 12);
            this.BUTTON_RenameSave.Name = "BUTTON_RenameSave";
            this.BUTTON_RenameSave.Size = new System.Drawing.Size(95, 23);
            this.BUTTON_RenameSave.TabIndex = 3;
            this.BUTTON_RenameSave.Text = "別名で保存（未）";
            this.BUTTON_RenameSave.UseVisualStyleBackColor = true;
            this.BUTTON_RenameSave.Click += new System.EventHandler(this.BUTTON_RenameSave_Click);
            // 
            // midiBinaryHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.BUTTON_RenameSave);
            this.Controls.Add(this.BUTTON_overwrite);
            this.Controls.Add(this.BUTTON_playBinary);
            this.Controls.Add(this.dataShowTextBox);
            this.MinimumSize = new System.Drawing.Size(350, 150);
            this.Name = "midiBinaryHen";
            this.Text = "バイナリモード";
            this.Load += new System.EventHandler(this.midiBinaryHen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox dataShowTextBox;
        private System.Windows.Forms.Button BUTTON_playBinary;
        private System.Windows.Forms.Button BUTTON_overwrite;
        private System.Windows.Forms.Button BUTTON_RenameSave;
    }
}