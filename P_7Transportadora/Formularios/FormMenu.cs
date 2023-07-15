/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-05
 * Hora: 16:45
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace P_7Transportadora.Formularios
{
	
	public partial class FormMenu : Form
	{
		public FormMenu()
		{
			InitializeComponent();
		}
		
		void FormMenuKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
			{
				if (BarraMenu.Expanded == true)
				{
					BarraMenu.Expanded = false;
				}
				else
				{
					BarraMenu.Expanded = true;
				}
			}
		}
		
		void Bt_clienteClick(object sender, EventArgs e)
		{
			BarraMenu.Expanded = false;
			FormClientes form = new FormClientes();
			form.MdiParent = this;
			form.Show();
		}
		
		void Bt_companiaClick(object sender, EventArgs e)
		{
			BarraMenu.Expanded = false;
			FormCompanias form = new FormCompanias();
			form.MdiParent = this;
			form.Show();			
		}
		
		void Bt_conteudoClick(object sender, EventArgs e)
		{
			BarraMenu.Expanded = false;
			FormConteudos form = new FormConteudos();
			form.MdiParent = this;
			form.Show();	
		}
		
		void Bt_embalagemClick(object sender, EventArgs e)
		{
			BarraMenu.Expanded = false;
			FormEmbalagens form = new FormEmbalagens();
			form.MdiParent = this;
			form.Show();
		}
		
		
		void Bt_minutaClick(object sender, EventArgs e)
		{
			BarraMenu.Expanded = false;
			FormMinuta form = new FormMinuta();
			form.MdiParent = this;
			form.Show();
		}
		
		
		void Bt_fecharClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		
		void ButtonX1Click(object sender, EventArgs e)
		{
			BarraMenu.Expanded = false;
			FormSiglas form = new FormSiglas();
			form.MdiParent = this;
			form.Show();
		}
		
		
		
		void ButtonX2Click(object sender, EventArgs e)
		{
			BarraMenu.Expanded = false;
			Form1 form = new Form1();
			form.MdiParent = this;
			form.Show();
		}
		
		
		
		void Bt_relatoriosClick(object sender, EventArgs e)
		{
			BarraMenu.Expanded = false;
			FormRelatorioADM form = new FormRelatorioADM();
			form.MdiParent = this;
			form.Show();
		}
	}
}
