using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios2
{
    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                    nome = value;                
            }
        }
        private float idade;
        public float Idade
        {
            get { return idade; }
            set
            {
                if (idade < 12)
                {
                    idade = value;
                }
                else
                {
                    throw new Exception("Não é criança.");
                }
            }
        }
    }
}
