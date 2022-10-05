using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExInterface01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LbValorProduto_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbProdutos.SelectedIndex)
            {
                case 1:
                    LbValorProduto.Text = "500,00";
                    break;
                case 2:LbValorProduto.Text = "2.200,00";
                    break ;
                case 3: LbValorProduto.Text = "4.000,00";
                    break;;
                case 4: LbValorProduto.Text = "800,00";
                    break;
                case 5: LbValorProduto.Text = "1.000,00";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (cmbProdutos.SelectedIndex.Equals(0))
            {
                rest
            }
        }
    }
}
