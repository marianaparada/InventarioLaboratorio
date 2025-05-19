using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioLaboratorio
{
    public partial class DeudaE : Form
    {
        public DeudaE()
        {
            InitializeComponent();
        }

        // Add the missing DeudaE_Load method to resolve the CS1061 error
        private void DeudaE_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here if needed
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void listaDeDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCDE.SelectedIndex = 0;
        }

        private void añadirDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCDE.SelectedIndex = 1; 
        }
    }
}
