﻿using System.Collections.Generic;
using System.Linq;

namespace SegundoProjeto
{
    class Curso
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public HashSet<Disciplina> Disciplinas { get; } = new HashSet<Disciplina>();

        public void RegistrarDisciplina(Disciplina d)
        {
            Disciplinas.Add(d);
        }

        public int ObterQuantidadeDisciplinasDoCurso()
        {
            return Disciplinas.Count;
        }

        public Disciplina ObterDisciplinaPorNome(string nome)
        {
            return Disciplinas.Where<Disciplina>(n => n.Nome.Equals(nome)).FirstOrDefault();
        }

        public override bool Equals(object obj)
        {
            if (obj is Curso)
            {
                Curso c = obj as Curso;
                return this.Nome.Equals(c.Nome);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (11 + this.Nome == null ? 0 : this.GetHashCode());
        }
    }
}
