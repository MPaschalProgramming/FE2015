using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameThatChord
{
    public partial class frmNTC : Form
    {
        public frmNTC()
        {
            InitializeComponent();
        }

        private void btnNext4_Click(object sender, EventArgs e)
        {
            tabCtrl.SelectedIndex = (tabCtrl.SelectedIndex + 1 < tabCtrl.TabCount) ?
                tabCtrl.SelectedIndex + 1 : 0;
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            tabCtrl.SelectedIndex = (tabCtrl.SelectedIndex + 1 < tabCtrl.TabCount) ?
                tabCtrl.SelectedIndex + 1 : 0;
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            tabCtrl.SelectedIndex = (tabCtrl.SelectedIndex + 1 < tabCtrl.TabCount) ?
                            tabCtrl.SelectedIndex + 1 : 0;
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            tabCtrl.SelectedIndex = (tabCtrl.SelectedIndex + 1 < tabCtrl.TabCount) ?
                tabCtrl.SelectedIndex + 1 : 0;
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            if (pBoxA.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxA.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if (pBoxA.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxA.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (pBoxA.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxA.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            if (pBoxA.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxA.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (pBoxC.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxC.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (pBoxC.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxC.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (pBoxC.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxC.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            if (pBoxC.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxC.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            if (pBoxD.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxD.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            if (pBoxD.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxD.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            if (pBoxD.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxD.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            if (pBoxD.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxD.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnG1_Click(object sender, EventArgs e)
        {
            if (pBoxG.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxG.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            if (pBoxG.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxG.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnG3_Click(object sender, EventArgs e)
        {
            if (pBoxG.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxG.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnG4_Click(object sender, EventArgs e)
        {
            if (pBoxG.Visible == true)
                MessageBox.Show("Good Job!");
            if (pBoxG.Visible == false)
                MessageBox.Show("Try Again!");
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
