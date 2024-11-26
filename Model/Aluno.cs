using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Model
{

    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public List<Projeto> Projetos { get; set; }  // Lista de projetos

        // Construtor para inicializar a lista de Projetos
        public Aluno(int alunoId, string nome)
        {
            AlunoId = alunoId;
            Nome = nome;
            Projetos = new List<Projeto>();  // Inicializando a lista de projetos
        }
    }

    //outra versao: 
    // Adicionando a lista de projetos à classe Aluno
    //public class Aluno
    //{
    //   public int AlunoId { get; set; }
    //  public string Nome { get; set; }
    //  public List<Projeto> Projetos { get; set; }  // Adicionei a propriedade Projetos

    //  public Aluno(int alunoId, string nome)
    //  {
    //     AlunoId = alunoId;
    //    Nome = nome;
    //      Projetos = new List<Projeto>();  // Inicializa a lista de projetos
    // }
    //}


}
