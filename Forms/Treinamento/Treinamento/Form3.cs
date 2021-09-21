using System;
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
    public partial class Form3 : Form
    {
        List<CheckBox> t = new List<CheckBox>();        
        public Form3()
        {
            InitializeComponent();
            t.Add(cb_aviao);
            t.Add(cb_navio);
            t.Add(cb_onibus);
            t.Add(cb_carro);

        }

        private void btn_marcado_Click(object sender, EventArgs e)
        {
            string txt = "";
            /*if (cb_carro.Checked)
            {
                txt += cb_carro.Text + ", ";
            }
            if (cb_navio.Checked)
            {
                txt += cb_navio.Text + ", ";
            }
            if (cb_aviao.Checked)
            {
                txt += cb_aviao.Text + ", ";
            }
            if (cb_onibus.Checked)
            {
                txt += cb_onibus.Text + ", ";
            }*/

            foreach (CheckBox tr in t)
            {
                if (tr.Checked)
                {
                    txt += tr.Text + ", ";
                }
            }

            MessageBox.Show(txt);            
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_patinete.Checked)
            {
                MessageBox.Show("Patinete Marcada");
            }
        }

        private void btn_auxiliar_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();

        }
    }
}
