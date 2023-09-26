using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNot1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapa_Click(object sender, EventArgs e)
        {
            int not1,not2;
            double sonuc;

            not1 =Convert.ToInt32(txtNot1.Text);
            not2 =Convert.ToInt32(txtNot2.Text);

            sonuc = (not1 + not2) / 2;

            lblSonuc.Text = sonuc.ToString();
        }
    }
}
