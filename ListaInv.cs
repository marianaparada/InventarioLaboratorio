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
    public partial class ListaInv : Form
    {
        private readonly string rutaMateriales = "materiales.txt";
        public ListaInv()
        {
            InitializeComponent();
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
                    listBoxMatReac.Items.Clear();
                    string[] lineas = File.ReadAllLines(rutaMateriales);
                    foreach (string line in lineas)
                    {
                        string[] datos = line.Split(',');
                        if (datos.Length >= 5)
                        {
                            string prioridad = datos[0];
                            string id = datos[1];
                            string nombre = datos[2];
                            string material = datos[3];
                            string cantidad = datos[4];

                            listBoxMatReac.Items.Add($"Prioridad: {prioridad} | ID: {id} | {nombre} ({material}) - Cantidad: {cantidad}");
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
        }
    }
