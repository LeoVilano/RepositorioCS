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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            ll_varios.Links.Add(0, 6, "www.google.com.br");
            ll_varios.Links.Add(7, 7, "www.youtube.com.br");

            ll_varios.Links[1].Enabled = false;       
         }

        private void ll_site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.thega.com.br");
            ll_site.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_varios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
