using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace sets 
{
    public class Curso 
    {
        private IList<Aula> aulas;
        public IList<Aula> Aulas { get => new ReadOnlyCollection<Aula>(aulas); }
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos { get => new ReadOnlyCollection<Aluno>(alunos.ToList()); }

        private string nome;
        public string Nome { get => nome;  set => nome = value; }
        
        private string instrutor;
        public string Instrutor { get => instrutor; set => instrutor = value; }

        public int TempoTotal { get => aulas.Sum(aula => aula.Tempo); }
        
        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public void Matricular(Aluno aluno)
        {
            this.alunos.Add(aluno);
        }

        public bool isRegistered(Aluno aluno)
        {
            return this.alunos.Contains(aluno);
        }

        public override string ToString()
        {
            return $"Curso: {this.nome}" +
                $"\nInstrutor: {this.instrutor}" +
                $"\nTempo Total: {this.TempoTotal}" +
                $"\nAulas: {string.Join(", ", this.aulas)}" +
                $"\nAlunos: {string.Join(", ", this.Alunos)}";
        }
    }
}