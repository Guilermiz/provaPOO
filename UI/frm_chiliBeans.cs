using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _3A1GUILHERME16.code;
using _3A1GUILHERME16.code.BLL;
using _3A1GUILHERME16.code.DTO;

namespace _3A1GUILHERME16.UI
{
    public partial class frm_chiliBeans : Form
    {

        produtoDTO prodDto = new produtoDTO();
        produtoBLL prodBll = new produtoBLL();

        public frm_chiliBeans()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            prodDto.nome = txtNome.Text;
            prodDto.valor = double.Parse(txtValor.Text);

            prodBll.Inserir(prodDto);
            MessageBox.Show("Produto Adicionado");
            txtId.Clear();
            txtNome.Clear();
            txtValor.Clear();

            gridListar.DataSource = prodBll.Listar();
        }

        private void frm_chiliBeans_Load(object sender, EventArgs e)
        {
            gridListar.DataSource = prodBll.Listar();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            prodDto.id = int.Parse(txtId.Text);
            prodDto.nome = txtNome.Text;
            prodDto.valor = double.Parse(txtValor.Text);

            prodBll.Editar(prodDto);
            MessageBox.Show("Produto Alterado");
            txtId.Clear();
            txtNome.Clear();
            txtValor.Clear();

            gridListar.DataSource = prodBll.Listar();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            prodDto.id = int.Parse(txtId.Text);

            prodBll.Deletar(prodDto);
            MessageBox.Show("Produto Deletado");
            txtId.Clear();
            txtNome.Clear();
            txtValor.Clear();

            gridListar.DataSource = prodBll.Listar();
        }
    }
}
