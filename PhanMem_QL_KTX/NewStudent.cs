﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMem_QL_KTX
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(499, 150);
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
