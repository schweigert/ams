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
    public partial class TelaSelecao : Form
    {
        public TelaSelecao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaLogin.tela.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TelaLog log = new TelaLog();
            log.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TelaCadastroCliente tcc = new TelaCadastroCliente();
            tcc.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] args = new string[1];
            args[0] = "qq coisa";
            Request req = new Request("ConfirmJuros", args);
            if (req.Event.ToString().Normalize() == "ok")
            {
                MessageBox.Show("Atualizado");
            } else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}
