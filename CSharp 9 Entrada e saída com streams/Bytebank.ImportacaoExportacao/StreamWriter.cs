using System.IO;
using System.Text;

namespace Bytebank.ImportacaoExportacao
{
    partial class Program
    {
        static void StreamWriter()
        {
            string newPath = "exported_accounts.csv";

            using (var fluxo = new FileStream(newPath, FileMode.Append))
            {
                using (var writer = new StreamWriter(fluxo, Encoding.UTF8))
                {
                    writer.Write("456,7895,4785.40,Pedro Portella\n");
                }
            }
        }
    }
}
