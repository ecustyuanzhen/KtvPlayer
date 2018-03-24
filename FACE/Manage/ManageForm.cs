using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FACE.Manage;

namespace FACE
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }
        adminF admin;
        private void 管理员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (admin != null)
                admin.Dispose();
            admin = new adminF(this );
            admin.Show();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {

        }

        private void ManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
        }

        private void 歌词管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
