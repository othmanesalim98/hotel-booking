using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_H
{
    public partial class Demmande_Service : Form
    {
        reservation_hotelEntities reser = new reservation_hotelEntities();
        BindingSource bs_demend = new BindingSource();
        public Demmande_Service()
        {
            InitializeComponent();
        }

        private void Demmande_Service_Load(object sender, EventArgs e)
        {
            var service = (from i in reser.Services select i.idService).ToList();
            comboBox_idservice.DataSource = service;
        }

        private void button_AJ_Click(object sender, EventArgs e)
        {
            var demande = new Demande_service
            {
                idServiceDemander = int.Parse(textBox2.Text),
                reservation = int.Parse(comboBox2.Text),
                service=int.Parse(comboBox_idservice.Text),
                dateDemande=Convert.ToDateTime(dateTimePicker1.Text)
            };
            reser.Demande_service.Add(demande);
            reser.SaveChanges();
            MessageBox.Show("bein ajouter");
        }

        private void button_Modi_Click(object sender, EventArgs e)
        {
            var modifier = reser.Demande_service.Find(int.Parse(textBox2.Text));
            if(modifier!=null)
            {
                comboBox2.Text = modifier.reservation.ToString();
                comboBox_idservice.Text = modifier.service.ToString();
                dateTimePicker1.Text = modifier.dateDemande.ToString();
                reser.SaveChanges();
                bs_demend.EndEdit();
                MessageBox.Show("bien modihier");
            }
        }

        private void button_Supp_Click(object sender, EventArgs e)
        {
            var supprimer = reser.Demande_service.Find(int.Parse(textBox2.Text));
            if (supprimer != null)
            {
                reser.Demande_service.Remove(supprimer);
                reser.SaveChanges();
                bs_demend.Remove(bs_demend.Position);
                MessageBox.Show("bien supperimer");
            }
        }

        private void button_quitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var serv =reser.Services.Find(int.Parse(comboBox_idservice.Text));
            textBox_Nm.Text = serv.nomService.ToString();
            textBoxprix.Text = serv.prix_Se.ToString();
        }
    }
}
