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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
            addPhotoButton.FlatStyle = FlatStyle.Flat;
            addPhotoButton.FlatAppearance.BorderSize = 1;
            addPhotoButton.FlatAppearance.BorderColor = Color.White;
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {

        }

        private void oKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
