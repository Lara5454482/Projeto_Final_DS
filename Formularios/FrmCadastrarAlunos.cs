using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using Projeto_Final.Model;

namespace Projeto_Final.Formularios
{
    public partial class FrmCadastrarAlunos : Form
    {
        private List<Projeto> projetos = new List<Projeto>();

        public FrmCadastrarAlunos()
        {
            InitializeComponent();
            CarregarProjetos();  // Carregar projetos ao inicializar
        }

        private void CarregarProjetos()
        {
            // Limpa o CheckedListBox
            checkedListBoxProjetos.Items.Clear();

            // Adiciona projetos ao CheckedListBox
            foreach (Projeto projeto in projetos)
            {
                checkedListBoxProjetos.Items.Add(projeto.Nome, false); // "false" significa que o item não está marcado inicialmente
            }
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            string nomeAluno = txtNomeAluno.Text;

            // Cria um novo aluno e associa os projetos selecionados
            Aluno novoAluno = new Aluno(0, nomeAluno);  // O ID do aluno pode ser gerado automaticamente

            // Associa os projetos selecionados ao aluno
            for (int i = 0; i < checkedListBoxProjetos.Items.Count; i++)
            {
                if (checkedListBoxProjetos.GetItemChecked(i))
                {
                    Projeto projetoSelecionado = projetos[i];
                    novoAluno.Projetos.Add(projetoSelecionado);
                }
            }

            // Aqui você poderia salvar o aluno no banco de dados ou em uma lista
            MessageBox.Show($"Aluno {novoAluno.Nome} cadastrado com sucesso!");
        }

        // Método para cadastrar um projeto (simulando a adição de projetos)
        private void CadastrarProjeto(string nomeProjeto)
        {
            Projeto novoProjeto = new Projeto(projetos.Count + 1, nomeProjeto);
            projetos.Add(novoProjeto);

            // Atualiza o CheckedListBox com o novo projeto
            CarregarProjetos();
        }
    }
   }
