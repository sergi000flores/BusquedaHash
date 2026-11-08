namespace BusquedaHash.Algoritmos
{
    /// <summary>
    /// Búsqueda secuencial (lineal) sobre un arreglo sin ordenar.
    /// Complejidad: O(n) en el peor caso y en el caso promedio.
    /// </summary>
    public static class BusquedaSecuencial
    {
        public static ResultadoBusqueda Buscar(int[] datos, int clave)
        {
            ResultadoBusqueda r = new ResultadoBusqueda();
            r.Posicion = -1;

            for (int i = 0; i < datos.Length; i++)
            {
                r.Iteraciones++;   // una vuelta del ciclo
                r.Comparaciones++; // datos[i] == clave
                if (datos[i] == clave)
                {
                    r.Encontrado = true;
                    r.Posicion = i;
                    return r;
                }
            }
            return r;
        }
    }
}
