using System;

namespace Livro
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro emprestimoLivro = new Livro("Estrelas Perdidas", "Claudia Gray", 2015);

            emprestimoLivro.ExibirInformacoes();
        }
    }
}