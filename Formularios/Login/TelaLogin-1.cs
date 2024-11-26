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

namespace Projeto_Final.Formularios
{
    public partial class frmUsuarios : Form
    {
        public Projeto_Final.Classes.Login login;
        public frmUsuarios()
        {
            InitializeComponent();
            login = new Projeto_Final.Classes.Login();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            login.Usuario = txtLogin.Text;
            login.Senha = txtSenha.Text;
            if (login.Logar())
            {
                Principal p = new Principal();
                p.FormClosed += FecharForm;
                this.Hide();
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Focus();
                p.Show();
            }
            else
            {
                MessageBox.Show("Usuário e senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnEntrar_Click(sender, e);
            }
        }
    }
}