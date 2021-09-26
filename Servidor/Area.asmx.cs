using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AreaWS.Servidor
{
    /// <summary>
    /// Descripción breve de Area
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Area : System.Web.Services.WebService
    {
        AreaCS a = new AreaCS();
        [WebMethod]
        public string Bienvenida()
        {
            return "Bienvenido a la calculadora de áreas (cuadrado, triángulo y círculo)";
        }
        [WebMethod(Description = "Método que recibe el lado a y b de un cuadrado y devuelve su área")]
        public decimal areaCuadrado(decimal ladoA, decimal ladoB)
        {
            a.num1 = ladoA;
            a.num2 = ladoB;
            return a.areaCuadrado();
        }
        [WebMethod(Description = "Método que recibe la base y altura de un triángulo y devuelve su área")]
        public decimal areaTriangulo(decimal baseT, decimal altura)
        {
            return a.areaTriangulo(baseT, altura);
        }
        [WebMethod(Description = "Método que recibe el valor del radio de un círculo y devuelve su área")]
        public double areaCirculo(int radio)
        {
            return a.areaCirculo(radio);
        }
    }
}
