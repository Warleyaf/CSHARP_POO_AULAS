using Aula145_metodos_abstratos.Entities.Enums;

namespace Aula145_metodos_abstratos.Entities
{
    internal abstract class Shape // declarando que minha classe é abstrata também
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); // Dessa forma aqui que eu declaro um método abstrato
    }
}