using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseA
{
    class clsTriangulo : clsFigura
    {
        //atributos
        private float _ladoA, _ladoB, _ladoC;
        //propiedades 
        public float ladoA
        {
            get { return _ladoA; }
            set { _ladoA = value; }
        }

        public float ladoB
        {
            get { return _ladoB; }
            set { _ladoB = value; }
        }

        public float ladoC
        {
            get { return _ladoC; }
            set { _ladoC = value; }
        }

        //cosntructor
        public clsTriangulo()
        {
            _ladoA = 0;
            _ladoB = 0;
            _ladoC = 0;
        }
        //cosntructor por parametros
        public clsTriangulo(float LA, float LB, float LC)
        {
            _ladoA = LA;
            _ladoB = LB;
            _ladoC = LC;
        }

        //metodos 
        public override float Perimetro()
        {
            float res = 0;
            res = _ladoA + _ladoB + _ladoC;
            return res;
        }

        public override float Area()
        {
            float res = 0;
            float s = (_ladoA + _ladoB + _ladoC) / 2;
            res = (float)Math.Sqrt(s*(s-_ladoA)*(s-_ladoB)*(s-_ladoC));
            return res;
        }



    }
}
