using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusquedaHash.Algoritmos;

namespace BusquedaHash
{
    public partial class Form1 : Form
    {
        private readonly List<ResultadoExperimento> _resultados = new List<ResultadoExperimento>();

        // Estructuras de la pestaña "Búsqueda individual"
        private int[] _datosInd;
        private int[] _ordenadosInd;
        private TablaHash _tablaInd;

        public Form1()
        {
            InitializeComponent();
            cmbFuncion.SelectedIndex = 0;
            ConfigurarGrid();
        }

        // ------------------------------------------------------------------
        //  Pestaña EXPERIMENTO
        // ------------------------------------------------------------------

        private void ConfigurarGrid()
        {
            string[] encabezados =
            {
                "N", "Método", "Búsquedas", "Aciertos",
                "Comparaciones totales", "Prom. comparaciones", "Prom. comp. (éxito)", "Prom. comp. (fallo)", "Máx. comparaciones",
                "Iteraciones totales", "Prom. iteraciones", "Máx. iteraciones",
                "Tiempo búsquedas (ms)", "Preparación (ms)", "Notas"
            };
            int[] anchos = { 80, 120, 80, 70, 110, 100, 100, 100, 100, 100, 90, 90, 100, 90, 320 };

            for (int i = 0; i < encabezados.Length; i++)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = "col" + i;
                col.HeaderText = encabezados[i];
                col.Width = anchos[i];
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.DefaultCellStyle.Alignment = (i >= 2 && i <= 13)
                    ? DataGridViewContentAlignment.MiddleRight
                    : DataGridViewContentAlignment.MiddleLeft;
                dgvResultados.Columns.Add(col);
            }

            dgvResultados.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvResultados.ColumnHeadersHeight = 46;
        }

        private async void btnEjecutar_Click(object sender, EventArgs e)
        {
            int[] tamanos;
            if (!TryParseTamanos(txtTamanos.Text, out tamanos))
            {
                MessageBox.Show("Escribe uno o más tamaños N enteros (entre 1 y 5,000,000) separados por coma.",
                    "Tamaños no válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetOcupado(true);
            progressBar.Maximum = tamanos.Length;
            progressBar.Value = 0;

            try
            {
                foreach (int n in tamanos)
                {
                    lblEstado.Text = "Ejecutando N = " + n.ToString("N0") + " ...";

                    ConfiguracionExperimento cfg = new ConfiguracionExperimento();
                    cfg.N = n;
                    cfg.Busquedas = (int)nudBusquedas.Value;
                    cfg.PorcentajeExito = (int)nudExito.Value;
                    cfg.Semilla = (int)nudSemilla.Value;
                    cfg.Funcion = (FuncionDispersion)cmbFuncion.SelectedIndex;
                    cfg.FactorCarga = (double)nudFactor.Value;

                    List<ResultadoExperimento> filas = await Task.Run(() => Experimento.Ejecutar(cfg));

                    foreach (ResultadoExperimento r in filas)
                    {
                        _resultados.Add(r);
                        AgregarFila(r);
                    }
                    progressBar.Value++;
                }
                lblEstado.Text = "Experimento terminado.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error durante el experimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEstado.Text = "Error.";
            }
            finally
            {
                SetOcupado(false);
            }
        }

        private void AgregarFila(ResultadoExperimento r)
        {
            dgvResultados.Rows.Add(
                r.N.ToString("N0"),
                r.Metodo,
                r.Busquedas.ToString("N0"),
                r.Aciertos.ToString("N0"),
                r.CompTotal.ToString("N0"),
                r.CompPromedio.ToString("N2"),
                r.CompPromedioExito.ToString("N2"),
                r.CompPromedioFallo.ToString("N2"),
                r.CompMax.ToString("N0"),
                r.IterTotal.ToString("N0"),
                r.IterPromedio.ToString("N2"),
                r.IterMax.ToString("N0"),
                r.TiempoMs.ToString("N3"),
                r.PreparacionMs.ToString("N3"),
                r.Nota);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _resultados.Clear();
            dgvResultados.Rows.Clear();
            progressBar.Value = 0;
            lblEstado.Text = "Tabla limpia.";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (_resultados.Count == 0)
            {
                MessageBox.Show("Primero ejecuta el experimento.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Archivo CSV (*.csv)|*.csv";
                dlg.FileName = "resultados_busqueda.csv";
                if (dlg.ShowDialog() != DialogResult.OK) return;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("N,Metodo,Busquedas,Aciertos,ComparacionesTotales,ComparacionesPromedio,ComparacionesPromExito,ComparacionesPromFallo,ComparacionesMax,IteracionesTotales,IteracionesPromedio,IteracionesMax,TiempoBusquedasMs,PreparacionMs,Notas");

                foreach (ResultadoExperimento r in _resultados)
                {
                    sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                        "{0},{1},{2},{3},{4},{5:F4},{6:F4},{7:F4},{8},{9},{10:F4},{11},{12:F4},{13:F4},\"{14}\"",
                        r.N, r.Metodo, r.Busquedas, r.Aciertos,
                        r.CompTotal, r.CompPromedio, r.CompPromedioExito, r.CompPromedioFallo, r.CompMax,
                        r.IterTotal, r.IterPromedio, r.IterMax,
                        r.TiempoMs, r.PreparacionMs, r.Nota));
                }

                File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(true));
                lblEstado.Text = "CSV guardado.";
            }
        }

        private void SetOcupado(bool ocupado)
        {
            btnEjecutar.Enabled = !ocupado;
            btnExportar.Enabled = !ocupado;
            btnLimpiar.Enabled = !ocupado;
            grpParametros.Enabled = !ocupado;
            tabIndividual.Enabled = !ocupado;
        }

        private static bool TryParseTamanos(string texto, out int[] tamanos)
        {
            List<int> lista = new List<int>();
            string[] partes = texto.Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string p in partes)
            {
                int n;
                if (!int.TryParse(p, NumberStyles.Integer, CultureInfo.InvariantCulture, out n) || n < 1 || n > 5000000)
                {
                    tamanos = null;
                    return false;
                }
                lista.Add(n);
            }

            tamanos = lista.ToArray();
            return tamanos.Length > 0;
        }

        // ------------------------------------------------------------------
        //  Pestaña BÚSQUEDA INDIVIDUAL
        // ------------------------------------------------------------------

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int n = (int)nudNInd.Value;
            int maximo = Math.Max(100, n * 10);
            Random rnd = new Random((int)nudSemilla.Value);

            HashSet<int> conjunto = new HashSet<int>();
            _datosInd = Experimento.GenerarDatos(n, maximo, rnd, conjunto);

            _ordenadosInd = (int[])_datosInd.Clone();
            Array.Sort(_ordenadosInd);

            int m = TablaHash.SiguientePrimo((int)Math.Ceiling(n / (double)nudFactor.Value));
            _tablaInd = new TablaHash(m, (FuncionDispersion)cmbFuncion.SelectedIndex);
            foreach (int d in _datosInd) _tablaInd.Insertar(d);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS SIN ORDENAR (los usa la búsqueda secuencial):");
            sb.AppendLine(string.Join(", ", Array.ConvertAll(_datosInd, x => x.ToString())));
            sb.AppendLine();
            sb.AppendLine("DATOS ORDENADOS (los usa la búsqueda binaria):");
            sb.AppendLine(string.Join(", ", Array.ConvertAll(_ordenadosInd, x => x.ToString())));
            sb.AppendLine();
            sb.AppendLine("TABLA HASH  (M = " + _tablaInd.Tamano + ", función = " + cmbFuncion.Text +
                          ", colisiones = " + _tablaInd.Colisiones + "):");
            sb.Append(_tablaInd.Describir(200));

            txtDatos.Text = sb.ToString();
            txtSalida.Clear();
        }

        private void btnBuscarInd_Click(object sender, EventArgs e)
        {
            if (_datosInd == null)
            {
                MessageBox.Show("Primero genera los datos.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int clave = (int)nudClave.Value;
            ResultadoBusqueda s = BusquedaSecuencial.Buscar(_datosInd, clave);
            ResultadoBusqueda b = BusquedaBinaria.Buscar(_ordenadosInd, clave);
            ResultadoBusqueda h = _tablaInd.Buscar(clave);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Clave buscada: " + clave);
            sb.AppendLine(Linea("Secuencial", s, "posición"));
            sb.AppendLine(Linea("Binaria   ", b, "posición (arreglo ordenado)"));
            sb.AppendLine(Linea("Hash      ", h, "cubeta h(k)"));
            sb.AppendLine(new string('-', 90));

            txtSalida.AppendText(sb.ToString().Replace("\r\n", "\n").Replace("\n", "\r\n"));
        }

        private static string Linea(string nombre, ResultadoBusqueda r, string etiquetaPos)
        {
            string estado = r.Encontrado ? "ENCONTRADA" : "NO ENCONTRADA";
            string pos = (r.Encontrado || etiquetaPos.StartsWith("cubeta"))
                ? etiquetaPos + " = " + r.Posicion
                : "sin posición";
            return nombre + ": " + estado + " | " + pos +
                   " | comparaciones = " + r.Comparaciones + " | iteraciones = " + r.Iteraciones;
        }
    }
}
