using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BusquedaHash.Algoritmos
{
    public class ConfiguracionExperimento
    {
        public int N;                       // tamaño del conjunto de datos
        public int Busquedas;               // cantidad de claves a buscar
        public int PorcentajeExito;         // % de claves que sí existen en el conjunto
        public int Semilla;                 // semilla del generador aleatorio (reproducibilidad)
        public FuncionDispersion Funcion;   // función hash a utilizar
        public double FactorCarga;          // alfa = N / M
    }

    public class ResultadoExperimento
    {
        public int N;
        public string Metodo;
        public int Busquedas;
        public int Aciertos;
        public long CompTotal, CompTotalExito, CompTotalFallo, CompMax;
        public long IterTotal, IterMax;
        public double TiempoMs;             // tiempo total de las búsquedas
        public double PreparacionMs;        // ordenar (binaria) o construir tabla (hash)
        public string Nota = "";

        public double CompPromedio { get { return Busquedas == 0 ? 0 : (double)CompTotal / Busquedas; } }
        public double IterPromedio { get { return Busquedas == 0 ? 0 : (double)IterTotal / Busquedas; } }
        public double CompPromedioExito { get { return Aciertos == 0 ? 0 : (double)CompTotalExito / Aciertos; } }
        public double CompPromedioFallo { get { int f = Busquedas - Aciertos; return f == 0 ? 0 : (double)CompTotalFallo / f; } }
    }

    public static class Experimento
    {
        /// <summary>Genera n enteros únicos y aleatorios en [0, maximo), conservando el orden de generación.</summary>
        public static int[] GenerarDatos(int n, int maximo, Random rnd, HashSet<int> conjunto)
        {
            List<int> lista = new List<int>(n);
            while (lista.Count < n)
            {
                int v = rnd.Next(maximo);
                if (conjunto.Add(v)) lista.Add(v);
            }
            return lista.ToArray();
        }

        /// <summary>
        /// Genera las claves a buscar: un porcentaje existe en los datos (aciertos) y el resto no (fallos).
        /// Las claves se mezclan para que aciertos y fallos queden intercalados.
        /// </summary>
        public static int[] GenerarClaves(int[] datos, HashSet<int> conjunto, int cantidad, int porcentajeExito, int maximo, Random rnd)
        {
            int exitos = (int)Math.Round(cantidad * porcentajeExito / 100.0);
            int[] claves = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                if (i < exitos)
                {
                    claves[i] = datos[rnd.Next(datos.Length)];
                }
                else
                {
                    int c;
                    do { c = rnd.Next(maximo); } while (conjunto.Contains(c));
                    claves[i] = c;
                }
            }

            for (int i = cantidad - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                int t = claves[i]; claves[i] = claves[j]; claves[j] = t;
            }
            return claves;
        }

        /// <summary>Ejecuta las tres técnicas con exactamente los mismos datos y las mismas claves.</summary>
        public static List<ResultadoExperimento> Ejecutar(ConfiguracionExperimento cfg)
        {
            Random rnd = new Random(cfg.Semilla);
            int maximo = (int)Math.Max(100L, Math.Min((long)cfg.N * 10L, int.MaxValue - 1L));

            HashSet<int> conjunto = new HashSet<int>();   // solo para generar claves que NO existen
            int[] datos = GenerarDatos(cfg.N, maximo, rnd, conjunto);
            int[] claves = GenerarClaves(datos, conjunto, cfg.Busquedas, cfg.PorcentajeExito, maximo, rnd);

            List<ResultadoExperimento> lista = new List<ResultadoExperimento>();

            // 1) Secuencial sobre los datos tal como se generaron (sin ordenar)
            lista.Add(Medir("Secuencial", cfg.N, claves, 0.0, k => BusquedaSecuencial.Buscar(datos, k)));

            // 2) Binaria: primero se ordena una copia (costo de preparación aparte)
            Stopwatch sw = Stopwatch.StartNew();
            int[] ordenados = (int[])datos.Clone();
            Array.Sort(ordenados);
            sw.Stop();
            lista.Add(Medir("Binaria", cfg.N, claves, sw.Elapsed.TotalMilliseconds, k => BusquedaBinaria.Buscar(ordenados, k)));

            // 3) Hash: se construye la tabla con M primo >= N / alfa
            sw.Restart();
            int m = TablaHash.SiguientePrimo((int)Math.Ceiling(cfg.N / cfg.FactorCarga));
            TablaHash tabla = new TablaHash(m, cfg.Funcion);
            for (int i = 0; i < datos.Length; i++) tabla.Insertar(datos[i]);
            sw.Stop();

            string nombre = cfg.Funcion == FuncionDispersion.Division ? "Hash (división)" : "Hash (multiplicación)";
            ResultadoExperimento rh = Medir(nombre, cfg.N, claves, sw.Elapsed.TotalMilliseconds, k => tabla.Buscar(k));
            rh.Nota = "M=" + m + "; colisiones=" + tabla.Colisiones + "; cadena máx.=" + tabla.LongitudMaximaCadena()
                      + "; cubetas vacías=" + tabla.CubetasVacias();
            lista.Add(rh);

            return lista;
        }

        private static ResultadoExperimento Medir(string metodo, int n, int[] claves, double preparacionMs, Func<int, ResultadoBusqueda> buscar)
        {
            // Calentamiento del JIT (no se contabiliza)
            int calentar = Math.Min(50, claves.Length);
            for (int i = 0; i < calentar; i++) buscar(claves[i]);

            ResultadoExperimento res = new ResultadoExperimento();
            res.N = n;
            res.Metodo = metodo;
            res.Busquedas = claves.Length;
            res.PreparacionMs = preparacionMs;

            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < claves.Length; i++)
            {
                ResultadoBusqueda r = buscar(claves[i]);
                res.CompTotal += r.Comparaciones;
                res.IterTotal += r.Iteraciones;
                if (r.Comparaciones > res.CompMax) res.CompMax = r.Comparaciones;
                if (r.Iteraciones > res.IterMax) res.IterMax = r.Iteraciones;
                if (r.Encontrado) { res.Aciertos++; res.CompTotalExito += r.Comparaciones; }
                else { res.CompTotalFallo += r.Comparaciones; }
            }
            sw.Stop();
            res.TiempoMs = sw.Elapsed.TotalMilliseconds;
            return res;
        }
    }
}
