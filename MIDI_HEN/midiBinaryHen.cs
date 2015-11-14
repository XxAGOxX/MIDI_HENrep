using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//追加名前空間
using System.IO;

namespace MIDI_HEN
{
    public partial class midiBinaryHen : Form
    {
        public midiBinaryHen()
        {
            InitializeComponent();
        }

    //ロード時
        private void midiBinaryHen_Load(object sender, EventArgs e)
        {
        //ファイル名取得、フォームクローズ
            string midiFileName = fileOpenForm.OF_instance.targetFileTEXT;
            fileOpenForm.OF_instance.Close();
        //バイナリ格納
            byte[] data = File.ReadAllBytes(midiFileName);

        //表示
            this.dataShowTextBox.Text = System.BitConverter.ToString(data).Replace("-"," ");

        }
    //書き換え時
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    //ボタン
        //「上書き保存」
        private void BUTTON_overwrite_Click(object sender, EventArgs e)
        {

        }
        //「別名で保存」
        private void BUTTON_RenameSave_Click(object sender, EventArgs e)
        {

        }
        //「再生」
        private void BUTTON_playBinary_Click(object sender, EventArgs e)
        {

        }

    }
}
