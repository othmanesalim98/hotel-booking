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
    public partial class Paiment_form : Form
    {
        reservEntities3 reser = new reservEntities3();
        BindingSource bs_paiment = new BindingSource();

        public Paiment_form()
        {
            InitializeComponent();
        }

        private void Paiment_form_Load(object sender, EventArgs e)
        {
         bs_paiment.DataSource = (from i in reser.Detail_Paiment select i).ToList();
            var fact= (from i in reser.Detail_Paiment select i.Facture).ToList();
            comboBox_numF.DataSource = fact;
            var type= (from i in reser.Mode_Payment select i.idMode_Payment).ToList();
            comboBox_modeP.DataSource = type;
               
        }

        private void button_AJ_Click(object sender, EventArgs e)
        {
            var paiment = new Detail_Paiment
            {
                idDetail=int.Parse(textBox_numP.Text),
                Facture=int.Parse(comboBox_numF.Text),
                montantD=Convert.ToDecimal(textBox_Mont.Text),
                datePayement=Convert.ToDateTime(dateTimePicker_DateP.Text),
                modePayment=int.Parse(comboBox_modeP.Text),
                detailModePaiment=textBox_Det.Text
            };
            reser.Detail_Paiment.Add(paiment);
            reser.SaveChanges();
            MessageBox.Show("bein ajouter");
        }

        private void button_Modi_Click(object sender, EventArgs e)
        {
            var modifier = reser.Detail_Paiment.Find(int.Parse(textBox_numP.Text));
            if (modifier != null)
            {
                comboBox_numF.Text = modifier.Facture.ToString();
                textBox_Mont.Text = modifier.montantD.ToString();
                dateTimePicker_DateP.Text = modifier.datePayement.ToString();
                comboBox_modeP.Text = modifier.modePayment.ToString();
                textBox_Det.Text = modifier.detailModePaiment;
                reser.SaveChanges();
                bs_paiment.EndEdit();
                MessageBox.Show("bien modihier");
            }
        }

        private void button_Supp_Click(object sender, EventArgs e)
        {
            var supprimer = reser.Detail_Paiment.Find(int.Parse(textBox_numP.Text));
            if (supprimer != null)
            {
                reser.Detail_Paiment.Remove(supprimer);
                reser.SaveChanges();
                bs_paiment.Remove(bs_paiment.Position);
                MessageBox.Show("bien supperimer");
            }
        }

        private void button_quitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_modeP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var descr = reser.Mode_Payment.Find(int.Parse(comboBox_modeP.Text));
            textBox_Det.Text = descr.typePayment;
        }

        private void button_RE_Click(object sender, EventArgs e)
        {
            try
            {
                var recherche = reser.Detail_Paiment.Find(int.Parse(textBox_numP.Text));
                if (recherche != null)
                {
                    bs_paiment.Position = bs_paiment.IndexOf(recherche);
                }
            }
            catch
            {
                MessageBox.Show("le numéro n'existe pas");
            }
        }
    }
}
