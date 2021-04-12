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
    public partial class PopupForm : Form
    {
        public string ReturnValue1 { get; set; }
        public PopupForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValue1 = DateTime.Now.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
