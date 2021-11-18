using System;
using System.Collections.Generic;
using System.Text;

namespace _3A1GUILHERME16.code.DTO
{
    class loginDTO
    {

        private int _id;
        private string _email;
        private string _senha;

        public int id { get => _id; set => _id = value; }
        public string email { get => _email; set => _email = value; }
        public string senha { get => _senha; set => _senha = value; }

    }
}
