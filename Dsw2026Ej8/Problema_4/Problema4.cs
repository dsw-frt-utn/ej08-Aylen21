using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_4
{
    internal class Problema4
    {

        public double CalcularPromedio(int? nota1, int? nota2, int? nota3) {


            double promedio;
            int suma=0;
            int cont = 0;


            if (!nota1.HasValue && !nota2.HasValue && !nota3.HasValue)
            {
                return promedio = 0;
            }

            if (nota1 >= 0 && nota1 <= 10)
                {

                    suma += nota1.Value;
                    cont++;
          
                }

                if (nota2 >= 0 && nota2 <= 10)
                {

                    suma += nota2.Value;
                    cont++;
                }

                if (nota3 >= 0 && nota3 <= 10)
                {

                    suma += nota3.Value;
                    cont++;

                }
              


            
            promedio =(double) suma / cont;


            return promedio;
        
        }

    }
}
