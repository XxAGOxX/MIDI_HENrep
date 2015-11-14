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
    public partial class WMPform : Form
    {
        public WMPform()
        {
            InitializeComponent();
        }

        private void midiPrayForm_Load(object sender, EventArgs e)
        {
        //ファイル取得、フォームクローズ
            WMP_1.URL = fileOpenForm.OF_instance.targetFileTEXT;
            //fileOpenForm.OF_instance.Close();
            //WMP_1.settings.autoStart = true;
        }
        
    }
}
