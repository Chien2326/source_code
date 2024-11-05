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
    public partial class AddNewRoom : Form
    {

        public AddNewRoom()
        {
            InitializeComponent();
        }


        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();//Cai nay de thoat ra
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(499,150);
            labelRoom.Visible = false;
            labelRoom.Visible =false;
        }


    }
}
