using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Model
{

    public class Projeto
    {
        public int ProjetoId { get; set; }
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Projeto(int projetoId, string nome)
        {
            ProjetoId = projetoId;
            Nome = nome;
            Alunos = new List<Aluno>();
        }
    }


}
