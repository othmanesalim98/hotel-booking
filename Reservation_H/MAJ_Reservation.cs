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
    public partial class MAJ_Reservation : Form
    {
        reservation_hotelEntities reser = new reservation_hotelEntities();
        BindingSource bs_reserve = new BindingSource();
        public MAJ_Reservation()
        {
            InitializeComponent();
        }

        private void MAJ_Reservation_Load(object sender, EventArgs e)
        {
            bs_reserve.DataSource = (from i in reser.Reservations select i).ToList();
            var ch = (from c in reser.Chambres select c.idChambre).ToList();
            comboBox_Chambre.DataSource = ch;
            comboBox_type.Items.Add("Open");
            comboBox_type.Items.Add("Close");
        }

        private void button_AJ_Click(object sender, EventArgs e)
        {
            if (button_AJ.Text.Equals("Nouveau"))
            {
                bs_reserve.AddNew();
                button_AJ.Text = "Ajouter";
            }
            else if (button_AJ.Text.Equals("Ajouter"))
            {
                var rserve = new Reservation
                {
                    idReservation = int.Parse(textBox_num.Text),
                    chambre = int.Parse(comboBox_Chambre.Text),
                    client = int.Parse(textBox_cl.Text),
                    typeReservation = comboBox_type.Text,
                    dateReservation = Convert.ToDateTime(dateTimePicker_res.Text),
                    dateArrive = Convert.ToDateTime(dateTimePicker_arriv.Text),
                    dateDepart=Convert.ToDateTime(dateTimePicker_dep.Text)
                };
                reser.Reservations.Add(rserve);
                reser.SaveChanges();
                MessageBox.Show("Bien Ajouter");
            }
        }

        private void button_Modi_Click(object sender, EventArgs e)
        {
            var modifier = reser.Reservations.Find(int.Parse(textBox_num.Text));
            if(modifier!=null)
            {
                comboBox_Chambre.Text = modifier.chambre.ToString();
                textBox_cl.Text = modifier.client.ToString();
                comboBox_type.Text = modifier.typeReservation;
                dateTimePicker_res.Text = modifier.dateReservation.ToString();
                dateTimePicker_arriv.Text = modifier.dateArrive.ToString();
                dateTimePicker_dep.Text = modifier.dateDepart.ToString();
                reser.SaveChanges();
                bs_reserve.EndEdit();
                MessageBox.Show("bien modifier");
            }
        }

        private void button_RE_Click(object sender, EventArgs e)
        {
            try 
            { var recherche = reser.Reservations.Find(int.Parse(textBox_re.Text));
            if(recherche!=null)
            {
                bs_reserve.Position = bs_reserve.IndexOf(recherche);
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
