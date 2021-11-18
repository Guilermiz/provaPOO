using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using _3A1GUILHERME16.code.DTO;
using _3A1GUILHERME16.code.DAL;

namespace _3A1GUILHERME16.code.BLL
{
    class loginBLL
    {

        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "usuario";

        public bool realizarLogin(loginDTO login)
        {
            string sql = $"select * from {tabela} where email ='{login.email}' and senha='{login.senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
