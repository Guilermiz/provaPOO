using System;
using System.Collections.Generic;
using System.Text;

namespace _3A1GUILHERME16.code.DTO
{
    class produtoDTO
    {

        private int _id;
        private string _nome;
        private double _valor;

        public int id { get => _id; set => _id = value; }
        public string nome { get => _nome; set => _nome = value; }
        public double valor { get => _valor; set => _valor = value; }

    }
}
