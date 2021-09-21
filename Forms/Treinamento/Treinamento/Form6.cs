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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btn_selecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transp.Text);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            cb_transp.Items.Clear();
            cb_transp.ResetText();

        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            cb_transp.Items.Clear();

            List<string> tr = new List<string>();

            tr.Add("Carro");
            tr.Add("Aviao");
            tr.Add("Navio");
            tr.Add("Onibus");
            tr.Add("Trem");

            cb_transp.Items.AddRange(tr.ToArray());
            cb_transp.ResetText();
        }

        private void cb_transp_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transp.Text = cb_transp.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_transp.Text != "")
            {
                if (cb_transp.FindString(tb_transp.Text) < 0)
                {
                    cb_transp.Items.Add(tb_transp.Text);
                }
            }
        }
    }
}
