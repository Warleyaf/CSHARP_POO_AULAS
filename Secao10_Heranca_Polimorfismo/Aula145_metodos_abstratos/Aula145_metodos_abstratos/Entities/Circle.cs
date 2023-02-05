using Aula145_metodos_abstratos.Entities.Enums;
using System;

namespace Aula145_metodos_abstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public Color Color { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
