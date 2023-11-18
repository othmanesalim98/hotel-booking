using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_H
{
    public partial class Form_TypeChambre : Form
    {
        reservation_hotelEntities reser = new reservation_hotelEntities();
        BindingSource bs_typeC = new BindingSource();
        
        public Form_TypeChambre()
        {
            InitializeComponent();
        }

        private void button_AJ_Click(object sender, EventArgs e)
        {
            var typeC = new TypeChambre
            { 
                idTypeChambre=int.Parse(textBox_id.Text),
                description=textBox_descrip.Text
            };
            reser.TypeChambres.Add(typeC);
            reser.SaveChanges();
            MessageBox.Show("bein ajouter");
        }

        private void button_Supp_Click(object sender, EventArgs e)
        {
            var supprimer = reser.TypeChambres.Find(int.Parse(textBox_id.Text));
            if(supprimer!=null)
            {
                reser.TypeChambres.Remove(supprimer);
                reser.SaveChanges();
                bs_typeC.Remove(bs_typeC.Position);
                MessageBox.Show("bien supperimer");
            }
        }

        private void button_RE_Click(object sender, EventArgs e)
        {
            var recherch = reser.TypeChambres.Find(int.Parse(textBox_Rch.Text));
            if(recherch!=null)
            {
                //bs_typeC.Position = bs_typeC.IndexOf(recherch);
                textBox_id.Text = recherch.idTypeChambre.ToString();
                textBox_descrip.Text = recherch.description;
            }
        }

        private void button_quitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_TypeChambre_Load(object sender, EventArgs e)
        {

        }
    }
}
