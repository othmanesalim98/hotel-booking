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
    public partial class list_client : Form
    {
        reservation_hotelEntities reser = new reservation_hotelEntities();
        public list_client()
        {
            InitializeComponent();
        }

        private void list_client_Load(object sender, EventArgs e)
        {
            var listclie = (from list in reser.Clients
                            select new { list.idClient, list.nom, list.prenom, list.telephone, list.email, list.ville, list.CIN, list.date_naisance }).ToList();

            dataGridView1.DataSource = listclie;
        }

        private void button_quitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
