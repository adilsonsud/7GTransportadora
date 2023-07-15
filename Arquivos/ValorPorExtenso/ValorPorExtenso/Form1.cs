using System;
using System.Windows.Forms;

namespace ValorPorExtenso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExtenso_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor = Convert.ToDecimal(txtValor.Text);
                txtExtenso.Text = Conversor.EscreverExtenso(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }


        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)  && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // somente permite um ponto decimal
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }

        }
    }
}
