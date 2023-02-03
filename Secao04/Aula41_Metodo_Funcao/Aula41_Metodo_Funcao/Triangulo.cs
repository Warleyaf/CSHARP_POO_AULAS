using System;

namespace Aula41_Metodo_Funcao {
    internal class Triangulo {

        public double A;
        public double B;
        public double C;

        public double Area() { // Criando um método, dessa forma aqui eu crio o método e dentro das chaves vem a lógica do meu método
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }     

    }
}
