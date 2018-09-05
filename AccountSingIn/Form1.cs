using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSingIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.Text = "";
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.Text !="" && bunifuMaterialTextbox2.Text != "" && bunifuMaterialTextbox3.Text != "")
            {
                panel4.BringToFront();
                panel4.Visible = true;
                timer1.Enabled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
