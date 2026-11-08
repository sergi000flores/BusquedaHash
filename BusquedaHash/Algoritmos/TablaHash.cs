using System;
using System.Text;

namespace BusquedaHash.Algoritmos
{
    public enum FuncionDispersion
    {
        /// <summary>h(k) = k mod M, con M primo.</summary>
        Division = 0,
        /// <summary>h(k) = floor(M * frac(k * A)), A = (raíz(5) - 1) / 2 (método de Knuth).</summary>
        Multiplicacion = 1
    }

    /// <summary>
    /// Tabla hash con encadenamiento separado (cada cubeta es una lista enlazada).
    /// Implementada desde cero: no usa Dictionary ni HashSet.
    /// </summary>
    public class TablaHash
    {
        private class Nodo
        {
            public int Clave;
            public Nodo Siguiente;
        }

        private const double ConstanteA = 0.6180339887498949;
        private readonly Nodo[] _cubetas;

        public TablaHash(int tamano, FuncionDispersion funcion)
        {
            if (tamano < 1) throw new ArgumentOutOfRangeException("tamano");
            _cubetas = new Nodo[tamano];
            Funcion = funcion;
        }

        public FuncionDispersion Funcion { get; private set; }
        public int Tamano { get { return _cubetas.Length; } }
        public int Cantidad { get; private set; }

        /// <summary>Inserciones que cayeron en una cubeta que ya tenía elementos.</summary>
        public int Colisiones { get; private set; }

        /// <summary>Función de dispersión: convierte una clave en un número de cubeta.</summary>
        public int Dispersar(int clave)
        {
            if (Funcion == FuncionDispersion.Division)
                return (int)((uint)clave % (uint)_cubetas.Length);

            double producto = clave * ConstanteA;
            double fraccion = producto - Math.Floor(producto);
            int indice = (int)(_cubetas.Length * fraccion);
            return indice >= _cubetas.Length ? _cubetas.Length - 1 : indice;
        }

        /// <summary>Inserta la clave al inicio de su cadena. Devuelve false si ya existía.</summary>
        public bool Insertar(int clave)
        {
            int i = Dispersar(clave);

            for (Nodo a = _cubetas[i]; a != null; a = a.Siguiente)
                if (a.Clave == clave) return false;

            if (_cubetas[i] != null) Colisiones++;

            Nodo nuevo = new Nodo();
            nuevo.Clave = clave;
            nuevo.Siguiente = _cubetas[i];
            _cubetas[i] = nuevo;
            Cantidad++;
            return true;
        }

        public ResultadoBusqueda Buscar(int clave)
        {
            ResultadoBusqueda r = new ResultadoBusqueda();
            r.Posicion = Dispersar(clave);

            Nodo actual = _cubetas[r.Posicion];
            while (actual != null)
            {
                r.Iteraciones++;   // un nodo visitado de la cadena
                r.Comparaciones++; // actual.Clave == clave
                if (actual.Clave == clave)
                {
                    r.Encontrado = true;
                    return r;
                }
                actual = actual.Siguiente;
            }
            return r;
        }

        public int LongitudMaximaCadena()
        {
            int max = 0;
            for (int i = 0; i < _cubetas.Length; i++)
            {
                int largo = 0;
                for (Nodo a = _cubetas[i]; a != null; a = a.Siguiente) largo++;
                if (largo > max) max = largo;
            }
            return max;
        }

        public int CubetasVacias()
        {
            int vacias = 0;
            for (int i = 0; i < _cubetas.Length; i++)
                if (_cubetas[i] == null) vacias++;
            return vacias;
        }

        /// <summary>Texto con el contenido de las primeras cubetas (para la pestaña de búsqueda individual).</summary>
        public string Describir(int maxCubetas)
        {
            StringBuilder sb = new StringBuilder();
            int limite = Math.Min(_cubetas.Length, maxCubetas);
            for (int i = 0; i < limite; i++)
            {
                sb.Append("[").Append(i).Append("] ");
                if (_cubetas[i] == null)
                {
                    sb.Append("(vacía)");
                }
                else
                {
                    for (Nodo a = _cubetas[i]; a != null; a = a.Siguiente)
                    {
                        sb.Append(a.Clave);
                        if (a.Siguiente != null) sb.Append(" -> ");
                    }
                }
                sb.Append("\r\n");
            }
            if (limite < _cubetas.Length)
                sb.Append("... (").Append(_cubetas.Length - limite).Append(" cubetas más)\r\n");
            return sb.ToString();
        }

        public static int SiguientePrimo(int n)
        {
            if (n <= 2) return 2;
            if (n % 2 == 0) n++;
            while (!EsPrimo(n)) n += 2;
            return n;
        }

        public static bool EsPrimo(int n)
        {
            if (n < 2) return false;
            if (n % 2 == 0) return n == 2;
            for (long d = 3; d * d <= n; d += 2)
                if (n % d == 0) return false;
            return true;
        }
    }
}
