using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseA
{
    class Program
    {
        static void Main(string[] args)
        {
            //voy a inicializar un objeto rectangulo
            clsRectangulo miRectangulo = new clsRectangulo();
            clsCuadrado miCuadro = new clsCuadrado();

            clsCuadrado micuadro2 = new clsCuadrado(5);
            clsCuadrado cuadro3 = new clsCuadrado(micuadro2);
            Console.WriteLine("Programita que calcula area y perimetro de un rectangulo");
            Console.WriteLine("Captura la altura del rectangulo...");
            miRectangulo.setAltura(float.Parse( Console.ReadLine()));
            Console.WriteLine("Captura la base del rectangulo");
            miRectangulo.setAncho(float.Parse(Console.ReadLine()));
            Console.WriteLine("Segun los datos proporcionados ");
            Console.WriteLine("El area del rectangulo es : "+ miRectangulo.Area()+" m2");
            Console.WriteLine("El perimetro del rectangulo es : "+miRectangulo.Perimetro()+" m");
            Console.ReadKey();
        }
    }
}
