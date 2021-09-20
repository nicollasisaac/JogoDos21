using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtvJogo21
{
    public partial class ajuda : Form
    {
        public ajuda()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/hCrAvT");
        }
    }
}
