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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
   


        }

        private void menu_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("H: mm: ss");
            label2.Text = DateTime.Now.ToString("D");

            DateTime tempo = DateTime.Now;

            if (tempo.Hour > 6 && tempo.Hour < 12)
                label3.Text = "Bom dia";

            else if (tempo.Hour >= 12 && tempo.Hour < 18)
                label3.Text = "Boa tarde";

            else
                label3.Text = "Boa noite";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
