﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treinamento
{
    public partial class Form2 : Form
    {
        Form1 fp;
        public Form2(string v, Form1 f)
        {
            InitializeComponent();

            tb_digite2.Text = v;
            fp = f;
            f.num = 10;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_digite2.Text = tb_digite2.Text;
        }

    }
}
