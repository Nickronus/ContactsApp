﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            addContactButton.FlatStyle = FlatStyle.Flat;
            addContactButton.FlatAppearance.BorderSize = 1;
            addContactButton.FlatAppearance.BorderColor = Color.White;
            editContactButton.FlatStyle = FlatStyle.Flat;
            editContactButton.FlatAppearance.BorderSize = 1;
            editContactButton.FlatAppearance.BorderColor = Color.White;
            removeContactButton.FlatStyle = FlatStyle.Flat;
            removeContactButton.FlatAppearance.BorderSize = 1;
            removeContactButton.FlatAppearance.BorderColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainSplitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void VKLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
