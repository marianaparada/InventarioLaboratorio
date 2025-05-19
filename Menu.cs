using System;
using System.Windows.Forms;
using System.Drawing;

namespace InventarioLaboratorio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            btnDeuda.Click += btnDeuda_Click;
            btnPrestamo.Click += btnPrestamo_Click;
            btnListaInv.Click += btnListaInv_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void btnDeuda_Click(object sender, EventArgs e)
        {
            DeudaE deudaE = new DeudaE();
            deudaE.Show();
            this.Hide();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            PrestamoE prestamoE = new PrestamoE();
            prestamoE.Show();
            this.Hide();
        }

        private void btnListaInv_Click(object sender, EventArgs e)
        {
            ListaInv listaInv = new ListaInv();
            listaInv.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }

        private void btnDeuda_Click_1(object sender, EventArgs e)
        {

        }
    }
}
