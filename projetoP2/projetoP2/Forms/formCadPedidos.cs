using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoP2.Forms
{
    public partial class formCadPedidos : Form
    {
        public formCadPedidos()
        {
            InitializeComponent();
        }

        private void AcionarItemInputs(int qtd)
        {
            Control[] item2Controls = new Control[]
            {
                lbItem2, lbItemId2, txtItemId2, btnConsultarItemId2,
                lbNomeItem2, txtItemNome2, lbQuantidadeItem2, lbTotalItem2,
                btnMenosItem2, txtQtdItem2, btnMaisItem2, txtTotalItem2
            };

            Control[] item3Controls = new Control[]
            {
                lbItem3, lbItemId3, txtItemId3, btnConsultarItemId3,
                lbNomeItem3, txtItemNome3, lbQuantidadeItem3, lbTotalItem3,
                btnMenosItem3, txtQtdItem3, btnMaisItem3, txtTotalItem3
            };

            SetVisibilidadeControles(item2Controls, qtd >= 2);
            SetVisibilidadeControles(item3Controls, qtd == 3);
        }

        private void SetVisibilidadeControles(Control[] controles, bool visibilidade)
        {
            foreach (var controle in controles)
            {
                controle.Visible = visibilidade;
            }
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            if (rad1.Checked)
            {
                AcionarItemInputs(1);
            }
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            if (rad2.Checked)
            {
                AcionarItemInputs(2);
            }
        }

        private void rad3_CheckedChanged(object sender, EventArgs e)
        {
            if (rad3.Checked)
            {
                AcionarItemInputs(3);
            }
        }
    }
}
