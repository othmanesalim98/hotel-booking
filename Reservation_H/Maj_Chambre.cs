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
    public partial class Maj_Chambre : Form
    {
        reservation_hotelEntities reser = new reservation_hotelEntities();
        BindingSource bs_chambre = new BindingSource();
        public Maj_Chambre()
        {
            InitializeComponent();
        }

        private void Maj_Chambre_Load(object sender, EventArgs e)
        {
            bs_chambre.DataSource = (from i in reser.Chambres select i).ToList();
            var type = (from t in reser.TypeChambres  select t.idTypeChambre).ToList();
            comboBox_type.DataSource = type;
            comboBox_etat.Items.Add("dispo");
            comboBox_etat.Items.Add("not dispo");
        }

        private void button_AJ_Click(object sender, EventArgs e)
        {
            if(button_AJ.Text.Equals("Nouveau"))
            {
                bs_chambre.AddNew();
                button_AJ.Text = "Ajouter";
            }
            else if(button_AJ.Text.Equals("Ajouter"))
            {
                var chembre = new Chambre
                {
                    idChambre = int.Parse(textBox_num.Text),
                    nomChambre=textBox_nom.Text,
                    etat=comboBox_etat.Text,
                    typeChambre=int.Parse(comboBox_type.Text),
                    prix_Ch=Convert.ToDecimal(textBox_prix.Text)
                };
                reser.Chambres.Add(chembre);
                reser.SaveChanges();
                MessageBox.Show("Bien Ajouter");
            }
        }

        private void button_Modi_Click(object sender, EventArgs e)
        {
            var modifier = reser.Chambres.Find(int.Parse(textBox_num.Text));
            if (modifier != null)
            { 
                textBox_nom.Text = modifier.nomChambre;
                comboBox_etat.Text = modifier.etat;
                textBox_prix.Text = modifier.prix_Ch.ToString();
                comboBox_type.Text = modifier.typeChambre.ToString();
                reser.SaveChanges();
                bs_chambre.EndEdit();
                MessageBox.Show("bien modifier");
            }
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            var descr = reser.TypeChambres.Find(int.Parse(comboBox_type.Text));
            textBox_descr.Text = descr.description;
        }

        private void button_Supp_Click(object sender, EventArgs e)
        {
            var supprimer = reser.Chambres.Find(int.Parse(textBox_num.Text));
            if(supprimer!=null)
            {
                reser.Chambres.Remove(supprimer);
                reser.SaveChanges();
                bs_chambre.Remove(bs_chambre.Position);
                MessageBox.Show("bien supperimer");
            }
        }

        private void button_RE_Click(object sender, EventArgs e)
        {
            try 
            {
                var recherche = reser.Chambres.Find(int.Parse(textBox_num.Text));
            if (recherche != null)
            {
                bs_chambre.Position = bs_chambre.IndexOf(recherche);
            }
            }
            catch
            {
                MessageBox.Show("le numéro n'existe pas");
            }
           
        }

        private void button_quitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
