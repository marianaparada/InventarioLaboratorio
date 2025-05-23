using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InventarioLaboratorio
{
    public partial class ListaInv : Form
    {
        // Ruta al archivo de materiales
        private readonly string rutaMateriales = Path.Combine(Application.StartupPath, "materiales.txt");

        public ListaInv()
        {
            InitializeComponent();
            // Configurar columnas y cargar datos al iniciar
            this.Load += ListaInv_Load;
        }

        private void ListaInv_Load(object sender, EventArgs e)
        {
            ConfigurarDgvMatReac();
            CargarMateriales();
        }

        // Configuración inicial del DataGridView
        private void ConfigurarDgvMatReac()
        {
            
            dgvMatReac.Rows.Clear();
            dgvMatReac.AllowUserToAddRows = false;
            dgvMatReac.Columns.Add("Cpriori", "Prioridad");
            dgvMatReac.Columns.Add("Cidmr", "ID");
            dgvMatReac.Columns.Add("Cnommr", "Nombre del Material o Reactivo");
            dgvMatReac.Columns.Add("Ctipo", "Tipo del Material o Reactivo");
            dgvMatReac.Columns.Add("Ccant", "Cantidad disponible");
        }

        // Carga los datos desde el archivo al ComboBox y DataGridView
        private void CargarMateriales()
        {
            try
            {
                if (!File.Exists(rutaMateriales))
                {
                    MessageBox.Show($"No se encontró 'materiales.txt' en:\n{rutaMateriales}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cbBaja.Items.Clear();
                dgvMatReac.Rows.Clear();

                var lineas = File.ReadAllLines(rutaMateriales);
                foreach (var linea in lineas)
                {
                    var datos = linea.Split(',');
                    if (datos.Length < 5)
                        continue;

                    string prioridad = datos[0].Trim();
                    string id = datos[1].Trim();
                    string nombre = datos[2].Trim();
                    string tipo = datos[3].Trim();
                    string cant = datos[4].Trim();

                    dgvMatReac.Rows.Add(prioridad, id, nombre, tipo, cant);
                    cbBaja.Items.Add($"{id} - {nombre}");
                }

                if (cbBaja.Items.Count > 0)
                    cbBaja.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar materiales: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ingreso de nuevo material al inventario
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (!int.TryParse(txtPriori.Text.Trim(), out int prio) ||
                string.IsNullOrWhiteSpace(txtIDmr.Text) ||
                string.IsNullOrWhiteSpace(txtNommr.Text) ||
                string.IsNullOrWhiteSpace(txtTipomr.Text) ||
                !int.TryParse(txtCantrm.Text.Trim(), out int cant))
            {
                MessageBox.Show("Complete todos los campos de ingreso correctamente.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var lines = File.Exists(rutaMateriales)
                    ? File.ReadAllLines(rutaMateriales).ToList()
                    : new List<string>();

                lines.Add($"{prio},{txtIDmr.Text.Trim()},{txtNommr.Text.Trim()},{txtTipomr.Text.Trim()},{cant}");
                File.WriteAllLines(rutaMateriales, lines);

                CargarMateriales();
                MessageBox.Show("Elemento agregado exitosamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar elemento: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Procesa la baja de stock de un material seleccionado
        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (cbBaja.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un elemento para eliminar.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener ID del elemento seleccionado
            var parts = cbBaja.SelectedItem.ToString().Split(new[] { '-' }, 2);
            string idEliminar = parts[0].Trim();
            int cantidadBaja = (int)nupCB.Value;

            if (cantidadBaja <= 0)
            {
                MessageBox.Show("La cantidad de baja debe ser mayor que 0.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var updatedLines = new List<string>();

                foreach (var linea in File.ReadAllLines(rutaMateriales))
                {
                    var datos = linea.Split(',');
                    if (datos.Length < 5)
                    {
                        updatedLines.Add(linea);
                        continue;
                    }

                    if (datos[1].Trim() == idEliminar)
                    {
                        if (int.TryParse(datos[4], out int existente))
                        {
                            int resto = existente - cantidadBaja;
                            if (resto > 0)
                                updatedLines.Add($"{datos[0]},{datos[1]},{datos[2]},{datos[3]},{resto}");
                            // si resto <=0, se omite para eliminar registro
                        }
                    }
                    else
                    {
                        updatedLines.Add(linea);
                    }
                }

                File.WriteAllLines(rutaMateriales, updatedLines);
                CargarMateriales();
                MessageBox.Show("Baja procesada exitosamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar elemento: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Volver al menú principal
        private void btnRLI_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}