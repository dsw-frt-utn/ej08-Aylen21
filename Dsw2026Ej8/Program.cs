using Dsw2026Ej8.Problema_1;
using Dsw2026Ej8.Problema_2;
using Dsw2026Ej8.Problema_3;
using Dsw2026Ej8.Problema_4;
using Dsw2026Ej8.Problema_5;

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

            Console.WriteLine("     ----------  Problema 3 ----------       ");

            Product producto = new Product("Mouse Inalambrico");
            Problema3 p3 = new Problema3();

            string resultado4 = p3.CompararCopias(1234,producto);

            Console.WriteLine(resultado4);



            Console.WriteLine("     ----------  Problema 4 ----------       ");

          Problema4 p4 = new Problema4();

            double resultado5 = p4.CalcularPromedio(null, 6, 12);
            double resultado6 = p4.CalcularPromedio(5, 6, 8);
            double resultado7 = p4.CalcularPromedio(null, null, null);

            Console.WriteLine($"Promedio de null, 6, 12 = {resultado5}");
            Console.WriteLine($"Promedio de 5, 6, 8 = {resultado6}");
            Console.WriteLine($"Promedio de null, null, null = {resultado7}");

            
            Console.WriteLine("     ----------  Problema 5 ----------       ");
            Problema5 p5 = new Problema5();

            Sale s1 = new RetailSale(100m);
            Sale s2 = new WholesaleSale(100m);

            Console.WriteLine($"Sale R Importe Final: {p5.ObtenerImporteFinal(s1)}");
            Console.WriteLine($"Sale W Importe Final: {p5.ObtenerImporteFinal(s2)}");







        }
    }
}
