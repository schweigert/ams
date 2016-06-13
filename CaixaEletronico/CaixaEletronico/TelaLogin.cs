using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Fleyhe.Network;

namespace CaixaEletronico
{
    public partial class TelaLogin : Form
    {

        public static TelaLogin tela;

        public TelaLogin()
        {
            InitializeComponent();
            tela = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conta = textBox_Conta.Text;
            string senha = textBox_Senha.Text;

            TelaSelecao tela = new TelaSelecao();

            Authentication.name = conta;
            Authentication.password = senha;

            tela.Show();
            
            this.Hide();

        }

        
    }
}
