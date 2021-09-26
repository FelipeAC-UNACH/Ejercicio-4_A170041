using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AreaWS.Servidor
{
    public class AreaCS
    {
        public decimal num1 { get; set; }
        public decimal num2 { get; set; }
        public decimal areaCuadrado()
        {
            return num1 * num2;
        }
        public decimal areaTriangulo(decimal baseT, decimal altura)
        {
            num1 = baseT;
            num2 = altura;
            return (num1 * num2) / 2;
        }
        public double areaCirculo(int radio)
        {
            return Math.Pow(radio, 2)*3.1416;
        }
    }
}