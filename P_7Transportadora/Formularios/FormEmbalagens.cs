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
	
	public partial class FormEmbalagens : Form
	{
		EntEmbalagens embalagem = new EntEmbalagens();
		RGembalagens rgembalagem = new RGembalagens();
		byte update; // 1 inserir, 2 editar
		
		public FormEmbalagens()
		{
			
			InitializeComponent();
		}
		
		
		void FormEmbalagensKeyDown(object sender, KeyEventArgs e)
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
		
		
		void FormEmbalagensShown(object sender, EventArgs e)
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
			txt_IdEmbalagem.Clear();
			txt_Descricao.Clear();
		}
		
		void Bt_adicionarClick(object sender, EventArgs e)
		{
			update = 1;
			HabilitaControles();
			LimpaCampos();
			txt_Descricao.Focus();
		}
		
		void Bt_EditarClick(object sender, EventArgs e)
		{
			if(txt_IdEmbalagem.Text == string.Empty) // verifica se o txt_nomecompania ta em branco
			{
				MessageBox.Show("Você não pode fazer edição com o Formulario em branco.","ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			    return;
			}
			else
			{
				update = 2;
				HabilitaControles();
				txt_Descricao.Focus();
			}
		}
		
		void Bt_salvarClick(object sender, EventArgs e)
		{
			if(update == 1)
			{	
				if(txt_Descricao.Text == string.Empty)
				{
					MessageBox.Show("Digite o descrição da Embalagem.","ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txt_Descricao.Focus();
			   		return;
				}
				else
				{
					rgembalagem.InserirEmbalagem(txt_Descricao.Text);
				}	
			}
			
			else if(update == 2)
			{
				embalagem.IdEmbalagem = Convert.ToInt32(txt_IdEmbalagem.Text);
				embalagem.Descricao = txt_Descricao.Text;
				rgembalagem.EditarEmbalagem(embalagem);
			}
			
			DesabilitaControles();
			LimpaCampos();		
		}
				
		
		void Bt_salvarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
			{
				txt_Descricao.Focus();
			}
		}
		
		void Txt_localizarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				string nome = txt_localizar.Text;
				dgv_embalagem.DataSource = rgembalagem.RetornaEmbalagem(nome);
				dgv_embalagem.Columns[0].Visible = false;
				dgv_embalagem.Columns[1].HeaderText = " DESCRIÇÃO DA EMBALAGEM";
			}
			
			if(e.KeyCode == Keys.Down)
			{
				dgv_embalagem.Focus();
			}
		}
		
		void dgv_embalagemKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				LimpaCampos();
				DesabilitaControles();
				txt_IdEmbalagem.Text = dgv_embalagem.SelectedCells[0].Value.ToString();
				txt_Descricao.Text = dgv_embalagem.SelectedCells[1].Value.ToString();
				dgv_embalagem.DataSource = string.Empty;
				tabControl1.SelectedTabIndex = 1;
			}	
		}
		
				
		void Bt_excluirClick(object sender, EventArgs e)
		{
			if(txt_IdEmbalagem.Text.Equals(string.Empty) )
			   {
				   	MessageBox.Show("Você não pode fazer exclusões com o Formulario em branco!","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
			 	  	return;
			   }
			   else
			   {
			  	 	if(MessageBox.Show("Tem certeza que deseja excluir esta Embalagem?","EXCLUIR EMBALAGEM",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			  	 	{
			  	 		embalagem.IdEmbalagem = Convert.ToInt32(txt_IdEmbalagem.Text);
			  	 		rgembalagem.ExcluirEmbalagem(embalagem.IdEmbalagem);
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


