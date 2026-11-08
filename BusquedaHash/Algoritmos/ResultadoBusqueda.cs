namespace BusquedaHash.Algoritmos
{
    /// <summary>
    /// Resultado de una sola búsqueda, con los contadores que usa el experimento.
    /// </summary>
    public struct ResultadoBusqueda
    {
        /// <summary>Indica si la clave estaba en la estructura.</summary>
        public bool Encontrado;

        /// <summary>
        /// Secuencial/Binaria: índice en el arreglo (-1 si no se encontró).
        /// Hash: número de cubeta calculado por la función de dispersión.
        /// </summary>
        public int Posicion;

        /// <summary>Veces que se comparó la clave buscada contra un elemento (== o &lt;).</summary>
        public long Comparaciones;

        /// <summary>Vueltas ejecutadas por el ciclo principal del algoritmo.</summary>
        public long Iteraciones;
    }
}
