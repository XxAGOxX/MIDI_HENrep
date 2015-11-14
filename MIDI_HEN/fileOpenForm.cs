using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDI_HEN
{
    public partial class fileOpenForm : Form
    {

        public fileOpenForm()
        {
            InitializeComponent();
        }

        private void fileOpenForm_Load(object sender, EventArgs e)
        {
            fileOpenForm.OF_instance = this;
        }

        //インスタンス作成
        private static fileOpenForm _OF_instance;
        public static fileOpenForm OF_instance
        {
            get { return _OF_instance; }
            set { _OF_instance = value; }
        }
        
        //テキストボックス
        public string targetFileTEXT
        {
            get { return this.TEXTBOX_fileName.Text; }
            set { this.TEXTBOX_fileName.Text = value; }
        }
        
        //「参照」
        private void BUTTON_browse_Click(object sender, EventArgs e)
        {
        //ファイルオープンダイアログ設定
            OpenFileDialog OpenFileD = new OpenFileDialog();
            //ファイル名フィルタ
            OpenFileD.Filter = "MIDIファイル|*.mid";
        //ファイルオープンコントロール
            if (OpenFileD.ShowDialog() == DialogResult.OK)
            {
                this.TEXTBOX_fileName.Text = OpenFileD.FileName;
            }
        }

        //「開く」
        private void BUTTON_open_Click(object sender, EventArgs e)
        {
        //テキストボックス確認
            if (this.TEXTBOX_fileName.Text == string.Empty)
            {
                MessageBox.Show("ファイル名を指定しなはれ",
                                   "エラー",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
            else
            {
                if (selectPlay.Checked)
                {
                    WMPform WMPform_1 = new WMPform();
                    WMPform_1.Show();
                }
                else if (selectBinary.Checked)
                {
                    midiBinaryHen binaryOpen = new midiBinaryHen();
                    binaryOpen.Show();
                }
            }
        }
        //「キャンセル」
        private void BUTTON_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
