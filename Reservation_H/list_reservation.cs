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
    public partial class list_reservation : Form
    {
        reservation_hotelEntities reser = new reservation_hotelEntities();
        public list_reservation()
        {
            InitializeComponent();
        }

        private void list_reservation_Load(object sender, EventArgs e)
        {
            dataGridView_reser.DataSource = (from r in reser.Reservations
                                             select new { r.idReservation, r.client, r.chambre, r.typeReservation, r.dateArrive, r.dateDepart }).ToList();
        }

        private void button_quitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
