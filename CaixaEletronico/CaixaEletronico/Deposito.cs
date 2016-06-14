using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string de = textBox1.Text;
            string para = textBox2.Text;
            bool dep = checkBox2.Checked;
            bool parap = checkBox1.Checked;
            float valor = 0.0f;


        }
    }
}
