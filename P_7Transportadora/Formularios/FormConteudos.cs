/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-05
 * Hora: 16:06
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using P_7Transportadora.Entidades;
using P_7Transportadora.RG;

namespace P_7Transportadora.Formularios
{
	
	public partial class FormConteudos : Form
	{
		EntConteudos conteudo = new EntConteudos();
		RGconteudos rgconteudo = new RGconteudos();
		byte update; // 1 inserir, 2 editar
		
		public FormConteudos()
		{
			
			InitializeComponent();
		}
		
		
		void FormConteudosKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.F2)
			{
				tabControl1.SelectedTabIndex = 0;
				txt_localizar.Clear();
				txt_localizar.Focus();
			}
			
			if(e.KeyCode == Keys.F3)
			{
				tabControl1.SelectedTabIndex = 1;
			}
		}
				
		
		void Bt_fecharClick(object sender, EventArgs e)
		{
		   Close();
		}
		
		
		void FormConteudosShown(object sender, EventArgs e)
		{
			tabControl1.SelectedTabIndex = 0;
			txt_localizar.Clear();
			txt_localizar.Focus();
		}
		
		void HabilitaControles()
		{
			gb_dados.Enabled = true;
			bt_adicionar.Visible = false;
			bt_Editar.Visible = false;
			bt_excluir.Visible = false;
			bt_salvar.Visible = true;
		}
		
		void DesabilitaControles()
		{
			gb_dados.Enabled = false;
			bt_adicionar.Visible = true;
			bt_Editar.Visible = true;
			bt_excluir.Visible = true;
			bt_salvar.Visible = false;
		}
		
		void LimpaCampos()
		{
			txt_IdConteudo.Clear();
			txt_NomeConteudo.Clear();
		}
		
		void Bt_adicionarClick(object sender, EventArgs e)
		{
			update = 1;
			HabilitaControles();
			LimpaCampos();
			txt_NomeConteudo.Focus();
		}
		
		void Bt_EditarClick(object sender, EventArgs e)
		{
			if(txt_IdConteudo.Text == string.Empty) // verifica se o txt_nomecompania ta em branco
			{
				MessageBox.Show("Você não pode fazer edição com o Formulario em branco.","ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			    return;
			}
			else
			{
				update = 2;
				HabilitaControles();
				txt_NomeConteudo.Focus();
			}
		}
		
		void Bt_salvarClick(object sender, EventArgs e)
		{
			if(update == 1)
			{	
				if(txt_NomeConteudo.Text == string.Empty)
				{
					MessageBox.Show("Digite o Nome do Conteúdo.","ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txt_NomeConteudo.Focus();
			   		return;
				}
				else
				{
					rgconteudo.InserirConteudo(txt_NomeConteudo.Text);
				}	
			}
			
			else if(update == 2)
			{
				conteudo.IdConteudo = Convert.ToInt32(txt_IdConteudo.Text);
				conteudo.Descricao = txt_NomeConteudo.Text;
				rgconteudo.EditarConteudo(conteudo);
			}
			
			DesabilitaControles();
			LimpaCampos();		
		}
				
		
		void Bt_salvarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
			{
				txt_NomeConteudo.Focus();
			}
		}
		
		void Txt_localizarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				string nome = txt_localizar.Text;
				dgv_conteudos.DataSource = rgconteudo.RetornaConteudos(nome);
				dgv_conteudos.Columns[0].Visible = false;
				dgv_conteudos.Columns[1].HeaderText = " DESCRIÇÃO DO CONTEÚDO";
			}
			
			if(e.KeyCode == Keys.Down)
			{
				dgv_conteudos.Focus();
			}
		}
		
		void Dgv_conteudosKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				LimpaCampos();
				DesabilitaControles();
				txt_IdConteudo.Text = dgv_conteudos.SelectedCells[0].Value.ToString();
				txt_NomeConteudo.Text = dgv_conteudos.SelectedCells[1].Value.ToString();
				dgv_conteudos.DataSource = string.Empty;
				tabControl1.SelectedTabIndex = 1;
			}	
		}
		
				
		void Bt_excluirClick(object sender, EventArgs e)
		{
			if(txt_IdConteudo.Text == string.Empty )
			   {
				   	MessageBox.Show("Você não pode fazer exclusões com o Formulario em branco!","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
			 	  	return;
			   }
			   else
			   {
			  	 	if(MessageBox.Show("Tem certeza que deseja excluir este conteúdo?","EXCLUIR CONTEÚDO",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			  	 	{
			  	 		conteudo.IdConteudo = Convert.ToInt32(txt_IdConteudo.Text);
			  	 		rgconteudo.ExcluirConteudo(conteudo.IdConteudo);
			  	 		LimpaCampos();
			  	 	}
			  	 	else
			  	 	{
			  	 		return;
			  	 	}	
			   }
		}
		
		
		void Txt_NomeConteudoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				bt_salvar.Focus();
			}
		}
	}

}


