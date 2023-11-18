using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_H
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            customozedisign();
        }

        private void panel_conte_Paint(object sender, PaintEventArgs e)
        {

        }
        //Constructor

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int lx, ly;
        int sw, sh;

        private void btn_reduir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            btn_max.Visible = true;
            btn_min.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btn_max.Visible = false;
            btn_min.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void panel_titolo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel_forme.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel_forme.Controls.Add(formulario);
                panel_forme.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void hideSubMenu()
        {
            if (panel_client.Visible == true)
                panel_client.Visible = false;
            if (panel_chambre.Visible == true)
                panel_chambre.Visible = false;
            if (panel_reserv.Visible == true)
                panel_reserv.Visible = false;
            if (panel_service.Visible == true)
                panel_service.Visible = false;
            if (panel_facture.Visible == true)
                panel_facture.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_forme.Controls.Add(childForm);
            panel_forme.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

     

        private void customozedisign()
        {
            panel_client.Visible = false;
            panel_chambre.Visible = false;
            panel_reserv.Visible = false;
            panel_service.Visible = false;
            panel_facture.Visible = false;
        }


        private void btn_facture_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_facture);
        }


        private void btn_client_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel_client);
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel_chambre);
        }

        private void btn_reser_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel_reserv);
        }

        private void Btn_majclient_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Maj_client>();
            hideSubMenu();
        }

        private void btn_list_client_Click(object sender, EventArgs e)
        {
            AbrirFormulario<list_client>();
            hideSubMenu();
        }

        private void btn_majchambre_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Maj_Chambre>();
            hideSubMenu();
        }

        private void btn_typechembre_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form_TypeChambre>();
            hideSubMenu();
        }

        private void btn_disponible_Click(object sender, EventArgs e)
        {
            AbrirFormulario<disponibles>();
            hideSubMenu();
        }

        private void btn_maj_reserv_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MAJ_Reservation>();
            hideSubMenu();
        }

        private void btn_list_reserv_Click(object sender, EventArgs e)
        {
            AbrirFormulario<list_reservation>();
            hideSubMenu();
        }

        private void btn_majservice_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MAJ_Service>();
            hideSubMenu();
        }

        private void btn_dommand_service_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Demmande_Service>();
            hideSubMenu();
        }

        private void btn_formFacture_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form_Fcature>();
            hideSubMenu();
        }

        private void btn_paiment_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Paiment_form>();
            hideSubMenu();
        }

        private void panel_forme_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_service_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel_service);
        }

        private void btn_facture_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel_facture);
        }

    }
}
