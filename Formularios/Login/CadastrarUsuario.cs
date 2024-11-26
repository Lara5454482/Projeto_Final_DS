using Projeto_Final.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_Final.Formularios.Login
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Login = txtLogin.Text;
            u.Senha = txtSenha.Text;
            u.Ativo = CheckAtivo.Checked;
            u.Inserir();
            MessageBox.Show("Sucesso", "Cadastrado com sucesso");
            Close();
        }
    }
}
