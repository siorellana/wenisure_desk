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
    public partial class ModLogin : Form
    {
        public ModLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("admin") && txtPass.Text.Equals("admin1"))
            {
                MessageBox.Show("Bienvenido Administrador");
                ModMenu menu = new ModMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Revise sus credenciales");

            }

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = System.Drawing.Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = System.Drawing.Color.DimGray;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = System.Drawing.Color.DarkBlue;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            try
            {

                if (txtPass.Text == "CONTRASEÑA")
                {
                    txtPass.Text = "";
                    txtPass.ForeColor = System.Drawing.Color.DarkBlue;
                    //Error de Williams
                    txtPass.UseSystemPasswordChar = true;
                }



            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message, "Ingrese contraseña");
            }
        }
    }
}
