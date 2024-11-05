using System;
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
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }  

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fn = new Form1();
            fn.Show();
            this.Close();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            AddNewRoom anr = new AddNewRoom();
            anr.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent uds = new UpdateDeleteStudent();
            uds.Show();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent uds = new NewStudent();
            uds.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
