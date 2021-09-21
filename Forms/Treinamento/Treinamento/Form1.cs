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
    public partial class Form1 : Form
    {
        public int num;
        public Form1()
        {
            InitializeComponent();
            num = 0;
        }

        private void btn_001_Click(object sender, EventArgs e)
        {
            if (tb_digite.Text == "")
            {
                MessageBox.Show("Digite um valor para adicionar");
                tb_digite.Focus();
                return;
            }

            tb_digite2.Text +=  tb_digite.Text + ", ";
            tb_digite.Clear();
            tb_digite.Focus();

        }

        private void btm_limpar_Click(object sender, EventArgs e)
        {
            if (tb_digite2.Text == "")
            {
                MessageBox.Show("Nao existe valor para limpar");
                tb_digite.Focus();
                return;
            }
            else
            tb_digite2.Clear();
            tb_digite.Focus();
        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(tb_digite2.Text,this);
            form2.Show();

        }

        private void btn_variavel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();                      
            
        }

        private void checkedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void timePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }
    } 
}
