using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioLaboratorio
{
    public partial class DeudaE : Form
    {
        private Stack<Devolucion> pilaDevoluciones = new Stack<Devolucion>();
        private PriorityQueue<Devolucion, int> devolucionesPrioritarias = new PriorityQueue<Devolucion, int>();
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

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            string registro = txtRegD.Text;
            string codigoMaterial = txtIDD.Text;
            int cantidadDevolver;

            if (string.IsNullOrEmpty(registro) || string.IsNullOrEmpty(codigoMaterial) || !int.TryParse(txtCantD.Text, out cantidadDevolver))
            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return;
            }
            DevolverMaterial(registro, codigoMaterial, cantidadDevolver);
        }
        private void DevolverMaterial(string registro, string codigoMaterial, int cantidadDevolver)
        {
            Queue<Deuda> deudas = LeerDeudas();
            List<Material> materiales = LeerMateriales();
            Deuda deudaEncontrada = deudas.FirstOrDefault(d => d.Registro == registro && d.CodigoMaterial == codigoMaterial);

            if (deudaEncontrada == null)
            {
                MessageBox.Show("No se encontró la deuda con el registro y código de material proporcionados.");
                return;
            }
            if (cantidadDevolver > deudaEncontrada.Cantidad)
            {
                MessageBox.Show("No se pudo devolver por exceder la cantidad prestada");
                return;
            }
            deudaEncontrada.Cantidad -= cantidadDevolver;

            if (deudaEncontrada.Cantidad == 0)
            {
                deudas = new Queue<Deuda>(deudas.Where(d => d.Cantidad > 0));
            }
            Material material = materiales.FirstOrDefault(m => m.CodigoMaterial == codigoMaterial);

            if (material != null)
            {
                material.CantidadDisponible += cantidadDevolver;
            }
            else
            {
                MessageBox.Show("No se encontró el material con el código proporcionado.");
                return;
            }

            GuardarDeudas(deudas);
            GuardarMateriales(materiales);

            if (!string.IsNullOrEmpty(deudaEncontrada.NombreEstudiante) && !string.IsNullOrEmpty(deudaEncontrada.NombreMaterial))
            {
                var devolucion = new Devolucion
                {
                    Fecha = DateTime.Now.ToString("dd-MM-yyyy"),
                    Registro = registro,
                    NombreEstudiante = deudaEncontrada.NombreEstudiante,
                    CodigoMaterial = codigoMaterial,
                    NombreMaterial = deudaEncontrada.NombreMaterial,
                    Cantidad = cantidadDevolver
                };
                if (material.Prioridad == 1)
                {
                    devolucionesPrioritarias.Enqueue(devolucion, 1);
                }
                else
                {
                    pilaDevoluciones.Push(devolucion);
                }
                MessageBox.Show("Devolución registrada correctamente.");
            }
        }
        private Queue<Deuda> LeerDeudas()
        {
            Queue<Deuda> deudas = new Queue<Deuda>();
            if (File.Exists("deudas.txt"))
            {
                foreach (var linea in File.ReadAllLines("deudas.txt"))
                {
                    var datos = linea.Split(',');
                    if (datos.Length == 6 && int.TryParse(datos[5], out int cantidad))
                    {
                        deudas.Enqueue(new Deuda
                        {
                            Fecha = datos[0],
                            Registro = datos[1],
                            NombreEstudiante = datos[2],
                            CodigoMaterial = datos[3],
                            NombreMaterial = datos[4],
                            Cantidad = cantidad
                        });
                    }
                }
            }
            return deudas;
        }
        private List<Material> LeerMateriales()
        {
            List<Material> materiales = new List<Material>();
            if (File.Exists("materiales.txt"))
            {
                foreach (var linea in File.ReadAllLines("materiales.txt"))
                {
                    var datos = linea.Split(',');
                    if (datos.Length >= 3 && int.TryParse(datos[1], out int cantidad) && int.TryParse(datos[2], out int prioridad))
                    {
                        materiales.Add(new Material
                        {
                            CodigoMaterial = datos[0],
                            CantidadDisponible = cantidad,
                            Prioridad = prioridad
                        });
                    }
                }

            }
            return materiales;
        }
        private void GuardarDeudas(Queue<Deuda> deudas)
        {
            using (StreamWriter sw = new StreamWriter("deudas.txt"))
            {
                foreach (var deuda in deudas)
                {
                    sw.WriteLine($"{deuda.Fecha},{deuda.Registro},{deuda.NombreEstudiante},{deuda.CodigoMaterial},{deuda.NombreMaterial},{deuda.Cantidad}");
                }
            }
        }
        private void GuardarMateriales(List<Material> materiales)
        {
            using (StreamWriter sw = new StreamWriter("materiales.txt"))
            {
                foreach (var material in materiales)
                {
                    sw.WriteLine($"{material.CodigoMaterial},{material.CantidadDisponible},{material.Prioridad}");
                }
            }
        }
        private void ActualizardataGridView1()
        {
            var deudas = LeerDeudas();
            dataGridView1.Rows.Clear();
            foreach (var d in deudas)
            {
                dataGridView1.Rows.Add(d.Fecha, d.Registro, d.NombreEstudiante, d.CodigoMaterial, d.NombreMaterial, d.Cantidad);
            }
        }
        public class Deuda
        {
            public string Fecha { get; set; }
            public string Registro { get; set; }
            public string NombreEstudiante { get; set; }
            public string CodigoMaterial { get; set; }
            public string NombreMaterial { get; set; }
            public int Cantidad { get; set; }
        }
        public class Material
        {
            public string CodigoMaterial { get; set; }
            public int CantidadDisponible { get; set; }
            public int Prioridad { get; set; } // 1 for high priority, 0 for low priority
        }
        public class Devolucion
        {
            public string Fecha { get; set; }
            public string Registro { get; set; }
            public string NombreEstudiante { get; set; }
            public string CodigoMaterial { get; set; }
            public string NombreMaterial { get; set; }
            public int Cantidad { get; set; }
        }
    }
}
