namespace BusquedaHash.Algoritmos
{
    /// <summary>
    /// Búsqueda binaria iterativa. REQUIERE que el arreglo esté ordenado ascendentemente.
    /// Complejidad: O(log n).
    /// </summary>
    public static class BusquedaBinaria
    {
        public static ResultadoBusqueda Buscar(int[] ordenado, int clave)
        {
            ResultadoBusqueda r = new ResultadoBusqueda();
            r.Posicion = -1;

            int bajo = 0;
            int alto = ordenado.Length - 1;

            while (bajo <= alto)
            {
                r.Iteraciones++;
                int medio = bajo + (alto - bajo) / 2;

                r.Comparaciones++;                 // ordenado[medio] == clave ?
                if (ordenado[medio] == clave)
                {
                    r.Encontrado = true;
                    r.Posicion = medio;
                    return r;
                }

                r.Comparaciones++;                 // ordenado[medio] < clave ?
                if (ordenado[medio] < clave)
                    bajo = medio + 1;
                else
                    alto = medio - 1;
            }
            return r;
        }

        public static bool EstaOrdenado(int[] datos)
        {
            for (int i = 1; i < datos.Length; i++)
                if (datos[i - 1] > datos[i]) return false;
            return true;
        }
    }
}
