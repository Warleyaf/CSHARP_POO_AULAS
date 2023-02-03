
namespace Aula128_ex_composicao_pt01.Entities
{
    internal class Department
    {
        public string Name { get; set; } // propriedade

        public Department() { // construtor
            
        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
