using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InventarioLaboratorio
{
    public partial class ListaInv : Form
    {
        private readonly string rutaMateriales = Path.Combine(Application.StartupPath,"materiales.txt");
        public ListaInv()
        {
            InitializeComponent();
            Load += ListaInv_Load;

        }
        private void ListaInv_Load(object sender, EventArgs e)
        {
            CargarMateriales();
        }
        private void btnRLI_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void CargarMateriales()
        {
            try
            {
                if (File.Exists(rutaMateriales))
                {
                    cbBaja.Items.Clear();
                    dgvMatReac.Rows.Clear();
                    dgvMatReac.Columns.Add("Cpriori", "Prioridad");
                    dgvMatReac.Columns.Add("Cidmr", "ID");
                    dgvMatReac.Columns.Add("Cnommr", "Nombre del Material o Reactivo");
                    dgvMatReac.Columns.Add("Ctipo", "Tipo del Material o Reactivo");
                    dgvMatReac.Columns.Add("Ccant", "Cantidad disponible");

                    string[] lineas = File.ReadAllLines(rutaMateriales);
                    foreach (string line in lineas)
                    {
                        string[] datos = line.Split(',');
                        if (datos.Length >= 5)
                        {
                            var id = datos[1].Trim();
                            var nombre = datos[2].Trim();
                            dgvMatReac.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                            cbBaja.Items.Add($"{id} - {nombre}");
                        }
                        if (cbBaja.Items.Count > 0)
                        {
                            cbBaja.SelectedIndex = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo.txt no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar materiales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPriori.Text, out int prio) ||
                string.IsNullOrWhiteSpace(txtIDmr.Text) ||
                string.IsNullOrWhiteSpace(txtNommr.Text) ||
                string.IsNullOrWhiteSpace(txtTipomr.Text) ||
                !int.TryParse(txtCantrm.Text, out int cant))
            {
                MessageBox.Show("Complete todos los campos de ingreso correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Leer líneas existentes
                List<string> lines = File.Exists(rutaMateriales)
                    ? File.ReadAllLines(rutaMateriales).ToList()
                    : new List<string>();

                // Añadir nuevo registro
                lines.Add($"{prio},{txtIDmr.Text.Trim()},{txtNommr.Text.Trim()},{txtTipomr.Text.Trim()},{cant}");
                File.WriteAllLines(rutaMateriales, lines);

                // Recargar
                CargarMateriales();
                MessageBox.Show("Elemento agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar elemento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (cbBaja.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un elemento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parts = cbBaja.SelectedItem.ToString().Split(new[] { '-' }, 2);
            string idEliminar = parts[0].Trim();

            // Obtener cantidad a restar del NumericUpDown
            if (cbBaja.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un elemento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Separar ID y Nombre
            var selected = cbBaja.SelectedItem.ToString();
            parts = selected.Split(new[] { '-' }, 2);
            idEliminar = parts[0].Trim();

            // Cantidad a baja desde NumericUpDown
            var cantidadBaja = (int)nupCB.Value;
            if (cantidadBaja <= 0)
            {
                MessageBox.Show("La cantidad de baja debe ser mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var updatedLines = new List<string>();

                foreach (string line in File.ReadAllLines(rutaMateriales))
                {
                    var datos = line.Split(',');
                    if (datos.Length < 5)
                    {
                        updatedLines.Add(line);
                        continue;
                    }

                    if (datos[1].Trim() == idEliminar)
                    {
                        // Restar cantidad
                        if (int.TryParse(datos[4], out int existente))
                        {
                            int resto = existente - cantidadBaja;
                            if (resto > 0)
                            {
                                // Actualizar registro con nueva cantidad
                                updatedLines.Add($"{datos[0]},{datos[1]},{datos[2]},{datos[3]},{resto}");
                            }
                            // Si resto <= 0, se elimina el registro por completo
                        }
                    }
                    else
                    {
                        updatedLines.Add(line);
                    }
                }

                // Escribir cambios en archivo raíz
                File.WriteAllLines(rutaMateriales, updatedLines);

                // Recargar
                CargarMateriales();
                MessageBox.Show("Baja procesada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar elemento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
