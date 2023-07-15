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

namespace P_7Transportadora.Formularios
{
	
	public partial class FormCompanias : Form
	{
		Entidades.EntCompanias  compania = new P_7Transportadora.Entidades.EntCompanias();
		RG.RGcompanias rgcompania = new RG.RGcompanias();
		byte update; // 1 inserir, 2 editar
		
		public FormCompanias()
		{
			
			InitializeComponent();
		}
		
		
		void FormCompaniasKeyDown(object sender, KeyEventArgs e)
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
		
		
		void FormCompaniasShown(object sender, EventArgs e)
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
			txt_IdCompania.Clear();
			txt_NomeCompania.Clear();
		}
		
		void Bt_adicionarClick(object sender, EventArgs e)
		{
			update = 1;
			HabilitaControles();
			LimpaCampos();
			txt_NomeCompania.Focus();
		}
		
		void Bt_EditarClick(object sender, EventArgs e)
		{
			if(txt_IdCompania.Text == string.Empty) // verifica se o txt_nomecompania ta em branco
			{
				MessageBox.Show("Você não pode fazer edição com o Formulario em branco.","ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			    return;
			}
			else
			{
				update = 2;
				HabilitaControles();
				txt_NomeCompania.Focus();
			}
		}
		
		void Bt_salvarClick(object sender, EventArgs e)
		{
			if(update == 1)
			{	
				if(txt_NomeCompania.Text == string.Empty)
				{
					MessageBox.Show("Digite o Nome da Compania.","ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txt_NomeCompania.Focus();
			   		return;
				}
				else
				{
					rgcompania.InserirCompania(txt_NomeCompania.Text);
				}	
			}
			
			else if(update == 2)
			{
				compania.IdCompanias = Convert.ToInt32(txt_IdCompania.Text);
				compania.Nome = txt_NomeCompania.Text;
				rgcompania.EditarCompania(compania);
			}
			
			DesabilitaControles();
			LimpaCampos();		
		}
				
		
		void Bt_salvarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
			{
				txt_NomeCompania.Focus();
			}
		}
		
		void Txt_localizarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				string nome = txt_localizar.Text;
				dgv_companias.DataSource = rgcompania.RetornaCompanias(nome);
				dgv_companias.Columns[0].Visible = false;
				dgv_companias.Columns[1].HeaderText = " NOME DA COMPANIA";
			}
			
			if(e.KeyCode == Keys.Down)
			{
				dgv_companias.Focus();
			}
		}
		
		void Dgv_companiasKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				LimpaCampos();
				DesabilitaControles();
				txt_IdCompania.Text = dgv_companias.SelectedCells[0].Value.ToString();
				txt_NomeCompania.Text = dgv_companias.SelectedCells[1].Value.ToString();
				dgv_companias.DataSource = string.Empty;
				tabControl1.SelectedTabIndex = 1;
			}	
		}
		
				
		void Bt_excluirClick(object sender, EventArgs e)
		{
			if(txt_IdCompania.Text == string.Empty )
			   {
				   	MessageBox.Show("Você não pode fazer exclusões com o Formulario em branco!","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
			 	  	return;
			   }
			   else
			   {
			  	 	if(MessageBox.Show("Tem certeza que deseja excluir esta compania?","EXCLUIR COMPANIA",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			  	 	{
			  	 		compania.IdCompanias = Convert.ToInt32(txt_IdCompania.Text);
			  	 		rgcompania.ExcluirCompania(compania.IdCompanias);
			  	 		LimpaCampos();
			  	 	}
			  	 	else
			  	 	{
			  	 		return;
			  	 	}	
			   }
		}
		
		
		void Txt_NomeCompaniaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				bt_salvar.Focus();
			}
		}
	}

}


