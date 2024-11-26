using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Final.Model;

namespace Projeto_Final.Formularios
{
    public partial class FrmDetalhes : Form
    {
        public FrmDetalhes()
        {
            InitializeComponent();
        }

        public List<Projeto> projetos = new List<Projeto>();

        private void FrmDetalhes_Load(object sender, EventArgs e)
        {
            // Carregar projetos
            var projeto1 = new Projeto(1, "Projeto de Física");
            var projeto2 = new Projeto(2, "Projeto de Matemática");

            projeto1.Alunos.Add(new Aluno(1, "João Silva"));
            projeto1.Alunos.Add(new Aluno(2, "Maria Souza"));
            projeto2.Alunos.Add(new Aluno(3, "Carlos Lima"));

            projetos.Add(projeto1);
            projetos.Add(projeto2);

            // Carregar projetos na ComboBox
            comboBoxProjetos.DataSource = projetos;
            comboBoxProjetos.DisplayMember = "Nome";  // Nome do projeto será mostrado
            comboBoxProjetos.ValueMember = "ProjetoId";  // ID do projeto será o valor por trás de cada item

            // Configurar DataGridView
            ConfigureDataGridView();
        }


        private void comboBoxProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpar o DataGridView antes de adicionar os alunos
            dataGridViewAlunos.Rows.Clear();

            // Verificar se um projeto foi selecionado
            var projetoSelecionado = (Projeto)comboBoxProjetos.SelectedItem;
            if (projetoSelecionado != null)
            {
                // Adicionar os alunos ao DataGridView
                string alunos = string.Join(", ", projetoSelecionado.Alunos.Select(a => a.Nome));
                dataGridViewAlunos.Rows.Add(projetoSelecionado.Nome, alunos);
            }
        }



        private void ConfigureDataGridView()
        {
            dataGridViewAlunos.Columns.Clear();
            dataGridViewAlunos.Columns.Add("NomeProjeto", "Nome do Projeto");
            dataGridViewAlunos.Columns.Add("Alunos", "Alunos");

            // Ajustar para exibir de maneira limpa
            dataGridViewAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



    }
}
