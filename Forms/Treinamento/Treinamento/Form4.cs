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
    public partial class Form4 : Form
    {
        public Form3 form3;
        public Form4()
        {
            InitializeComponent();
            form3 = Application.OpenForms["Form3"] as Form3;
            cb_carro.Checked = form3.cb_carro.Checked;
            cb_aviao.Checked = form3.cb_aviao.Checked;
            cb_navio.Checked = form3.cb_navio.Checked;
            cb_onibus.Checked = form3.cb_onibus.Checked;

        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            form3.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            form3.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            form3.cb_navio.Checked = cb_navio.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            form3.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}
