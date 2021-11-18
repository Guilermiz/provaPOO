using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3A1GUILHERME16.code.DTO;
using _3A1GUILHERME16.code.BLL;
using _3A1GUILHERME16.UI;

namespace _3A1GUILHERME16
{
    public partial class frm_login : Form

    {

        loginBLL logBll = new loginBLL();
        loginDTO logdto = new loginDTO();

        public frm_login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            logdto.email = txtEmail.Text;
            logdto.senha = txtSenha.Text;

            bool conferir = logBll.realizarLogin(logdto);

            if (conferir)
            {
                MessageBox.Show("login realizado");

                frm_chiliBeans acessar = new frm_chiliBeans();
                acessar.Show();
                Hide();

            } else
            {
                MessageBox.Show("email ou senha incorreto");
            }

        }
    }
}
