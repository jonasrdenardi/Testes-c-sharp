using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //string[] aulas = new string[]
            //    {
            //        aulaIntro,
            //        aulaModelando,
            //        aulaSets
            //    };

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Imprimir(aulas);

            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length - 1]);

            aulaIntro = "Trabalhando com Arrays";
            Imprimir(aulas);

            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);

            Console.WriteLine("Aula modelando está no índice: " + Array.IndexOf(aulas, aulaModelando));
            Console.WriteLine("Aula modelando está no índice: " + Array.LastIndexOf(aulas, aulaModelando));

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";

            Array.Sort(aulas);

            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);

            string[] clone = aulas.Clone() as string[];

            Imprimir(clone);

            Array.Clear(clone,1,2);
        }

        private static void Imprimir(string[] aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);

            }
        }
    }
}
