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
    public partial class GerenciarUsuarios : Form
    {
        public GerenciarUsuarios()
        {
            InitializeComponent();
            Usuarios u = new Usuarios();
            dtgridusuarios.DataSource = u.PreencherGrid();
        }

        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            Usuarios u = new Usuarios();
            dtgridusuarios.DataSource = u.PreencherGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastrarUsuario frm = new CadastrarUsuario();
            frm.FormClosed += FecharForm;
            frm.ShowDialog();
        }

        private void dtgridusuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    dtgridusuarios.Rows[e.RowIndex].Cells[0].Value);

                EditarUsuario editar = new EditarUsuario(id);

                // Inscreve-se no evento
                editar.FormClosed += FecharForm;
                editar.ShowDialog(); // Abre o formulário como um diálogo modal
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            dtgridusuarios.DataSource = u.Pesquisar(txtPesquisar.Text);

        }
    }
}
