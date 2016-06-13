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
    public partial class TelaLog : Form
    {
        public TelaLog()
        {
            InitializeComponent();
            
            Request req = new Request("Log", new Object[0]);
            string log = "";

            for (int i = 0; i < req.response.Length; i++)
            {
                log += req.response[i];
            }
            richTextBox1.Text = log;
        }

    }
}
