using ReservasCamping_BE.entidades;
using ReservasCamping_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasCamping
{
    public partial class ABM : Form
    {
        public ABM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var acceso = new ConnectionDAL.Acceso();
            var reservaDAL = new ReservaDAL(acceso);

            // Validar y parsear entradas
            if (!int.TryParse(textIDHuesped.Text, out int idHuesped))
            {
                MessageBox.Show("ID Huesped tiene que ser un entero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textIDParcela.Text, out int idParcela))
            {
                MessageBox.Show("ID Parcela tiene que ser un entero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textCantidad.Text, out int cantidadPersonas))
            {
                MessageBox.Show("Cantidad de Personas tiene que ser un entero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal? montoTotal = null;
            if (!string.IsNullOrWhiteSpace(textMonto.Text))
            {
                if (decimal.TryParse(textMonto.Text, out decimal monto))
                {
                    montoTotal = monto;
                }
                else
                {
                    MessageBox.Show("Monto Total tiene que ser un numero natural.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            var nuevaReserva = new ReservasCamping.BE.entidades.Reserva
            {
                IdHuesped = idHuesped,
                IdParcela = idParcela,
                FechaInicio = dateInicio.Value,
                FechaFin = dateFin.Value,
                CantidadPersonas = cantidadPersonas,
                MontoTotal = montoTotal,
                Estado = comboestado.SelectedItem?.ToString() ?? ""
            };

            reservaDAL.Insert(nuevaReserva);
        }

        private void btnAgregarReserva_Click(object sender, EventArgs e)
        {
        

   
        }

        private void comboestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
