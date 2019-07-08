using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacialRecognition
{
    public partial class ModMenu : Form
    {
        public ModMenu()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            //make it starting form

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //link it to training module
            ModEnroll f = new ModEnroll();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //now create form for recognition
            ModDetect r = new ModDetect();
            r.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //link it to training module
            ModEnroll f = new ModEnroll();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //now create form for recognition
            ModDetect r = new ModDetect();
            r.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ModLogin login = new ModLogin();
            login.Show();
            this.Hide();
        }
    }
}
