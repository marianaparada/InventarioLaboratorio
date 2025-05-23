using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            string registro = txtRegD.Text.Trim();
            string codigo = txtIDD.Text.Trim();
            if (!int.TryParse(txtCantD.Text, out int cantidad))
            {
                MessageBox.Show("Cantidad no válida.");
                return;
            }

            var deudas = LeerDeudas();
            var materiales = LeerMateriales();

            var deuda = deudas.FirstOrDefault(d =>
                d.Registro.Equals(registro, StringComparison.OrdinalIgnoreCase) &&
                d.CodigoMaterial.Equals(codigo, StringComparison.OrdinalIgnoreCase));

            if (deuda == null)
            {
                MessageBox.Show("No se encontró deuda para el código y registro.");
                return;
            }

            if (cantidad > deuda.Cantidad)
            {
                MessageBox.Show("No puede devolver más de lo que debe.");
                return;
            }

            var material = materiales.FirstOrDefault(m =>
                m.CodigoMaterial.Equals(codigo, StringComparison.OrdinalIgnoreCase));

            if (material == null)
            {
                MessageBox.Show("Material no encontrado.");
                return;
            }

            // Actualizar deuda
            deuda.Cantidad -= cantidad;
            if (deuda.Cantidad == 0)
                deudas = deudas.Where(d => d != deuda).ToList();

            // Actualizar inventario
            material.CantidadDisponible += cantidad;

            // Guardar cambios
            GuardarDeudas(deudas);
            GuardarMateriales(materiales);

            // Registrar devolución
            var devolucion = new Devolucion
            {
                Fecha = DateTime.Now.ToString("dd-MM-yyyy"),
                Registro = deuda.Registro,
                NombreEstudiante = deuda.NombreEstudiante,
                CodigoMaterial = deuda.CodigoMaterial,
                NombreMaterial = deuda.NombreMaterial,
                Cantidad = cantidad
            };

            if (material.Prioridad == 1)
                devolucionesPrioritarias.Enqueue(devolucion, 1);
            else
                pilaDevoluciones.Push(devolucion);

            MessageBox.Show("Devolución registrada correctamente.");
            CargarDeudas();
        }

        private List<Deuda> LeerDeudas()
        {
            var lista = new List<Deuda>();
            if (!File.Exists(rutaDeudas)) return lista;

            foreach (var linea in File.ReadAllLines(rutaDeudas))
            {
                var datos = linea.Split(',');
                if (datos.Length == 6 && int.TryParse(datos[5], out int cant))
                {
                    lista.Add(new Deuda
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
            return lista;
        }

        private void GuardarDeudas(IEnumerable<Deuda> deudas)
        {
            using var sw = new StreamWriter(rutaDeudas, false);
            foreach (var d in deudas)
                sw.WriteLine($"{d.Fecha},{d.Registro},{d.NombreEstudiante},{d.CodigoMaterial},{d.NombreMaterial},{d.Cantidad}");
        }

        private List<Material> LeerMateriales()
        {
            var lista = new List<Material>();
            if (!File.Exists(rutaMateriales)) return lista;

            foreach (var linea in File.ReadAllLines(rutaMateriales))
            {
                var datos = linea.Split(',');
                if (datos.Length == 5 &&
                    int.TryParse(datos[0], out int prioridad) &&
                    int.TryParse(datos[4], out int cantidad))
                {
                    lista.Add(new Material
                    {
                        Prioridad = prioridad,
                        CodigoMaterial = datos[1].Trim(),
                        NombreMaterial = datos[2].Trim(),
                        Tipo = datos[3].Trim(),
                        CantidadDisponible = cantidad
                    });
                }
            }
            return lista;
        }

        private void GuardarMateriales(List<Material> materiales)
        {
            using var sw = new StreamWriter(rutaMateriales, false);
            foreach (var m in materiales)
                sw.WriteLine($"{m.Prioridad},{m.CodigoMaterial},{m.NombreMaterial},{m.Tipo},{m.CantidadDisponible}");
        }

        private void CargarDeudas()
        {
            dgvMatReac.Rows.Clear();
            foreach (var d in LeerDeudas())
                dgvMatReac.Rows.Add(d.Fecha, d.Registro, d.NombreEstudiante, d.CodigoMaterial, d.NombreMaterial, d.Cantidad);
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
            public int Prioridad { get; set; }
            public string CodigoMaterial { get; set; }
            public string NombreMaterial { get; set; }
            public string Tipo { get; set; }
            public int CantidadDisponible { get; set; }
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

