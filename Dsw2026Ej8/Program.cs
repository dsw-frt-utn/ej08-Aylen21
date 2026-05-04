using Dsw2026Ej8.Problema_1;
using Dsw2026Ej8.Problema_2;

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
            Console.WriteLine("     ----------  Problema 2 ----------       ");

            Problema2 p2 = new Problema2();

            Problema2 p23 = new Problema2();
            string resultado2 = p2.CrearResumenVenta(123, "Veloz", -5, 100);
            string resultado3 = p23.CrearResumenVenta(1234,"Ancho",4,100);

            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);



        }
    }
}
