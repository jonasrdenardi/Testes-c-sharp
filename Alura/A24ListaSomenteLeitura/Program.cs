using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A24ListaSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");

            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas",21));

            Imprimir(csharpColecoes.Aulas);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
