using System.Collections.Generic;

namespace Bytebank.List
{
    public static class ListExtensions
    {
        // Metodos de Extensão
        public static void AddSome(this List<int> lista, params int[] items)
        {
            foreach (var item in items)
            {
                lista.Add(item);
            }
        }
    }
}
