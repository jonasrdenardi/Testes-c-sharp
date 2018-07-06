using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A31OPoderDosSets
{
    class Program
    {
        static void Main(string[] args)
        {
            //SETS = CONJUNTOS

            //Duas propriedades dos Set
            //1. não permite duplicidade
            //2. os elementos são mantidos em ordem específica

            //declarando set dos alunos

            ISet<string> alunos = new HashSet<string>();

            //adicionando: vanessa, ana, rafael
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            //imprimindo
            Console.WriteLine(string.Join(",", alunos));

            //adicionando: priscila, rollo, fabio
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));
            //e a ordem???

            //remover ana, adicionando marcelo
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            //imprimindo de novo
            Console.WriteLine(string.Join(",", alunos));
            //adicionando gushiken de novo
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));

            //qual a vantagem do set sobre a lsita? look-up!

            //desempenho HashSet x List: escalabilidade x memória

            //ordenando: sort

            List<string> alunosEmLista = new List<string>(alunos);

            alunosEmLista.Sort();

            Console.WriteLine(string.Join(",", alunosEmLista));
        }
    }
}
