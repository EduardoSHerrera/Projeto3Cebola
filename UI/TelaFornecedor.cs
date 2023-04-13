using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3Camada
{
    public partial class TelaFornecedor : Form
    {
        public TelaFornecedor()
        {
            InitializeComponent();
        }
        Fornecedor Forn;
        private void CarregaTabela()
        {
            Forn = new Fornecedor();
            dgvDados.DataSource = Forn.Pesquisar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Forn = new Fornecedor();
            Forn.Id = int.Parse(txtID.Text);
            if (Forn.Excluir())
            {
                MessageBox.Show("Excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel exluir!");
            }
            CarregaTabela();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Forn = new Fornecedor();
            Forn.Id = int.Parse(txtID.Text);
            Forn.CNPJ = mtxtCNPJ.Text;
            Forn.Email = txtEmail.Text;
            Forn.Telefone = mtxtTelefone.Text;
            Forn.Razao = txtRazao.Text;
            MessageBox.Show(Forn.Atualizar() ? "Atualizado com sucesso" : "Não foi possivel atualizar!");
            CarregaTabela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Forn = new Fornecedor();
            Forn.Id = int.Parse(txtID.Text);
            Forn.CNPJ = mtxtCNPJ.Text;
            Forn.Email = txtEmail.Text;
            Forn.Telefone = mtxtTelefone.Text;
            Forn.Razao = txtRazao.Text;
            MessageBox.Show(Forn.Gravar() ? "Salvo com sucesso" : "Não foi possivel salvar!");
            CarregaTabela();
        }
    }
}
