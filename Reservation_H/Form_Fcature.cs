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
    public partial class Form_Fcature : Form
    {
        reservation_hotelEntities reser = new reservation_hotelEntities();
        public Form_Fcature()
        {
            InitializeComponent();
        }

        private void Form_Fcature_Load(object sender, EventArgs e)
        {
            var fac = (from f in reser.Factures
                       select new { f.idFacture, f.reservation, f.montant, f.statusF }).ToList();
            dataGridView1.DataSource = fac;
            comboBox1.DisplayMember = "statusF";
            comboBox1.DataSource = (from a in reser.Factures select a.statusF).Distinct().ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from r in reser.Factures
                                        where r.statusF.Equals(comboBox1.Text)
                                        select new { r.idFacture, r.reservation, r.montant, r.statusF }).ToList();
        }

        private void button_quitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
