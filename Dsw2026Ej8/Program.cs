using Dsw2026Ej8.Problema_1;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     ----------  Problema 1 ----------       " );

            ProductHelper p = new ProductHelper();

            string resultado = p.ObtenerEtiquetaProducto(12, "Mouse", 1400);

            Console.WriteLine(resultado);
          



        }
    }
}
