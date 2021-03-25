using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoaNova = new Pessoa()
                {
                    Nome = txtNome.Text,
                    Idade = float.Parse(txtIdade.Text)                    
                };
                MessageBox.Show("Ela é criança");
            }
            
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        { }
    }
}
