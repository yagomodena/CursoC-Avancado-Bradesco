using CursoC_Avancado;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();
        aluno.Nome = "Yago";
        aluno.Idade = 21;
        aluno.Serie = 3;

        aluno.RetornoConsole();
    }
}