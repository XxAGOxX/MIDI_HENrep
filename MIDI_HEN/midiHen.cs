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
    public partial class FORM_main : Form
    {

        public FORM_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
//メニューツール
    //終了
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    //新規作成
        private void MakeNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    //開く
        private void MIDIopenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileOpenForm fileOpenFormMIDI = new fileOpenForm();
            fileOpenForm.OF_instance = fileOpenFormMIDI;
            fileOpenFormMIDI.Show();
        }

    }
}
