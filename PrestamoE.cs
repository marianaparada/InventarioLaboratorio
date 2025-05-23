using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InventarioLaboratorio
{
    public partial class PrestamoE : Form
    {
       
        private readonly string rutaMateriales = Path.Combine(Application.StartupPath, "materiales.txt");
        private readonly string rutaDeuda = Path.Combine(Application.StartupPath, "deuda.txt");

        public PrestamoE()
        {
            InitializeComponent();
            CargarMateriales();
            ConfigurarDGV();
        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void CargarMateriales()
        {
            cbMat.Items.Clear();
            if (!File.Exists(rutaMateriales))
            {
                MessageBox.Show($"No se encontró materiales.txt en:\n{rutaMateriales}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var linea in File.ReadAllLines(rutaMateriales))
            {
                var datos = linea.Split(',');
                if (datos.Length >= 5)
                    cbMat.Items.Add($"{datos[1].Trim()} - {datos[2].Trim()}");  // "ID - Nombre"
            }

            if (cbMat.Items.Count > 0)
                cbMat.SelectedIndex = 0;
        }

        private void ConfigurarDGV()
        {
            dgvCarrito.Rows.Clear();
            dgvCarrito.Columns.Add("Prioridad", "Prioridad");
            dgvCarrito.Columns.Add("ID", "ID");
            dgvCarrito.Columns.Add("Nombre", "Nombre del Material o Reactivo");
            dgvCarrito.Columns.Add("Tipo", "Tipo del Material o Reactivo");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad Prestada");

        }

        private void RegistrarDeuda(string fecha, string registro, string nombreEstudiante,
                                    string id, string nombreMaterial, int cantidad)
        {
            using var sw = File.AppendText(rutaDeuda);
            sw.WriteLine($"{fecha},{registro},{nombreEstudiante},{id},{nombreMaterial},{cantidad}");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbMat.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtNomE.Text) ||
                string.IsNullOrWhiteSpace(txtNroReg.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantPrestada = (int)numericUpDown1.Value;
            if (cantPrestada <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccionado = cbMat.SelectedItem.ToString().Split('-')[0].Trim();
            var lineasMat = File.ReadAllLines(rutaMateriales).ToList();

            bool encontrado = false;
            int stock = 0;
            string prioridad = "", nombre = "", tipo = "";

            for (int i = 0; i < lineasMat.Count; i++)
            {
                var d = lineasMat[i].Split(',');
                if (d.Length >= 5 && d[1].Trim() == seleccionado)
                {
                    encontrado = true;
                    prioridad = d[0].Trim();
                    nombre = d[2].Trim();
                    tipo = d[3].Trim();
                    stock = int.Parse(d[4]);
                    break;
                }
            }

            if (!encontrado || cantPrestada > stock)
            {
                MessageBox.Show("Material no encontrado o stock insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == seleccionado)
                {
                    int actual = int.Parse(row.Cells["Cantidad"].Value.ToString());
                    if (actual + cantPrestada > stock)
                    {
                        MessageBox.Show("Excede stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    row.Cells["Cantidad"].Value = actual + cantPrestada;
                    return;
                }
            }

            dgvCarrito.Rows.Add(prioridad, seleccionado, nombre, tipo, cantPrestada);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para quitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in dgvCarrito.SelectedRows)
                dgvCarrito.Rows.Remove(row);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomE.Text) || string.IsNullOrWhiteSpace(txtNroReg.Text))
            {
                MessageBox.Show("Ingrese nombre y registro del estudiante.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var matLines = File.ReadAllLines(rutaMateriales).ToList();
            string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            string registro = txtNroReg.Text.Trim();
            string alumno = txtNomE.Text.Trim();

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                string id = row.Cells["ID"].Value.ToString();
                string nom = row.Cells["Nombre"].Value.ToString();
                int qty = int.Parse(row.Cells["Cantidad"].Value.ToString());

                
                RegistrarDeuda(fecha, registro, alumno, id, nom, qty);

                
                for (int i = 0; i < matLines.Count; i++)
                {
                    var d = matLines[i].Split(',');
                    if (d[1].Trim() == id)
                    {
                        int prev = int.Parse(d[4]);
                        d[4] = (prev - qty).ToString();
                        matLines[i] = string.Join(",", d);
                        break;
                    }
                }
            }

            
            File.WriteAllLines(rutaMateriales, matLines);
            MessageBox.Show("Préstamo registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvCarrito.Rows.Clear();
        }
    }
}
