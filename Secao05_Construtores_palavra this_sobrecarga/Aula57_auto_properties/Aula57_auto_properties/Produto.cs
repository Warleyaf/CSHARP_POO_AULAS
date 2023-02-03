using System.Globalization;
namespace Course {
    class Produto {

        //Adicionando a autoProperties
        private string _nome;
        public double Preco { get; private set; } // dessa forma aqui eu dispenso a implementação la em baixo, que está na linha 26 ao 30;
        public int Quantidade { get; private set; } // não vai precisar da implementação que está na linha 32 a linha 36;

        public Produto() {
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if(value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        /*
        public double Preco {
            get { return _preco; }
        }
        */

        /*
        public int Quantidade {
            get { return _quantidade; }
        }
        */

        public Produto(string nome, double preco) {
            _nome = nome;
            Preco = preco;
            Quantidade = 5;

        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}