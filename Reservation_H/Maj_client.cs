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
    public partial class Maj_client : Form
    {
        reservation_hotelEntities reser = new reservation_hotelEntities();
        BindingSource bs_client = new BindingSource();
        public Maj_client()
        {
            InitializeComponent();
        }
   private void add_client_Load(object sender, EventArgs e)
        {
            bs_client.DataSource = (from i in reser.Clients select i).ToList();
            textBox_idcl.DataBindings.Add("text", bs_client, "idClient", true);
            textBox_nom.DataBindings.Add("text", bs_client, "nom", true);
            textBox_prenom.DataBindings.Add("text", bs_client, "prenom", true);
            textBox_cin.DataBindings.Add("text", bs_client, "CIN", true);
            textBox_vill.DataBindings.Add("text", bs_client, "ville", true);
            dateTimePicker1.DataBindings.Add("text", bs_client, "date_naisance", true);
            textBox_telec.DataBindings.Add("text", bs_client, "telephone", true);
            textBox_email.DataBindings.Add("text", bs_client, "email", true);

        }
        private void button_AJ_Click(object sender, EventArgs e)
        {
            if(button_AJ.Text.Equals("Nouveau"))
            {
                bs_client.AddNew();
                button_AJ.Text = "Ajouter";
            }
            else if(button_AJ.Text.Equals("Ajouter"))
            {
                var client = new Client
                {
                    idClient=int.Parse(textBox_idcl.Text),
                    nom=textBox_nom.Text,
                    prenom=textBox_prenom.Text,
                    CIN=textBox_cin.Text,
                    ville=textBox_vill.Text,
                    date_naisance=Convert.ToDateTime(dateTimePicker1.Text),
                    telephone=textBox_telec.Text,
                    email=textBox_email.Text
                };
                reser.Clients.Add(client);
                reser.SaveChanges();
                MessageBox.Show("Bien Ajouter");
            }
        }

        private void button_Modi_Click(object sender, EventArgs e)
        {
            var modifier = reser.Clients.Find(int.Parse(textBox_idcl.Text));
            if(modifier!=null)
            {
                textBox_nom.Text = modifier.nom;
                textBox_prenom.Text = modifier.prenom;
                textBox_cin.Text = modifier.CIN;
                textBox_vill.Text = modifier.ville;
                dateTimePicker1.Text = modifier.date_naisance.ToString();
                textBox_telec.Text = modifier.telephone;
                textBox_email.Text = modifier.email;
                reser.SaveChanges();
                bs_client.EndEdit();
                MessageBox.Show("bien modifier");
            }
        }

       

        private void button_Supp_Click(object sender, EventArgs e)
        {
            var supprimer =reser.Clients.Find(int.Parse(textBox_idcl.Text));
            if(supprimer!=null)
            {
                reser.Clients.Remove(supprimer);
                reser.SaveChanges();
                bs_client.Remove(bs_client.Position);
                MessageBox.Show("bien supperimer");
            }
        }
      

        private void button_RE_Click(object sender, EventArgs e)
        {
            try
            {
            var recherche = reser.Clients.Find(int.Parse(textBox_re.Text));
            if (recherche != null)
            {
                bs_client.Position = bs_client.IndexOf(recherche);
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
