using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Reservation_H
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBox_user_Enter(object sender, EventArgs e)
        {
            if(textBox_user.Text== "Nom D'utilisateur")
            {
                textBox_user.Text = "";
                textBox_user.ForeColor = Color.LightGray;
            }
        }

        private void textBox_user_Leave(object sender, EventArgs e)
        {
            if (textBox_user.Text == "")
            {
                textBox_user.Text = "Nom D'utilisateur";
                textBox_user.ForeColor = Color.DimGray;
            }
        }

        private void textBox_mdp_Enter(object sender, EventArgs e)
        {
            if (textBox_mdp.Text == "Mote De Passe")
            {
                textBox_mdp.Text = "";
                textBox_mdp.ForeColor = Color.LightGray;
                textBox_mdp.UseSystemPasswordChar = true;
            }
        }

        private void textBox_mdp_Leave(object sender, EventArgs e)
        {
            if (textBox_mdp.Text == "")
            {
                textBox_mdp.Text = "Mote De Passe";
                textBox_mdp.ForeColor = Color.DimGray;
                textBox_mdp.UseSystemPasswordChar = false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reduir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
