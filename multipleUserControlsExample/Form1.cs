using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multipleUserControlsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainContentControl mainContent = new MainContentControl();
            MainControl.showControl(mainContent, content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecondContentControl secondContent = new SecondContentControl();
            MainControl.showControl(secondContent, content);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopupForm popupForm = new PopupForm();
            var result = popupForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string val = popupForm.ReturnValue1;
                MessageBox.Show("現在時間" + val);
            }
        }
    }
}
