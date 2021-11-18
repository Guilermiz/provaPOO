using System;
using System.Collections.Generic;
using System.Text;

using _3A1GUILHERME16.code.DTO;
using _3A1GUILHERME16.code.DAL;
using System.Data;

namespace _3A1GUILHERME16.code
{
    class produtoBLL
    {

        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "produto";

        public void Inserir (produtoDTO prodDTO)
        {

            string sql = $"insert into {tabela} values(null, '{prodDTO.nome}', '{prodDTO.valor}')";
            DataTable dt = conexao.ExecutarConsulta(sql);

        }

        public DataTable Listar()
        {

            string sql = $"select * from {tabela}";
            return conexao.ExecutarConsulta(sql);

        }

        public void Editar(produtoDTO prodDTO)
        {
            string sql = $"update {tabela} set nome = '{prodDTO.nome}', valor = '{prodDTO.valor}' where id = '{prodDTO.id}'";
            conexao.ExecutarConsulta(sql);
        }

        public void Deletar(produtoDTO prodDTO)
        {
            string sql = $"delete from {tabela} where id = '{prodDTO.id}'";
            conexao.ExecutarConsulta(sql);
        }
    }
}
