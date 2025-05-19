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
    public partial class PrestamoE : Form
    {
        public PrestamoE()
        {
            InitializeComponent();
        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

    }
}
