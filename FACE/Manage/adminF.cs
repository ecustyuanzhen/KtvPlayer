using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FACE.Manage
{
    public partial class adminF : Form
    {
        public adminF(ManageForm manage)
        {
            InitializeComponent();
            this.MdiParent = manage;
        }

        private void adminF_Load(object sender, EventArgs e)
        {

        }
    }
}
