using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_Avancado
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public int Serie;

        public string Retorno()
        {
            return string.Format($"O aluno {Nome} tem {Idade} e pertence a serie {Serie}");
        }

        public void RetornoConsole()
        {
            Console.WriteLine(Retorno());
        }
    }
}
