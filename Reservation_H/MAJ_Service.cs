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
    public partial class MAJ_Service : Form
    {
        reservation_hotelEntities reser = new reservation_hotelEntities();
        BindingSource bs_service = new BindingSource();
        public MAJ_Service()
        {
            InitializeComponent();
        }

        private void button_AJ_Click(object sender, EventArgs e)
        {
            var service = new Service
            {
                idService=int.Parse(textBox_IdSER.Text),
                nomService=textBox_Nm.Text,
                prix_Se=Convert.ToDecimal(textBoxprix.Text)
            };
            reser.Services.Add(service);
            reser.SaveChanges();
            MessageBox.Show("bein ajouter");
        }

        private void button_Modi_Click(object sender, EventArgs e)
        {
            var modifier = reser.Services.Find(int.Parse(textBox_IdSER.Text));
            if(modifier!=null)
            {
                textBox_IdSER.Text = modifier.idService.ToString();
                textBox_Nm.Text = modifier.nomService;
                textBoxprix.Text = modifier.prix_Se.ToString();
                reser.SaveChanges();
                bs_service.EndEdit();
                MessageBox.Show("bien modihier");
            }
        }

        private void button_Supp_Click(object sender, EventArgs e)
        {
            var supprimer = reser.Services.Find(int.Parse(textBox_IdSER.Text));
            if(supprimer!=null)
            {
                reser.Services.Remove(supprimer);
                reser.SaveChanges();
                bs_service.Remove(bs_service.Position);
                MessageBox.Show("bien supperimer");
            }
        }

        private void button_RE_Click(object sender, EventArgs e)
        {
            var recherche = reser.Services.Find(int.Parse(textBox_re.Text));
            if(recherche!=null)
            {
               // bs_service.Position = bs_service.IndexOf(recherche);

                 textBox_IdSER.Text = recherche.idService.ToString();
                 textBox_Nm.Text = recherche.nomService;
                 textBoxprix.Text = recherche.prix_Se.ToString();
            }
        }

        private void button_quitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MAJ_Service_Load(object sender, EventArgs e)
        {
            bs_service.DataSource = (from i in reser.Services select i).ToList();
        }
    }
}
