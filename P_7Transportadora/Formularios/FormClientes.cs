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

namespace P_7Transportadora.Formularios
{
	
	public partial class FormClientes : Form
	{
		string TipoPessoa; // J para pessoa Juridica e F para pessoa fisica.
		byte update; // 1 inserir, 2 editar
		Entidades.EntClientes cliente = new Entidades.EntClientes();
		RG.RGclientes rgCliente = new RG.RGclientes();
		
		public FormClientes()
		{
			
			InitializeComponent();
		}
		
		
		void FormClientesKeyDown(object sender, KeyEventArgs e)
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
		
		
		void Rbt_PfisicaClick(object sender, EventArgs e)
		{
			txt_cpf.Visible = true;
			txt_cnpj.Visible = false;
			txt_cpf.Enabled = true;
			txt_cpf.Focus();	
		}
		
		void Rbt_PjuridicaClick(object sender, EventArgs e)
		{
		    txt_cnpj.Visible = true;
			txt_cpf.Visible = false;
			txt_cnpj.Enabled = true;
			txt_cnpj.Focus();
		}
		
		void Bt_fecharClick(object sender, EventArgs e)
		{
		   Close();
		}
		
		
		void FormClientesShown(object sender, EventArgs e)
		{
			tabControl1.SelectedTabIndex = 0;
			txt_localizar.Clear();
			txt_localizar.Focus();
		}
		
		void HabilitaControles()
		{
			gb_dados.Enabled = true;
			gb_endereco.Enabled = true;
			gb_contatos.Enabled = true;
			
			bt_adicionar.Visible = false;
			bt_Editar.Visible = false;
			bt_excluir.Visible = false;
			bt_salvar.Visible = true;
		}
		
		void DesabilitaControles()
		{
			gb_dados.Enabled = false;
			gb_endereco.Enabled = false;
			gb_contatos.Enabled = false;
			
			bt_adicionar.Visible = true;
			bt_Editar.Visible = true;
			bt_excluir.Visible = true;
			bt_salvar.Visible = false;
		}
		
		void LimpaCampos()
		{
			txt_cpf.Clear();
			txt_cnpj.Clear();
			txt_NomeCliente.Clear();
			txt_endereco.Clear();
			txt_complemento.Clear();
			txt_bairro.Clear();
			txt_cidade.Clear();
			txt_uf.Text = "";
			txt_cep.Clear();
			txt_fone1.Clear();
			txt_fone2.Clear();
			txt_fone3.Clear();
			txt_fone4.Clear();
			txt_email.Clear();
			txt_site.Clear();
			rbt_Pfisica.Checked = false;
			rbt_Pjuridica.Checked = false;
			txt_cnpj.Enabled = false;
			txt_cpf.Enabled = false;
		}
		
		void Bt_adicionarClick(object sender, EventArgs e)
		{
			update = 1;
			HabilitaControles();
			LimpaCampos();
		}
		
		void Bt_EditarClick(object sender, EventArgs e)
		{
			if(txt_cpf.Text == string.Empty  && txt_cnpj.Text == string.Empty)
			   {
				   	MessageBox.Show("Você não pode fazer edições com o Formulario em branco!","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
			 	  	return;
			   }
			   else
			   {
				   update = 2;
				   HabilitaControles();
			   }
		}
		
		void Bt_salvarClick(object sender, EventArgs e)
		{
			 int prossegue;
			
			if(rbt_Pfisica.Checked == false && rbt_Pjuridica.Checked == false)// verifica se ambos rbt estão em branco
			{
				MessageBox.Show("Marque a opção Pessoa Física ou Pessoa Jurídica","ATENÇÃO - PESSOA EM BRANCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else if(rbt_Pfisica.Checked == true) // verifica se o rbt pessoa fisica foi clicado
			{
				if(txt_cpf.Text == string.Empty) // verifica se o cpf ta em branco
				{
					MessageBox.Show("Preencha o campo CPF/CNPJ","ATENÇÃO - CAMPO EM BRANCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				    return;
				}
				
				TipoPessoa = "F";
				cliente.CPFCNPJ = txt_cpf.Text;
			}
			else if(rbt_Pjuridica.Checked == true) // verifica se o rbt pessoa juridica foi clicado
			{
				if(txt_cnpj.Text == string.Empty) // verificase o cnpj ta em branco
				{
					MessageBox.Show("Preencha o campo CPF/CNPJ","ATENÇÃO - CAMPO EM BRANCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				TipoPessoa = "J";
				cliente.CPFCNPJ = txt_cnpj.Text;
			}
				
			if(update == 1) // verifica se será inserido ou editado no banco de dados
			{
					//primeiro verifica se já existe cliente com o cpf/cnpj informado
					prossegue = rgCliente.verificaCliente(cliente.CPFCNPJ);
					if(prossegue == 1)
					{
						MessageBox.Show("Antes de inserir um cliente, verifique se ele já esta cadastrado no banco de dados!","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
						LimpaCampos();
						DesabilitaControles();
						tabControl1.SelectedTabIndex = 0;
						txt_localizar.Focus();	
						return;
					}
					else // caso o cpfcnpj não seja repetido, faz a inserção 
					{
						cliente.PessoaFJ = TipoPessoa;
						//CpfCnpj é preenchido na verificação acima
						cliente.Nome = txt_NomeCliente.Text;
						cliente.Endereco = txt_endereco.Text;
						cliente.Complemento = txt_complemento.Text;
						cliente.Bairro = txt_bairro.Text;
						cliente.Cidade = txt_cidade.Text;
						cliente.UF = txt_uf.Text;
						cliente.CEP = txt_cep.Text;
						cliente.Fone1 = txt_fone1.Text;
						cliente.Fone2 = txt_fone2.Text;
						cliente.Fone3 = txt_fone3.Text;	
						cliente.Fone4 = txt_fone4.Text;	
						cliente.Email = txt_email.Text;
						cliente.Site = txt_site.Text;
						rgCliente.InserirCliente(cliente);	
					}
			}			
			else if (update == 2)
			{
				cliente.PessoaFJ = TipoPessoa;
				//CpfCnpj é preenchido na verificação acima
				cliente.Nome = txt_NomeCliente.Text;
				cliente.Endereco = txt_endereco.Text;
				cliente.Complemento = txt_complemento.Text;
				cliente.Bairro = txt_bairro.Text;
				cliente.Cidade = txt_cidade.Text;
				cliente.UF = txt_uf.Text;
				cliente.CEP = txt_cep.Text;
				cliente.Fone1 = txt_fone1.Text;
				cliente.Fone2 = txt_fone2.Text;
				cliente.Fone3 = txt_fone3.Text;	
				cliente.Fone4 = txt_fone4.Text;	
				cliente.Email = txt_email.Text;
				cliente.Site = txt_site.Text;
				rgCliente.EditarCliente(cliente);
			}
					
				DesabilitaControles();
				LimpaCampos();
				txt_cpf.Enabled = false;
				txt_cnpj.Enabled = false;
		}
				
		
		void Txt_cpfKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				int prossegue;
				
				prossegue = rgCliente.verificaCliente(txt_cpf.Text);
				if(prossegue == 0)
				{
					txt_NomeCliente.Focus();
					return;
				}
				else
				{
					MessageBox.Show("Antes de inserir um cliente, verifique se ele já esta cadastrado no banco de dados.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
					LimpaCampos();
					DesabilitaControles();
					tabControl1.SelectedTabIndex = 0;
					txt_localizar.Focus();					
				}				
			}				
		}
		
		
		
		void Txt_cnpjKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				int prossegue; // 0 não tem ninguem, 1 cpf ou cnpj já esta cadastrado
				prossegue = rgCliente.verificaCliente(txt_cnpj.Text);
				if(prossegue == 0)
				{
					txt_NomeCliente.Focus();
					return;
				}
				else
				{
					MessageBox.Show("Antes de inserir um cliente, verifique se ele já esta cadastrado no banco de dados!","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
					LimpaCampos();
					DesabilitaControles();
					tabControl1.SelectedTabIndex = 0;
					txt_localizar.Focus();					
				}				
			}			
		}
		
		void Txt_NomeClienteKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				txt_endereco.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_cpf.Focus();
			}
		}
		
		void Txt_enderecoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				txt_complemento.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_NomeCliente.Focus();
			}
		}
		
		void Txt_complementoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				txt_bairro.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_endereco.Focus();
			}
		}
		
		void Txt_bairroKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				txt_cidade.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_complemento.Focus();
			}
		}
		
		void Txt_cidadeKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				pnl_cidade.Visible = true;
				pnl_cidade.Width = 307;
				pnl_cidade.Height = 256;
				pnl_cidade.Left = 493;
				pnl_cidade.Top = 188;
				txt_LocalizaCidade.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_bairro.Focus();
				dgv_cidade.DataSource = string.Empty;
				pnl_cidade.Visible = false;
				
			}
		}
		
		
		
		
		void Txt_cepKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				txt_fone1.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_cidade.Focus();
			}
		}
		
		void Txt_fone1KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				txt_fone2.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_cep.Focus();
			}
		}
		
		void Txt_fone2KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				txt_fone3.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_fone1.Focus();
			}
		}
		
		void Txt_fone3KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				txt_fone4.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_fone2.Focus();
			}
		}
		
		void Txt_fone4KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				txt_email.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_fone3.Focus();
			}
		}
		
		void Txt_emailKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				txt_site.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_fone4.Focus();
			}
		}
		
		void Txt_siteKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				bt_salvar.Focus();
			}
			
			if(e.KeyCode == Keys.Escape)
			{
				txt_email.Focus();
			}
		}
		
		void Bt_salvarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
			{
				txt_site.Focus();
			}
		}
		
		void Txt_localizarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				string nome = txt_localizar.Text;
				//   0			1		2		3		  4		   5	     6      7   8     9      10     11    12     13     14       15    
				//idcliente, CPFCNPJ, Nome, Endereco, Complemento, Bairro, Cidade, UF, CEP, Fone1, Fone2, Fone3, Fone4, Email, Site, PessoaFJ
				dgv_clientes.DataSource = rgCliente.RetornaClientes(nome);
				dgv_clientes.Columns[0].Visible = false;
				dgv_clientes.Columns[11].Visible = false;
				dgv_clientes.Columns[12].Visible = false;
				dgv_clientes.Columns[14].Visible = false;
			}
			
			if(e.KeyCode == Keys.Down)
			{
				dgv_clientes.Focus();
			}
		}
		
		void Dgv_clientesKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				LimpaCampos();
				DesabilitaControles();
				TipoPessoa = dgv_clientes.SelectedCells[15].Value.ToString();
				if(TipoPessoa == "F")
				{
					rbt_Pfisica.Checked = true;
					rbt_Pjuridica.Checked = false;
					txt_cpf.Visible = true;
					txt_cnpj.Visible = false;	
					txt_cpf.Text = dgv_clientes.SelectedCells[1].Value.ToString();
				}
				else if(TipoPessoa == "J")
				{
					rbt_Pfisica.Checked = false;
					rbt_Pjuridica.Checked = true;
					txt_cnpj.Visible = true;
					txt_cpf.Visible = false;
					txt_cnpj.Text = dgv_clientes.SelectedCells[1].Value.ToString();
				}
				cliente.IdCliente = Convert.ToInt32(dgv_clientes.SelectedCells[0].Value.ToString());
				txt_NomeCliente.Text = dgv_clientes.SelectedCells[2].Value.ToString();
				txt_endereco.Text = dgv_clientes.SelectedCells[3].Value.ToString();
				txt_complemento.Text = dgv_clientes.SelectedCells[4].Value.ToString();
				txt_bairro.Text = dgv_clientes.SelectedCells[5].Value.ToString();
				txt_cidade.Text = dgv_clientes.SelectedCells[6].Value.ToString();
				txt_uf.Text = dgv_clientes.SelectedCells[7].Value.ToString();
				txt_cep.Text = dgv_clientes.SelectedCells[8].Value.ToString();
				txt_fone1.Text = dgv_clientes.SelectedCells[9].Value.ToString();
				txt_fone2.Text = dgv_clientes.SelectedCells[10].Value.ToString();
				txt_fone3.Text = dgv_clientes.SelectedCells[11].Value.ToString();
				txt_fone4.Text = dgv_clientes.SelectedCells[12].Value.ToString();
				txt_email.Text = dgv_clientes.SelectedCells[13].Value.ToString();
				txt_site.Text = dgv_clientes.SelectedCells[14].Value.ToString();
				dgv_clientes.DataSource = string.Empty;
				tabControl1.SelectedTabIndex = 1;	
			}
		}
		
		
		
		void Bt_excluirClick(object sender, EventArgs e)
		{
			if(txt_cpf.Text == string.Empty  && txt_cnpj.Text == string.Empty)
			   {
				   	MessageBox.Show("Você não pode fazer exclusões com o Formulario em branco!","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
			 	  	return;
			   }
			   else
			   {
			  	 	if(MessageBox.Show("Tem certeza que deseja excluir este cliente?","EXCLUIR CLIENTE",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			  	 	{
			  	 		rgCliente.ExcluirCliente(cliente.IdCliente);
			  	 		LimpaCampos();
			  	 	}
			  	 	else
			  	 	{
			  	 		return;
			  	 	}	
			   }
		}
		
		
		void Txt_LocalizaCidadeKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				RGsiglas rgsiglas = new RGsiglas();
				dgv_cidade.DataSource = rgsiglas.RetornaSiglas(txt_LocalizaCidade.Text);  
				//    0			1		  2		3
				// idSigla  NomeSigla   Cidade  UF
				
				dgv_cidade.Columns[0].Visible = false;
				dgv_cidade.Columns[1].Visible = false;
				dgv_cidade.Columns[2].Visible = true;
				dgv_cidade.Columns[3].Visible = true;
				
				dgv_cidade.Columns[2].HeaderText = "CIDADE";
				dgv_cidade.Columns[3].HeaderText = "UF";	

				dgv_cidade.Columns[2].Width = 160;
				dgv_cidade.Columns[3].Width = 50;									
			}
			
			if(e.KeyCode.Equals(Keys.Down))
			{
				dgv_cidade.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_cidade.Focus();
				dgv_cidade.DataSource =string.Empty;
				txt_LocalizaCidade.Clear();
			}
		}
		
		void Dgv_cidadeKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				if(dgv_cidade.RowCount < 1)
				{
					MessageBox.Show("Não existe informações no gride.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
					txt_LocalizaCidade.Focus();
				}
				else
				{
					//    0			1		  2		3
					// idSigla  NomeSigla   Cidade  UF
					txt_cidade.Text = dgv_cidade.SelectedCells[2].Value.ToString();
					txt_uf.Text = dgv_cidade.SelectedCells[3].Value.ToString(); 				
					pnl_cidade.Visible = false;
					txt_cep.Focus();
					dgv_cidade.DataSource = string.Empty;
				}
				
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_LocalizaCidade.Focus();
			}
		}
		
		
		
	}

}


//TODO: Colocar mascara para cpfcnpj no form quando localiza no gride
//TODO: tentar colocar mascara para os campos no gride

