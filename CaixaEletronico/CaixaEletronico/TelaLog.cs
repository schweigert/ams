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
            string[] args = new string[2];
            args[0] = Authentication.name;
            args[1] = Authentication.password;

            Request req = new Request("Log", args);

            string log = "";

            foreach(string i in req.response)
            {
                Console.WriteLine(i);
                log += i;
            }

            richTextBox1.Text = log;
        }

    }
}
