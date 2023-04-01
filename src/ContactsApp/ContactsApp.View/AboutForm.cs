using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void oKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void gitLinkLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Nickronus");
        }

        private void usedImagesLinkLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://icons8.com/");
        }
    }
}
