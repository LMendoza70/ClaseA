using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseA
{
    abstract class clsFigura
    {
        //atributos
        protected string nombre;

        //propiedades
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string valor)
        {
            nombre = valor;
        }

        //constructor
        public clsFigura()
        {
            nombre = "";
        }

        /*metodos
        public float Area()
        {
            float res = 0;
            return res;
        }

        public float Perimetro()
        {
            return 0;
        }*/

        //metodos abastractos

        public abstract float Area();
        public abstract float Perimetro();
        public string descripcion()
        {
            return "Esta es la descripcion de la figura" + Area();
        }
    }
}
