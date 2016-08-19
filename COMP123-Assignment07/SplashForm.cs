using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Golden Pamela Apillanes 
 * Student Number: 300867201
 * Description: Movie Bonanza - Online Streaming 
 * Due Date: August 19th 2016
 * 
 */

namespace COMP123_Assignment07
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            SelectionForm SelectionForm = new SelectionForm();
            this.Hide();
            SelectionForm.Show();
            timer1.Enabled = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
