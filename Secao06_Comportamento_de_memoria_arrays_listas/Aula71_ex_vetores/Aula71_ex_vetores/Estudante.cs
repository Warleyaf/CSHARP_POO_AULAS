namespace Aula71_ex_vetores {
    internal class Estudante {
        public string Nome { get; set; }
        public string Email { get; set; }

        /* public Estudante(string nome, string email) {
             Nome = nome;
             Email = email;
         }
        */ // Não irei precisar desse pedaço de código por que o que faz isso aqui já está em program.cs
           // Que é o "vetor[quarto] = new Estudante { Nome = nome, Email = email };"

        public override string ToString() {
            return Nome + ", " + Email;
        }
    }
}
