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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AbrirFormi(new menu());

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormi(Form formija)
        {
            if (this.paneltroca.Controls.Count > 0)
                this.paneltroca.Controls.RemoveAt(0);
            Form fh = formija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.paneltroca.Controls.Add(fh);
            this.paneltroca.Tag = fh;
            fh.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AbrirFormi(new joga());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AbrirFormi(new menu());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            AbrirFormi(new ajuda());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormi(new menu());
        }
    }
}
