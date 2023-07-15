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
using P_7Transportadora.RG;
using P_7Transportadora.Entidades;

namespace P_7Transportadora.Formularios
{
	
	public partial class FormSiglas : Form
	{
		EntSiglas sigla = new EntSiglas();
		RGsiglas rgsigla = new RGsiglas();
		byte update; // 1 inserir, 2 editar
		
		public FormSiglas()
		{
			
			InitializeComponent();
		}
		
		
		void FormSiglasKeyDown(object sender, KeyEventArgs e)
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
		
		
		void FormSiglasShown(object sender, EventArgs e)
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
			txt_Idsigla.Clear();
			txt_sigla.Clear();
			txt_cidade.Clear();
			cb_uf.Text = "";
		}
		
		void Bt_adicionarClick(object sender, EventArgs e)
		{
			update = 1;
			HabilitaControles();
			LimpaCampos();
			txt_sigla.Focus();
		}
		
		void Bt_EditarClick(object sender, EventArgs e)
		{
			if(txt_Idsigla.Text == string.Empty) // verifica se o txt_nomecompania ta em branco
			{
				MessageBox.Show("Você não pode fazer edição com o Formulario em branco.","ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			    return;
			}
			else
			{
				update = 2;
				HabilitaControles();
				txt_sigla.Focus();
			}
		}
		
		void Bt_salvarClick(object sender, EventArgs e)
		{
			if(update == 1)
			{	
				if(txt_sigla.Text == string.Empty)
				{
					MessageBox.Show("Digite a SIGLA.","ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txt_sigla.Focus();
			   		return;
				}
				else
				{
					sigla.NomeSigla = txt_sigla.Text;
					sigla.Cidade = txt_cidade.Text;
					sigla.UF = cb_uf.Text;
					rgsigla.InserirSiglas(sigla);
					//rgcompania.InserirCompania(txt_sigla.Text);
				}	
			}
			
			else if(update == 2)
			{
//				compania.IdCompanias = Convert.ToInt32(txt_IdCompania.Text);
//				compania.Nome = txt_sigla.Text;
//				rgcompania.EditarCompania(compania);
				sigla.idSigla = Convert.ToInt32(txt_Idsigla.Text);
				sigla.NomeSigla = txt_sigla.Text;
				sigla.Cidade = txt_cidade.Text;
				sigla.UF = cb_uf.Text;
				rgsigla.EditarSiglas(sigla);
				
			}
			
			DesabilitaControles();
			LimpaCampos();		
		}
				
		
		void Bt_salvarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
			{
				cb_uf.Focus();
			}
		}
		
		void Txt_localizarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				string nome = txt_localizar.Text;
				dgv_siglas.DataSource = rgsigla.RetornaSiglas(txt_localizar.Text);
				dgv_siglas.Columns[0].Visible = false;
				dgv_siglas.Columns[1].Visible = true;
				dgv_siglas.Columns[2].Visible = true;
				dgv_siglas.Columns[3].Visible = true;
				
				dgv_siglas.Columns[1].HeaderText = " SIGLA";
				dgv_siglas.Columns[2].HeaderText = " CIDADE";
				dgv_siglas.Columns[3].HeaderText = " UF";
				
			}
			
			if(e.KeyCode == Keys.Down)
			{
				dgv_siglas.Focus();
			}
		}
		
		void dgv_siglasKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				LimpaCampos();
				DesabilitaControles();
				txt_Idsigla.Text = dgv_siglas.SelectedCells[0].Value.ToString();
				txt_sigla.Text = dgv_siglas.SelectedCells[1].Value.ToString();
				txt_cidade.Text = dgv_siglas.SelectedCells[2].Value.ToString();
				cb_uf.Text = dgv_siglas.SelectedCells[3].Value.ToString();
				dgv_siglas.DataSource = string.Empty;
				tabControl1.SelectedTabIndex = 1;
			}	
		}
		
				
		void Bt_excluirClick(object sender, EventArgs e)
		{
			if(txt_Idsigla.Text == string.Empty )
			   {
				   	MessageBox.Show("Você não pode fazer exclusões com o Formulario em branco!","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
			 	  	return;
			   }
			   else
			   {
			  	 	if(MessageBox.Show("Tem certeza que deseja excluir esta SIGLA?","EXCLUIR SIGLA",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			  	 	{
			  	 		sigla.idSigla = Convert.ToInt32(txt_Idsigla.Text);
			  	 		rgsigla.ExcluirSiglas(sigla.idSigla);
			  	 		LimpaCampos();
			  	 	}
			  	 	else
			  	 	{
			  	 		return;
			  	 	}	
			   }
		}
			
		
		void Txt_siglaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_cidade.Focus();
			}
		}
		
		void Txt_cidadeKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				cb_uf.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_sigla.Focus();
			}
		}
		
		void Cb_ufKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				bt_salvar.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_cidade.Focus();
			}
		}
	}

}


