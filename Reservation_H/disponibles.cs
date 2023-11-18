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
    public partial class disponibles : Form
    {
        reservation_hotelEntities reser = new reservation_hotelEntities();
        public disponibles()
        {
            InitializeComponent();
        }

        private void disponibles_Load(object sender, EventArgs e)
        {
            comboBox_type.DisplayMember = "typeO";
            comboBox_type.DataSource = (from a in reser.OccupChambres
                                        select a.typeO).Distinct().ToList();
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from a in reser.OccupChambres
                                        where a.typeO.Equals(comboBox_type.Text)
                                        select new { a.reservation, a.chambre, a.dateOccup, a.dateDispo }).ToList();
        }

        private void button_quitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
