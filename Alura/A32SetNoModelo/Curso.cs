using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A32SetNoModelo;

namespace A24ListaSomenteLeitura
{
    public class Curso
    {
        //Alunos deve ser um ISet. Alunos deve retornar ReadyOnlyCollection
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        public void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                ////LINQ = Language Integrated Query
                ////Consulta integrada à Linguagem

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal},Aulas: {string.Join(",",aulas)}";
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
    }
}
