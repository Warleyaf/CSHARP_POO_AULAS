using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula45_Problema_ex01 {
    internal class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {
            return Altura * Largura;
        }

        public double Perimetro() {
            return 2 * (Altura + Largura);
        }

        public double Diagonal() { 
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2)) ;
        }
    }
}
