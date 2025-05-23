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
                MessageBox.Show($"No se encontró materiales.txt en:\n{rutaMateriales}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var linea in File.ReadAllLines(rutaMateriales))
            {
                var datos = linea.Split(',');
                if (datos.Length >= 5)
                    cbMat.Items.Add($"{datos[1].Trim()} - {datos[2].Trim()}");
            }

            if (cbMat.Items.Count > 0)
                cbMat.SelectedIndex = 0;
        }

        private void ConfigurarDGV()
        {
            dgvCarrito.Rows.Clear();
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.Columns.Clear();

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

        private string[] BuscarMaterialPorID(string id)
        {
            foreach (var linea in File.ReadAllLines(rutaMateriales))
            {
                var datos = linea.Split(',');
                if (datos.Length >= 5 && datos[1].Trim() == id)
                    return datos;
            }
            return null;
        }

        private bool ValidarCamposEstudiante()
        {
            return !string.IsNullOrWhiteSpace(txtNomE.Text) && !string.IsNullOrWhiteSpace(txtNroReg.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbMat.SelectedIndex < 0 || !ValidarCamposEstudiante())
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantPrestada = (int)numericUpDown1.Value;
            if (cantPrestada <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccionado = cbMat.SelectedItem.ToString().Split('-')[0].Trim();

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.IsNewRow) continue;
                string idFila = Convert.ToString(row.Cells["ID"].Value);
                if (idFila == seleccionado)
                {
                    MessageBox.Show("Este material ya está en el carrito.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            var datos = BuscarMaterialPorID(seleccionado);
            if (datos == null || !int.TryParse(datos[4], out int stock) || cantPrestada > stock)
            {
                MessageBox.Show("Material no encontrado o stock insuficiente.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string prioridad = datos[0].Trim();
            string nombre = datos[2].Trim();
            string tipo = datos[3].Trim();

            dgvCarrito.Rows.Add(prioridad, seleccionado, nombre, tipo, cantPrestada);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para quitar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgvCarrito.SelectedRows)
                if (!row.IsNewRow)
                    dgvCarrito.Rows.Remove(row);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposEstudiante())
            {
                MessageBox.Show("Ingrese nombre y registro del estudiante.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(rutaMateriales))
            {
                MessageBox.Show("No se encontró el archivo de materiales.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var matLines = File.ReadAllLines(rutaMateriales).ToList();
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string registro = txtNroReg.Text.Trim();
            string alumno = txtNomE.Text.Trim();

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.IsNewRow) continue;

                string id = Convert.ToString(row.Cells["ID"].Value);
                string nom = Convert.ToString(row.Cells["Nombre"].Value);
                int.TryParse(Convert.ToString(row.Cells["Cantidad"].Value), out int qty);

                RegistrarDeuda(fecha, registro, alumno, id, nom, qty);

                for (int i = 0; i < matLines.Count; i++)
                {
                    var d = matLines[i].Split(',');
                    if (d.Length >= 5 && d[1].Trim() == id)
                    {
                        int.TryParse(d[4], out int prev);
                        int nuevoStock = Math.Max(0, prev - qty);
                        d[4] = nuevoStock.ToString();
                        matLines[i] = string.Join(",", d);
                        break;
                    }
                }
            }

            File.WriteAllLines(rutaMateriales, matLines);
            MessageBox.Show("Préstamo registrado con éxito.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvCarrito.Rows.Clear();
            txtNomE.Clear();
            txtNroReg.Clear();
        }
    }
}

