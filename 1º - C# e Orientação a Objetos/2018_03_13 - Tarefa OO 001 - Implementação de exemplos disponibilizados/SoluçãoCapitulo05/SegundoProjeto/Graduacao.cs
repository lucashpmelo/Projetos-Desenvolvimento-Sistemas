namespace SegundoProjeto
{
    class Graduacao : Curso
    {
        public int Semestres { get; set; }

        public override void registrarDisciplina(Disciplina d)
        {
            if (Disciplinas.Count < 24)
                Disciplinas.Add(d);
        }
    }
}
