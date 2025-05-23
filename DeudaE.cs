using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioLaboratorio
{
    public partial class DeudaE : Form
    {
        
        private readonly string rutaDeudas = Path.Combine(Application.StartupPath, "deuda.txt");
        private readonly string rutaMateriales = Path.Combine(Application.StartupPath, "materiales.txt");

        private Stack<Devolucion> pilaDevoluciones = new Stack<Devolucion>();
        private PriorityQueue<Devolucion, int> devolucionesPrioritarias = new PriorityQueue<Devolucion, int>();

        public DeudaE()
        {
            InitializeComponent();
        }

        private void DeudaE_Load(object sender, EventArgs e)
        {
            CargarDeudas();
            ActualizardataGridView1();
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            new Menu().Show();
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
            if (!int.TryParse(txtCantD.Text, out int cantidadDevolver)
                || string.IsNullOrEmpty(registro)
                || string.IsNullOrEmpty(codigoMaterial))
            {
                MessageBox.Show("Todos los campos deben ser completados y la cantidad debe ser un número.");
                return;
            }
            DevolverMaterial(registro, codigoMaterial, cantidadDevolver);
        }

        private void DevolverMaterial(string registro, string codigoMaterial, int cantidadDevolver)
        {
            var deudas = LeerDeudas();
            var materiales = LeerMateriales();

            if (deudas.Count == 0)
            {
                MessageBox.Show("No se encontró ninguna deuda. Verifica que 'deuda.txt' exista y no esté vacío.");
                return;
            }
            if (materiales.Count == 0)
            {
                MessageBox.Show("No se encontró ningún material. Verifica que 'materiales.txt' exista y no esté vacío.");
                return;
            }

            string regBuscado = registro.Trim().ToUpper();
            string codBuscado = codigoMaterial.Trim().ToUpper();

            var deudaEncontrada = deudas.FirstOrDefault(d => d.Registro.Trim().ToUpper() == regBuscado
                                                            && d.CodigoMaterial.Trim().ToUpper() == codBuscado);
            var material = materiales.FirstOrDefault(m => m.CodigoMaterial == codBuscado);

            if (deudaEncontrada == null)
            {
                MessageBox.Show("No se encontró la deuda con el registro y código de material proporcionados.");
                return;
            }
            if (cantidadDevolver > deudaEncontrada.Cantidad)
            {
                MessageBox.Show("No se pudo devolver por exceder la cantidad prestada.");
                return;
            }

            deudaEncontrada.Cantidad -= cantidadDevolver;
            if (deudaEncontrada.Cantidad == 0)
                deudas = new Queue<Deuda>(deudas.Where(d => d.Cantidad > 0));

            material.CantidadDisponible += cantidadDevolver;

            GuardarDeudas(deudas);
            GuardarMateriales(materiales);

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
                devolucionesPrioritarias.Enqueue(devolucion, 1);
            else
                pilaDevoluciones.Push(devolucion);

            MessageBox.Show("Devolución registrada correctamente.");
            ActualizardataGridView1();
        }

        private Queue<Deuda> LeerDeudas()
        {
            var deudas = new Queue<Deuda>();
            if (!File.Exists(rutaDeudas))
            {
                MessageBox.Show($"No se encontró 'deuda.txt' en: {rutaDeudas}");
                return deudas;
            }
            foreach (var linea in File.ReadAllLines(rutaDeudas))
            {
                var datos = linea.Split(',');
                if (datos.Length == 6 && int.TryParse(datos[5], out int cant))
                {
                    deudas.Enqueue(new Deuda
                    {
                        Fecha = datos[0],
                        Registro = datos[1],
                        NombreEstudiante = datos[2],
                        CodigoMaterial = datos[3],
                        NombreMaterial = datos[4],
                        Cantidad = cant
                    });
                }
            }
            return deudas;
        }

        private List<Material> LeerMateriales()
        {
            var materiales = new List<Material>();
            if (!File.Exists(rutaMateriales))
            {
                MessageBox.Show($"No se encontró 'materiales.txt' en: {rutaMateriales}");
                return materiales;
            }

            foreach (var linea in File.ReadAllLines(rutaMateriales))
            {
                var datos = linea.Split(',');
                
                if (datos.Length >= 5
                    && int.TryParse(datos[0].Trim(), out int prio)
                    && int.TryParse(datos[4].Trim(), out int cantDisp))
                {
                    materiales.Add(new Material
                    {
                        CodigoMaterial = datos[1].Trim().ToUpper(),
                        CantidadDisponible = cantDisp,
                        Prioridad = prio
                    });
                }
            }

            return materiales;
        }


        private void GuardarDeudas(Queue<Deuda> deudas)
        {
            using var sw = new StreamWriter(rutaDeudas);
            foreach (var d in deudas)
                sw.WriteLine($"{d.Fecha},{d.Registro},{d.NombreEstudiante},{d.CodigoMaterial},{d.NombreMaterial},{d.Cantidad}");
        }

        private void GuardarMateriales(List<Material> materiales)
        {
            using var sw = new StreamWriter(rutaMateriales);
            foreach (var m in materiales)
                sw.WriteLine($"{m.CodigoMaterial},{m.CantidadDisponible},{m.Prioridad}");
        }

        private void ActualizardataGridView1()
        {
            dgvMatReac.Rows.Clear();
            foreach (var d in LeerDeudas())
                dgvMatReac.Rows.Add(d.Fecha, d.Registro, d.NombreEstudiante, d.CodigoMaterial, d.NombreMaterial, d.Cantidad);
        }

        private void CargarDeudas()
        {
            dgvMatReac.Rows.Clear();
            if (!File.Exists(rutaDeudas))
            {
                MessageBox.Show($"El archivo 'deudas.txt' no existe en: {rutaDeudas}", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (var linea in File.ReadAllLines(rutaDeudas))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                var partes = linea.Split(',');
                if (partes.Length == 6)
                    dgvMatReac.Rows.Add(partes[0], partes[1], partes[2], partes[3], partes[4], partes[5]);
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
            public int Prioridad { get; set; }
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