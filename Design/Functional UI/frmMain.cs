using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pnlEmoticonImage_Click(object sender, EventArgs e)
        {
            //Show list of custom emoticons and various other icons (16x16)
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            sizeablePanel1.MaximumSize = new Size((int)(Width * 0.8), 0);
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            sizeablePanel1.MaximumSize = new Size((int)(Width * 0.8), 0);
        }
    }
}
