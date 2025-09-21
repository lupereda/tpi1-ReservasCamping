using ReservasCamping_DAL;
using ReservasCamping.BE.entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReservasCamping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarReservas();
        }

        private void CargarReservas()
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                var acceso = new ConnectionDAL.Acceso();
                var reservaDAL = new ReservaDAL(acceso);
                reservas = reservaDAL.GetAll();
            }
            catch (Exception)
            {
                // Si falla la conexión, reservas queda vacío
            }
            dataGridViewReservas.DataSource = reservas;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABM frm = new ABM();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
