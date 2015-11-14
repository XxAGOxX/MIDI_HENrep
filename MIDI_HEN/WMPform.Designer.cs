namespace MIDI_HEN
{
    partial class WMPform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WMPform));
            this.WMP_1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMP_1)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP_1
            // 
            this.WMP_1.Enabled = true;
            this.WMP_1.Location = new System.Drawing.Point(12, 12);
            this.WMP_1.Name = "WMP_1";
            this.WMP_1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP_1.OcxState")));
            this.WMP_1.Size = new System.Drawing.Size(308, 265);
            this.WMP_1.TabIndex = 3;
            // 
            // WMPform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 289);
            this.Controls.Add(this.WMP_1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WMPform";
            this.Text = "再生";
            this.Load += new System.EventHandler(this.midiPrayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMP_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP_1;
    }
}