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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btn_pegar_Click(object sender, EventArgs e)
        {
            tb_completo.Text = dtp_time.Text;
            tb_dia.Text = dtp_time.Value.Day.ToString();
            tb_mes.Text = dtp_time.Value.Month.ToString();
            tb_ano.Text = dtp_time.Value.Year.ToString();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            int d, m, a;
            d = Int32.Parse(tb_dia.Text);
            m = Int32.Parse(tb_mes.Text);
            a = Int32.Parse(tb_ano.Text);

            DateTime dt = new DateTime(a, m, d);

            dtp_time.Value = dt;
        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {

            dtp_time.Value = DateTime.Today;
        }
    }
}
