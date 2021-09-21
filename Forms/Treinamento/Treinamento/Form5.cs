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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(string t in clb_transp.CheckedItems)
            {
                txt += t + ", ";
            }

            MessageBox.Show(txt);

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            clb_transp.Items.Clear();
        }
        private void btn_resetar_Click(object sender, EventArgs e)
        {
            clb_transp.Items.Clear();

            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Aviao");
            tr.Add("Navio");
            tr.Add("Onibus");
            tr.Add("Trem");

            clb_transp.Items.AddRange(tr.ToArray());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_add.Text != "")
                clb_transp.Items.Add(tb_add.Text);
            else
                MessageBox.Show("O campo esta vazio");
        }

      
    }
}
