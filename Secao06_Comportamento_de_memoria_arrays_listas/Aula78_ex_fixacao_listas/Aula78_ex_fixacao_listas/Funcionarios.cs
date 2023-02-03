using System.Globalization;
namespace Aula78_ex_fixacao_listas {
    internal class Funcionarios {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionarios(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage) {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
