/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-18
 * Hora: 20:44
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using P_7Transportadora.Entidades;
using P_7Transportadora.RG;
using P_7Transportadora.Utilitarios;



namespace P_7Transportadora.Formularios
{
	
	public partial class FormMinuta : Form
	{
		CultureInfo br = new CultureInfo("pt-br");
		EntClientes cliente = new EntClientes();
		EntClientes destinatario = new EntClientes();
		EntMinutas minuta = new EntMinutas();
		RGminutas rgminuta = new RGminutas();
		RGclientes rgcliente = new RGclientes();
		RGsiglas rgsigla = new RGsiglas();
		byte update; // 1 inserir, 2 editar
		
		public FormMinuta()
		{
			InitializeComponent();
		}
		
		
		void bt_fecharClick(object sender, EventArgs e)
		{
			Close();
		}	
		
		void Txt_NminutaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
		   {
			   	txt_expedidor.Focus();
		   }
		}
		
		void Txt_expedidorKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
		   {
			   	txt_cliente.Focus();
		   }
			
			if(e.KeyCode.Equals(Keys.Escape))
			   {
			   	txt_Nminuta.Focus();
			   }
		}
		
		void Txt_clienteKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				pnl_cliente.Visible = true;
				pnl_cliente.Width = 393;
				pnl_cliente.Height = 322;
				pnl_cliente.Left = 103;
				pnl_cliente.Top = 141;
				txt_localizaCliente.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_expedidor.Focus();
			}
		}
		
		void Dgv_clientesKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				
				try
				{	
					//     0         1      2      3           4          5       6     7   8     9      10     11     12     13    14       15   
					//idCliente, CPFCNPJ, Nome, Endereco, Complemento, Bairro, Cidade, UF, CEP, Fone1, Fone2, Fone3, Fone4, Email, Site, PessoaFJ
					cliente.CPFCNPJ = dgv_clientes.SelectedCells[1].Value.ToString();
					txt_cliente.Text = dgv_clientes.SelectedCells[2].Value.ToString();
					txt_endereco.Text = dgv_clientes.SelectedCells[3].Value.ToString();
					txt_complemento.Text = dgv_clientes.SelectedCells[4].Value.ToString();
					txt_bairro.Text = dgv_clientes.SelectedCells[5].Value.ToString();
					txt_cidade.Text = dgv_clientes.SelectedCells[6].Value.ToString();
					txt_uf.Text = dgv_clientes.SelectedCells[7].Value.ToString();
					txt_cep.Text = dgv_clientes.SelectedCells[8].Value.ToString();
					txt_fone1.Text = dgv_clientes.SelectedCells[9].Value.ToString();
					txt_fone2.Text = dgv_clientes.SelectedCells[10].Value.ToString();
					cliente.Fone3 = dgv_clientes.SelectedCells[11].Value.ToString();
					cliente.Fone4 = dgv_clientes.SelectedCells[12].Value.ToString();
					txt_email.Text = dgv_clientes.SelectedCells[13].Value.ToString();
					cliente.Site = dgv_clientes.SelectedCells[14].Value.ToString();
					cliente.PessoaFJ = dgv_clientes.SelectedCells[15].Value.ToString();
					
					
					txt_sigla.Focus();
					pnl_cliente.Visible = false;
					txt_localizaCliente.Clear();
					dgv_clientes.DataSource = string.Empty;
				}
				catch(Exception)
		  	 	{
		  	 		MessageBox.Show("Cliente não encontrado.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
		  	 		txt_localizaCliente.Focus();
		  	 		return;
		  	 	}
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_localizaCliente.Focus();
			}
		}
		
		void Txt_localizaClienteKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
		   {
				RGclientes rgcliente = new RGclientes();
			   	dgv_clientes.DataSource = rgcliente.RetornaClientes(txt_localizaCliente.Text);
				dgv_clientes.Columns[0].Visible = false;
				dgv_clientes.Columns[1].Visible = true;
				dgv_clientes.Columns[2].Visible = true;
				dgv_clientes.Columns[3].Visible = false;
				dgv_clientes.Columns[4].Visible = false;
				dgv_clientes.Columns[5].Visible = false;
				dgv_clientes.Columns[6].Visible = false;
				dgv_clientes.Columns[7].Visible = false;
				dgv_clientes.Columns[8].Visible = false;
				dgv_clientes.Columns[9].Visible = false;
				dgv_clientes.Columns[10].Visible = false;
				dgv_clientes.Columns[11].Visible = false;
				dgv_clientes.Columns[12].Visible = false;
				dgv_clientes.Columns[13].Visible = false;
				dgv_clientes.Columns[14].Visible = false;
				dgv_clientes.Columns[15].Visible = false;

				dgv_clientes.Columns[1].HeaderText = "CPF/CNPJ";
				dgv_clientes.Columns[2].HeaderText = "NOME CLIENTE";
				dgv_clientes.Columns[1].Width = 140;
		   }
			
			if(e.KeyCode.Equals(Keys.Down))
		   {
			   	dgv_clientes.Focus();
		   }
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				pnl_cliente.Visible = false;
				txt_cliente.Focus();
			}
		}
		
		
		
		void Txt_destinatarioKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				pnl_destinatario.Visible = true;
				pnl_destinatario.Width = 393;
				pnl_destinatario.Height = 322;
				pnl_destinatario.Left = 607;
				pnl_destinatario.Top = 142;
				txt_LocalizaDestinatario.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_sigla.Focus();
			}
		}
		
		
		void Txt_NNotaFiscalKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_valorNota.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_siglaD.Focus();
			}
		}
		
		void Txt_valorNotaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_qtd.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_NNotaFiscal.Focus();
			}	
		}
		
		void Txt_qtdKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_peso.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_valorNota.Focus();
			}	
		}
		
		void Txt_pesoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_valorKg.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_qtd.Focus();
			}
		}
		
		void Txt_valorKgKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_conteudo.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_peso.Focus();
			}
		}
		
		void Cb_conteudoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_conteudo.Text = cb_conteudo.Text;
				cb_conteudo.Visible = false;
				txt_embalagem.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				cb_conteudo.Visible = false;
				txt_conteudo.Focus();
			}
		}
		
		void Cb_embalagemKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_embalagem.Text = cb_embalagem.Text;
				cb_embalagem.Visible = false;
				txt_compania.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				cb_embalagem.Visible = false;
				txt_embalagem.Focus();
			}
		}
		
		void Cb_companiaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_compania.Text = cb_compania.Text;
				cb_compania.Visible = false;
				cb_modalidade.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				cb_compania.Visible = false;
				txt_compania.Focus();
			}
		}
		
		void Cb_modalidadeKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_freteRegional.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_compania.Focus();
			}
		}
		
			
		void Txt_tdaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_ttOrigem.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_freteRegional.Focus();
			}
		}
		
		
		void Txt_redispachoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_obs.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_ttDestino.Focus();
			}
		}
		
		
		void Txt_obsKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				cb_modPagamento.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_redispacho.Focus();
			}
		}
		
		void Bt_salvarKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				//executa comando para salvar;
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				cb_modPagamento.Focus();
			}
		}
		
		void lbl_maisClick(object sender, EventArgs e)
		{		
			MessageBox.Show("* CPF/CNPJ: " + cliente.CPFCNPJ + "\n* Tipo Pessoa: " + cliente.PessoaFJ +"\n* Fone3: " + cliente.Fone3 +
	                        "\n* Fone4: " + cliente.Fone4 + "\n* Site: " + cliente.Site,"Mais informações do Cliente", MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void Txt_adValorLeave(object sender, EventArgs e)
		{
			txt_adValor.ReadOnly = false;
		}
		
		void Txt_tdaLeave(object sender, EventArgs e)
		{
			//txt_tda.Text = txt_tda.Text.Replace(".",",");
			if(txt_tda.Text.Equals(string.Empty))
		    {
//				txt_tda.Text = string.Format("{0:c2}",0);
//				minuta.TDA = 0;
//				calculaTotal();
				MessageBox.Show("Digite o valor de TDA.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_tda.Focus();
		    }
			else
			{	
				bool verifica = verificaCaracterDec(txt_tda.Text);
				if(verifica.Equals(false))
				{
					MessageBox.Show("Digite um valor numérico válido.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
					txt_tda.Clear();
					txt_tda.Focus();
				}
				else
				{
					minuta.TDA = Convert.ToDecimal(txt_tda.Text);
					minuta.s_TDA = Convert.ToString(minuta.TDA).Replace(",",".");
					txt_tda.Text = minuta.TDA.ToString("c2",br);
					calculaTotal();
				}	
			}
		}
		
		
		void Txt_redispachoLeave(object sender, EventArgs e)
		{			
			//txt_redispacho.Text = txt_redispacho.Text.Replace(".",",");	
			if(txt_redispacho.Text.Equals(string.Empty))
		    {
//				txt_redispacho.Text = string.Format("{0:c2}",0);
//				minuta.TaxaRedispacho = 0;
//				calculaTotal();	
				MessageBox.Show("Digite o valor de Redispacho.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_redispacho.Focus();
		    }
			else
			{	
				bool verifica = verificaCaracterDec(txt_redispacho.Text);
				if(verifica.Equals(false))
				{
					MessageBox.Show("Digite um valor numérico válido.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
					txt_redispacho.Clear();
					txt_redispacho.Focus();
				}
				else
				{
					minuta.TaxaRedispacho = Convert.ToDecimal(txt_redispacho.Text);
					minuta.s_TaxaRedispacho = Convert.ToString(minuta.TaxaRedispacho).Replace(",",".");
					txt_redispacho.Text = minuta.TaxaRedispacho.ToString("c2",br);
					calculaTotal();	
				}
			}
		}
		
		
		void calculaTotal()
		{
		//	minuta.ADValores = Convert.ToDouble(txt_adValor.Text);
		//	minuta.TDA = Convert.ToDouble(txt_tda.Text);
		//	minuta.TaxaOrigem = Convert.ToDouble(txt_ttOrigem.Text);
		//	minuta.TaxaDestino = Convert.ToDouble(txt_ttDestino.Text);
		//	minuta.TaxaRedispacho = Convert.ToDouble(txt_redispacho.Text);
		//	minuta.FreteRegional = Convert.ToDouble(txt_freteRegional.Text);
			minuta.Total = (minuta.ADValores + minuta.TDA + minuta.TaxaOrigem + minuta.TaxaDestino + minuta.TaxaRedispacho + minuta.FreteRegional);
			minuta.s_Total = Convert.ToString(minuta.Total).Replace(",",".");
			txt_valorextenso.Text = Conversor.EscreverExtenso(minuta.Total);
			txt_total.Text = Convert.ToString(minuta.Total.ToString("c2",br));
		}
		
		
		void Txt_adValorEnter(object sender, EventArgs e)
		{
			txt_adValor.ReadOnly = true;	
		}
		
		
		void Txt_tdaEnter(object sender, EventArgs e)
		{
			if(txt_tda.Text.Equals(string.Empty))
			{
				return;
			}
			else
			{
				txt_tda.Text = Convert.ToString(minuta.TDA.ToString("n"));	
			}		
		}
		
		
		
		
		void Txt_redispachoEnter(object sender, EventArgs e)
		{
			if(txt_redispacho.Text.Equals(string.Empty))
			{
				return;
			}
			else
			{
				txt_redispacho.Text = Convert.ToString(minuta.TaxaRedispacho.ToString("n"));	
			}	
		}
		
		
		
		
		void Txt_valorNotaLeave(object sender, EventArgs e)
		{
			if(txt_valorNota.Text.Equals(string.Empty))
		    {
//				txt_valorNota.Text = string.Format("{0:c2}",0);
//				minuta.ValorNota = 0;
//			
//				minuta.ADValores = minuta.ValorNota / 150;
//				txt_adValor.Text = minuta.ADValores.ToString("c2",br);
//				calculaTotal();
				MessageBox.Show("Digite o valor da Nota.","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_valorNota.Focus();
		    }
			else
			{
				bool verifica = verificaCaracterDec(txt_valorNota.Text);
				if(verifica.Equals(false))
				{
		 			MessageBox.Show("Digite somente valores númericos válidos.","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Information);
		 			txt_valorNota.Clear();
		 			txt_valorNota.Focus();
				}
				else
				{
					minuta.s_ValorNota = txt_valorNota.Text;
					minuta.ValorNota = decimal.Parse(txt_valorNota.Text);
					txt_valorNota.Text = minuta.ValorNota.ToString("c2",br);
				
					minuta.ADValores = minuta.ValorNota / 150; // regra de negócio para calcular o valor do campo AD.Valor =(valor da nota / 150)
					minuta.s_ADValores = Convert.ToString(minuta.ADValores).Replace(",",".");
					txt_adValor.Text = minuta.ADValores.ToString("c2",br);
					calculaTotal();
				}
			}
			
		}
		
		void Txt_valorNotaEnter(object sender, EventArgs e)
		{
			if(txt_valorNota.Text.Equals(string.Empty))
			{
				return;
			}
			else
			{
				txt_valorNota.Text = Convert.ToString(minuta.ValorNota.ToString("n"));	
			}	
		}
		
		void Txt_valorKgEnter(object sender, EventArgs e)
		{
			if(txt_valorKg.Text.Equals(string.Empty))
			{
				return;
			}
			else
			{
				txt_valorKg.Text = Convert.ToString(minuta.ValorPKG.ToString("n"));	
			}	
		}
		
		
		void Txt_valorKgLeave(object sender, EventArgs e)
		{
			
			if(txt_valorKg.Text.Equals(string.Empty))
		    {
//				txt_valorKg.Text = string.Format("{0:c2}",0);
//				minuta.ValorPKG = 0;
//				calculaTotal();
				MessageBox.Show("Digite o valor por Kilo.","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_valorKg.Focus();
		    }
			else
			{	
				bool verifica = verificaCaracterDec(txt_valorKg.Text);
				if(verifica.Equals(false))
				{
					MessageBox.Show("Digite um valor numérico válido.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
					txt_valorKg.Clear();
					txt_valorKg.Focus();
				}
				else
				{
					minuta.s_ValorPKG = txt_valorKg.Text.Replace(",",".");
					minuta.ValorPKG = Convert.ToDecimal(txt_valorKg.Text);
					txt_valorKg.Text = minuta.ValorPKG.ToString("c2",br);
				
					minuta.FreteRegional = minuta.Peso * minuta.ValorPKG;
					txt_freteRegional.Text = minuta.FreteRegional.ToString("c2",br);
					//txt_freteRegional.Text = string.Format("{0:c2}",minuta.FreteRegional);
					calculaTotal();
				}
				
			}
		}
		
		
		
		void Txt_totalEnter(object sender, EventArgs e)
		{
			txt_total.ReadOnly = true;
		}
		
		void Txt_totalLeave(object sender, EventArgs e)
		{
			txt_total.ReadOnly = false;
		}
		
		void Txt_pesoLeave(object sender, EventArgs e)
		{
			
			bool verifica = verificaCaracterDec(txt_peso.Text);
			if(verifica.Equals(false))
			{
				MessageBox.Show("Digite um valor válido.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
				txt_peso.Clear();
				txt_peso.Focus();
			}
			else
			{
				txt_peso.Text = txt_peso.Text.Replace(".", ",");
				minuta.Peso = Convert.ToDecimal(txt_peso.Text);
				minuta.TaxaOrigem = rgminuta.CalculaValorPorPeso(minuta.Peso);
				minuta.TaxaDestino = minuta.TaxaOrigem;
				minuta.s_TaxaOrigem = Convert.ToString(minuta.TaxaOrigem).Replace(",",".");
				minuta.s_TaxaDestino = minuta.s_TaxaOrigem;
				txt_ttOrigem.Text = Convert.ToString(minuta.TaxaOrigem.ToString("c2",br));
				txt_ttDestino.Text = Convert.ToString(minuta.TaxaDestino.ToString("c2",br));
				calculaTotal();
			}
			
		}
		
		
		void Txt_NNotaFiscalLeave(object sender, EventArgs e)
		{
			bool verifica = verificaCaracterInt(txt_NNotaFiscal.Text);
			if(verifica.Equals(false))
			{
				MessageBox.Show("Digite somente valores numéricos validos!", "ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_NNotaFiscal.Clear();
				txt_NNotaFiscal.Focus();
			}
			else
				return;
		}
		
		bool verificaCaracterInt(string valor)
		{
			bool result;
			int numero = 0;
			result = int.TryParse(valor, out numero);
			return result;
		}
		
		bool verificaCaracterDec(string valor)
		{
			bool result;
			decimal numero = 0;
			result = decimal.TryParse(valor, out numero);
			return result;
		}
		
		void Txt_qtdLeave(object sender, EventArgs e)
		{
			bool verifica = verificaCaracterInt(txt_qtd.Text);
				if(verifica.Equals(false))
				{
		 			MessageBox.Show("Digite somente valores númericos válidos.","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Information);
		 			txt_qtd.Clear();
		 			txt_qtd.Focus();
				}
		}
		
		void FormMinutaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.F2)
			{
				tabControl1.SelectedTabIndex = 0;
			}
			
			if(e.KeyCode == Keys.F3)
			{
				tabControl1.SelectedTabIndex = 1;
			}
		}
	
		
		void Rbt_nminutaClick(object sender, EventArgs e)
		{
				lbl_1.Text = "Nº Minuta";
				lbl_1.Visible = true;
				lbl_2.Visible = false;
				txt1.Visible = true;
				txt2.Visible = false;
				dti_1.Visible = false;
				dti_2.Visible = false;
				txt1.ReadOnly = false;
				txt2.ReadOnly = false;
				dgv_remetente.Visible = false;
				txt1.Clear();
				txt1.Focus();
		}
		
		void Rbt_nNotaFiscalClick(object sender, EventArgs e)
		{
				lbl_1.Text = "Nº NotaFiscal";
				lbl_1.Visible = true;
				lbl_2.Visible = false;
				txt1.Visible = true;
				txt2.Visible = false;
				dti_1.Visible = false;
				dti_2.Visible = false;
				txt1.ReadOnly = false;
				txt2.ReadOnly = false;
				dgv_remetente.Visible = false;
				txt1.Clear();
				txt1.Focus();	
		}
		
		void Rbt_valorNotaFiscalClick(object sender, EventArgs e)
		{
				lbl_1.Text = "Valor NF";
				lbl_1.Visible = true;
				lbl_2.Visible = false;
				txt1.Visible = true;
				txt2.Visible = false;
				dti_1.Visible = false;
				dti_2.Visible = false;
				txt1.ReadOnly = false;
				txt2.ReadOnly = false;
				dgv_remetente.Visible = false;
				txt1.Clear();
				txt1.Focus();
		}
		
		void Rbt_dataClick(object sender, EventArgs e)
		{
				lbl_1.Text = "Data 1";
				lbl_1.Visible = true;
				lbl_2.Visible = true;
				txt1.Visible = true;
				txt2.Visible = true;
				dti_1.Visible = true;
				dti_2.Visible = true;
				txt1.ReadOnly = true;
				txt2.ReadOnly = true;
				dgv_remetente.Visible = false;
				txt1.Clear();
				txt2.Clear();
		}
		
		void Rbt_remetenteClick(object sender, EventArgs e)
		{
				lbl_1.Text = "Remetente";
				lbl_1.Visible = true;
				lbl_2.Visible = false;
				txt1.Visible = true;
				txt2.Visible = false;
				dti_1.Visible = false;
				dti_2.Visible = false;
				txt1.ReadOnly = false;
				txt2.ReadOnly = false;
				dgv_remetente.Visible = true;
				txt1.Clear();
				txt1.Focus();
		}
		
		void Rbt_destinatarioClick(object sender, EventArgs e)
		{
				lbl_1.Text = "Destinatário";
				lbl_1.Visible = true;
				lbl_2.Visible = false;
				txt1.Visible = true;
				txt2.Visible = false;
				dti_1.Visible = false;
				dti_2.Visible = false;
				txt1.ReadOnly = false;
				txt2.ReadOnly = false;
				dgv_remetente.Visible = true;
				txt1.Clear();
				txt1.Focus();
		}
		
		
		
		void Dti_1ValueChanged(object sender, EventArgs e)
		{
			txt1.Text = dti_1.Text;	
		}
		
		void Dti_2ValueChanged(object sender, EventArgs e)
		{
			txt2.Text = dti_2.Text;
		}
		
		
		
		void Txt_freteRegionalLeave(object sender, EventArgs e)
		{
			if(txt_freteRegional.Text.Equals(string.Empty))
		    {
				txt_freteRegional.Text = string.Format("{0:c2}",0);
				minuta.FreteRegional = 0;
				calculaTotal();
		    }
			else
			{	
				bool verifica = verificaCaracterDec(txt_freteRegional.Text);
				if(verifica.Equals(false))
				{
					MessageBox.Show("Digite um valor numérico válido.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
					txt_freteRegional.Clear();
					txt_freteRegional.Focus();
				}
				else
				{
					minuta.FreteRegional = Convert.ToDecimal(txt_freteRegional.Text);
					minuta.s_FreteRegional = Convert.ToString(minuta.FreteRegional).Replace(",","."); 
					txt_freteRegional.Text = minuta.FreteRegional.ToString("c2",br);
					calculaTotal();
				}	
			}
		}	
		
		
		void Txt_ttOrigemLeave(object sender, EventArgs e)
		{
			if(txt_ttOrigem.Text.Equals(string.Empty))
		    {
				txt_ttOrigem.Text = string.Format("{0:c2}",0);
				minuta.TaxaOrigem = 0;
				calculaTotal();
		    }
			else
			{	
				bool verifica = verificaCaracterDec(txt_ttOrigem.Text);
				if(verifica.Equals(false))
				{
					MessageBox.Show("Digite um valor numérico válido.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
					txt_ttOrigem.Clear();
					txt_ttOrigem.Focus();
				}
				else
				{
					minuta.TaxaOrigem = Convert.ToDecimal(txt_ttOrigem.Text);
					minuta.s_TaxaOrigem = Convert.ToString(minuta.TaxaOrigem).Replace(",",".");
					txt_ttOrigem.Text = minuta.TaxaOrigem.ToString("c2",br);
					calculaTotal();
				}	
			}
		}
		
		
		void Txt_ttDestinoLeave(object sender, EventArgs e)
		{
			if(txt_ttDestino.Text.Equals(string.Empty))
		    {
				txt_ttDestino.Text = string.Format("{0:c2}",0);
				minuta.TaxaDestino = 0;
				calculaTotal();
		    }
			else
			{	
				bool verifica = verificaCaracterDec(txt_ttDestino.Text);
				if(verifica.Equals(false))
				{
					MessageBox.Show("Digite um valor numérico válido.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
					txt_ttDestino.Clear();
					txt_ttDestino.Focus();
				}
				else
				{
					minuta.TaxaDestino = Convert.ToDecimal(txt_ttDestino.Text);
					minuta.s_TaxaDestino = Convert.ToString(minuta.TaxaDestino).Replace(",",".");
					txt_ttDestino.Text = minuta.TaxaDestino.ToString("c2",br);
					calculaTotal();
				}	
			}
		}
		
		
		void Txt_freteRegionalEnter(object sender, EventArgs e)
		{
			if(txt_freteRegional.Text.Equals(string.Empty))
			{
				return;
			}
			else
			{
				txt_freteRegional.Text = Convert.ToString(minuta.FreteRegional.ToString("n"));	
			}		
		}
		
		
		void Txt_ttOrigemEnter(object sender, EventArgs e)
		{
			if(txt_ttOrigem.Text.Equals(string.Empty))
			{
				return;
			}
			else
			{
				txt_ttOrigem.Text = Convert.ToString(minuta.TaxaOrigem.ToString("n"));	
			}
		}
		
		
		void Txt_ttDestinoEnter(object sender, EventArgs e)
		{
			if(txt_ttDestino.Text.Equals(string.Empty))
			{
				return;
			}
			else
			{
				txt_ttDestino.Text = Convert.ToString(minuta.TaxaDestino.ToString("n"));	
			}
		}
		
		
		
		
		void Txt_freteRegionalKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
		    {
			   	txt_tda.Focus();
		    }
			
		    if(e.KeyCode.Equals(Keys.Escape))
			{
				cb_modalidade.Focus();
			}
		}
		
		
		
		void Txt_ttOrigemKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_ttDestino.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_tda.Focus();
			}	
		}
		
		
		
		void Txt_ttDestinoKeyDown(object sender, KeyEventArgs e)
		{	
			if(e.KeyCode.Equals(Keys.Enter))
			{
				txt_redispacho.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_ttOrigem.Focus();
			}	
		}
		
		
		
		
		void Txt_LocalizaDestinatarioKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
		   {
				RGclientes rgcliente = new RGclientes();
			   	dgv_destinatario.DataSource = rgcliente.RetornaClientes(txt_LocalizaDestinatario.Text);
				dgv_destinatario.Columns[0].Visible = false;
				dgv_destinatario.Columns[1].Visible = true;
				dgv_destinatario.Columns[2].Visible = true;
				dgv_destinatario.Columns[3].Visible = false;
				dgv_destinatario.Columns[4].Visible = false;
				dgv_destinatario.Columns[5].Visible = false;
				dgv_destinatario.Columns[6].Visible = false;
				dgv_destinatario.Columns[7].Visible = false;
				dgv_destinatario.Columns[8].Visible = false;
				dgv_destinatario.Columns[9].Visible = false;
				dgv_destinatario.Columns[10].Visible = false;
				dgv_destinatario.Columns[11].Visible = false;
				dgv_destinatario.Columns[12].Visible = false;
				dgv_destinatario.Columns[13].Visible = false;
				dgv_destinatario.Columns[14].Visible = false;
				dgv_destinatario.Columns[15].Visible = false;

				dgv_destinatario.Columns[1].HeaderText = "CPF/CNPJ";
				dgv_destinatario.Columns[2].HeaderText = "NOME DESTINATARIO";
				dgv_destinatario.Columns[1].Width = 140;
		   }
			
			if(e.KeyCode.Equals(Keys.Down))
		   {
			   	dgv_destinatario.Focus();
		   }
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				pnl_destinatario.Visible = false;
				txt_destinatario.Focus();
			}	
		}
		
		void Dgv_destinatarioKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				
				try
				{	
					//     0         1      2      3           4          5       6     7   8     9      10     11     12     13    14       15   
					//idCliente, CPFCNPJ, Nome, Endereco, Complemento, Bairro, Cidade, UF, CEP, Fone1, Fone2, Fone3, Fone4, Email, Site, PessoaFJ
					destinatario.IdCliente = Convert.ToInt32(dgv_destinatario.SelectedCells[0].Value.ToString());
					destinatario.CPFCNPJ = dgv_destinatario.SelectedCells[1].Value.ToString();
					txt_destinatario.Text = dgv_destinatario.SelectedCells[2].Value.ToString();
					txt_enderecoD.Text = dgv_destinatario.SelectedCells[3].Value.ToString();
					txt_complementoD.Text = dgv_destinatario.SelectedCells[4].Value.ToString();
					txt_bairroD.Text = dgv_destinatario.SelectedCells[5].Value.ToString();
					txt_cidadeD.Text = dgv_destinatario.SelectedCells[6].Value.ToString();
					txt_ufD.Text = dgv_destinatario.SelectedCells[7].Value.ToString();
					txt_cepD.Text = dgv_destinatario.SelectedCells[8].Value.ToString();
					txt_fone1D.Text = dgv_destinatario.SelectedCells[9].Value.ToString();
					txt_fone2D.Text = dgv_destinatario.SelectedCells[10].Value.ToString();
					destinatario.Fone3 = dgv_destinatario.SelectedCells[11].Value.ToString();
					destinatario.Fone4 = dgv_destinatario.SelectedCells[12].Value.ToString();
					txt_emailD.Text = dgv_destinatario.SelectedCells[13].Value.ToString();
					destinatario.Site = dgv_destinatario.SelectedCells[14].Value.ToString();
					destinatario.PessoaFJ = dgv_destinatario.SelectedCells[15].Value.ToString();
				
					txt_siglaD.Focus();
					pnl_destinatario.Visible = false;
					txt_LocalizaDestinatario.Clear();
					dgv_destinatario.DataSource = string.Empty;
				}
				catch(Exception)
		  	 	{
		  	 		MessageBox.Show("Destinatário não encontrado.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
		  	 		txt_LocalizaDestinatario.Focus();
		  	 		return;
		  	 	}
			}
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_LocalizaDestinatario.Focus();
			}
		}
		
		
		void Lbl_maisDClick(object sender, EventArgs e)
		{
			MessageBox.Show("* CPF/CNPJ: " + destinatario.CPFCNPJ + "\n* Tipo Pessoa: " + destinatario.PessoaFJ +"\n* Fone3: " + destinatario.Fone3 +
	                        "\n* Fone4: " + destinatario.Fone4 + "\n* Site: " + destinatario.Site,"Mais informações do Destinatário", MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		
		void Cb_modPagamentoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				bt_salvar.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_obs.Focus();
			}
		}
		
		void Txt_NminutaLeave(object sender, EventArgs e)
		{
			if(txt_Nminuta.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite o número da minuta", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_Nminuta.Focus();
			}
			else
			{
				DateTime data = DateTime.Parse(DateTime.Today.ToShortDateString());
				txt_data.Text = RetornaData(data);
			   	txt_hora.Text = Convert.ToString(DateTime.Now.ToShortTimeString());
			}
		}
		
		
		void Txt_expedidorLeave(object sender, EventArgs e)
		{
			if(txt_expedidor.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite o nome do expedidor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_expedidor.Focus();
			}
		}
		
		
		
		void Bt_salvarClick(object sender, EventArgs e)
		{
			// primeiro verivica campos em branco
			if(txt_Nminuta.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite o número da minuta.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_Nminuta.Focus();
			}
			else if(txt_expedidor.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite o nome do expedidor.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_expedidor.Focus();
			}
			else if(txt_cliente.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite o nome do cliente.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_cliente.Focus();
			}
			else if(txt_destinatario.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite o nome do destinatário.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_destinatario.Focus();
			}
			else if(txt_valorNota.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite o valor da nota.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_valorNota.Focus();
			}
			else if(txt_qtd.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite a quantidade do volume.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_qtd.Focus();
			}
			else if(txt_peso.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite o peso do volume.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_peso.Focus();
			}
			else if(txt_valorKg.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite o valor por Kilo.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_valorKg.Focus();
			}
			else if(txt_conteudo.Text.Equals(string.Empty))
			{
				MessageBox.Show("Selecione o conteúdo.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cb_conteudo.Focus();
			}
			else if(txt_embalagem.Text.Equals(string.Empty))
			{
				MessageBox.Show("Selecione a embalagem.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cb_embalagem.Focus();
			}
			else if(txt_compania.Text.Equals(string.Empty))
			{
				MessageBox.Show("Selecione a compania.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cb_compania.Focus();
			}
			else if(cb_modalidade.Text.Equals(string.Empty))
			{
				MessageBox.Show("Selecione a modalidade de transporte.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cb_modalidade.Focus();
			}		
			
			else if(txt_tda.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite o valor TDA.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_tda.Focus();
			}
						
			else if(txt_redispacho.Text.Equals(string.Empty))
			{
				MessageBox.Show("Digite o valor de Redispacho.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt_redispacho.Focus();
			}	
			
			else if(cb_modPagamento.Text.Equals(string.Empty))
			{
				MessageBox.Show("Selecione a modalidade de pagamento.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cb_modPagamento.Focus();
			}	
			
			else // instancia a entidade minuta
			{				
				minuta.NMinuta = txt_Nminuta.Text;
				minuta.Data = Convert.ToDateTime(RetornaData());
				minuta.s_Data =RetornaData();
				minuta.Hora = Convert.ToDateTime(txt_hora.Text);
				minuta.s_Hora = txt_hora.Text;
				minuta.Expedidor = txt_expedidor.Text;
				minuta.IdCliente = int.Parse(rgminuta.RetornaIdCliente(txt_cliente.Text));
				minuta.Destinatario = int.Parse(rgminuta.RetornaIdCliente(txt_destinatario.Text));
				minuta.NNotaFiscal = txt_NNotaFiscal.Text;
				minuta.s_ValorNota = minuta.s_ValorNota; // valor instanciado no evento leave do referido txt
				minuta.QTD = Convert.ToInt32(txt_qtd.Text);
				minuta.s_peso = txt_peso.Text.Replace(",",".");
				minuta.s_ValorPKG = minuta.s_ValorPKG; // valor instanciado no evento leave do referido txt
				minuta.IdConteudo = int.Parse(rgminuta.RetornaIdConteudo(txt_conteudo.Text));
				minuta.IdEmbalagem = int.Parse(rgminuta.RetornaIdEmbalagem(txt_embalagem.Text));
				minuta.IdCompania = int.Parse(rgminuta.RetornaIdCompania(txt_compania.Text));
				minuta.ModTransporte = cb_modalidade.Text;
				minuta.s_ADValores = minuta.s_ADValores; // valor instanciado no evento leave do txt valorNota
				minuta.s_FreteRegional = minuta.s_FreteRegional; // valor instanciado no evento leave do txt valorPKG
				minuta.s_TDA = minuta.s_TDA; // valor instanciado no evento leave do referido txt
				minuta.s_TaxaOrigem = minuta.s_TaxaOrigem; // valor instanciado no evento leave do txt peso
				minuta.s_TaxaDestino = minuta.s_TaxaDestino; // valor instanciado no evento leave do txt peso
				minuta.s_TaxaRedispacho = minuta.s_TaxaRedispacho; // valor instanciado no evento leave do referido txt
				minuta.OBS = txt_obs.Text;
				minuta.ModPagamento = cb_modPagamento.Text;
				minuta.s_Total = minuta.s_Total; // instanciado no metodo calculoTotal
				minuta.ValorExtenso = txt_valorextenso.Text;
				
				
				if(update == 1)
				{
					rgminuta.InserirMinuta(minuta);
				}
				else if(update == 2)
				{	
					rgminuta.EditarMinuta(minuta);
				}
				
				limparCampos();
				desabilitaControles();
			}		
			
		}
		
		
		String RetornaData()// muda a data para formato MYSQL (ano-mes-dia) - usada para salvar no banco
		{
			DateTime data = Convert.ToDateTime(txt_data.Text);
			string dia = Convert.ToString(data.Day);
			string mes = Convert.ToString(data.Month.ToString());
			string ano = Convert.ToString(data.Year);
			string data2 = Convert.ToString(ano + "-" + mes + "-" + dia);
			return data2;
		}
		
		string RetornaData(DateTime data)// muda a data para formato Brasileiro (dd/mm/aaaa) - usada para exibir no txt
		{ 
			string dia = Convert.ToString(data.Day);
			string mes = Convert.ToString(data.Month);
			string ano = Convert.ToString(data.Year);
			string data2 = dia + "/" + mes + "/" + ano;
			return data2;
		}
		
		
		
		
		void Bt_adicionarClick(object sender, EventArgs e)
		{
			update = 1;
			habilitaControles();
			limparCampos();
			txt_Nminuta.Focus();
		}
		
		void Bt_editarClick(object sender, EventArgs e)
		{
			if(txt_Nminuta.Text.Equals(string.Empty))
			{
			   	MessageBox.Show("Você não pode fazer edições com o formulário em branco!","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Information);
			    return;
			}
			else
			{
				update = 2;
				habilitaControles();
			}
			
		}
		
		void Bt_deletarClick(object sender, EventArgs e)
		{
			
			if(txt_Nminuta.Text.Equals(string.Empty))
			{
			   	MessageBox.Show("Você não pode fazer exclusões com o formulário em branco!","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Information);
			    return;
			}
			else
			{
					if(MessageBox.Show("Tem certeza que deseja excluir esta Minuta?","EXCLUIR MINUTA",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
		  	 		{
		  	 			rgminuta.ExcluirMinuta(minuta.IdMinuta);
		  	 			limparCampos();
		  	 		}
		  	 		else
		  	 		{
		  	 			return;
		  	 		}	
			}
		}
		
		void habilitaControles()
		{
			gb1.Enabled = true;
			gb2.Enabled = true;
			gb3.Enabled = true;
			gb4.Enabled = true;
			gb5.Enabled = true;
			gb6.Enabled = true;
			gb7.Enabled = true;
			
			bt_adicionar.Enabled = false;
			bt_editar.Enabled = false;
			bt_imprimir.Enabled = false;
			bt_deletar.Enabled = false;
			bt_fechar.Enabled = false;
			bt_salvar.Enabled = true;
			
			
			
	
		}
		
		void desabilitaControles()
		{
			gb1.Enabled = false;
			gb2.Enabled = false;
			gb3.Enabled = false;
			gb4.Enabled = false;
			gb5.Enabled = false;
			gb6.Enabled = false;
			gb7.Enabled = false;
			
			bt_adicionar.Enabled = true;
			bt_editar.Enabled = true;
			bt_imprimir.Enabled = true;
			bt_deletar.Enabled = true;
			bt_fechar.Enabled = true;
			bt_salvar.Enabled = false;
			
		}
		
		void limparCampos()
		{
			txt_Nminuta.Clear();
			txt_data.Clear();
			txt_hora.Clear();
			txt_expedidor.Clear();
			txt_cliente.Clear();
			txt_sigla.Clear();
			txt_endereco.Clear();
			txt_complemento.Clear();
			txt_bairro.Clear();
			txt_cidade.Clear();
			txt_uf.Clear();
			txt_cep.Clear();
			txt_fone1.Clear();
			txt_fone2.Clear();
			txt_email.Clear();
			txt_destinatario.Clear();
			txt_siglaD.Clear();
			txt_enderecoD.Clear();
			txt_complementoD.Clear();
			txt_bairroD.Clear();
			txt_cidadeD.Clear();
			txt_ufD.Clear();
			txt_cepD.Clear();
			txt_fone1D.Clear();
			txt_fone2D.Clear();
			txt_emailD.Clear();
			txt_NNotaFiscal.Clear();
			txt_valorNota.Clear();
			txt_qtd.Clear();
			txt_peso.Clear();
			txt_valorKg.Clear();
			cb_conteudo.DataSource = rgminuta.LimpaCB();
			txt_conteudo.Clear();
			cb_embalagem.DataSource = rgminuta.LimpaCB();
			txt_embalagem.Clear();
			cb_compania.DataSource = rgminuta.LimpaCB();
			txt_compania.Clear();
			cb_modalidade.Text = "";
			txt_adValor.Clear();
			txt_freteRegional.Clear();
			txt_tda.Clear();
			txt_ttOrigem.Clear();
			txt_ttDestino.Clear();
			txt_redispacho.Clear();
			txt_obs.Clear();
			cb_modPagamento.Text = "";
			txt_total.Clear();
			txt_valorextenso.Clear();
			
		}
	
		
		void Bt_localizarClick(object sender, EventArgs e)
		{
			string campo;
			string filtro;
				
			if(rbt_nminuta.Checked.Equals(true))
			{
			   	campo = "NMinuta";
			   	filtro = " where " + campo + " like '%" + txt1.Text + "%' ;";
			    dgv_minuta.DataSource = rgminuta.LocalizaMinuta(filtro);
			}
			else if(rbt_nNotaFiscal.Checked.Equals(true))
			{
				campo = "NNotaFiscal";
				filtro = " where " + campo + " = " + txt1.Text + " ;";
				dgv_minuta.DataSource = rgminuta.LocalizaMinuta(filtro);
			}
			else if(rbt_valorNotaFiscal.Checked.Equals(true))
			{
				campo = "valorNota";
				filtro = " where " + campo + " = " + txt1.Text.Replace(",",".") + " ;";
				dgv_minuta.DataSource = rgminuta.LocalizaMinuta(filtro);
			}
			else if(rbt_data.Checked.Equals(true))
			{
					if(txt1.Text.Equals(string.Empty))
					{
						MessageBox.Show("Digite uma data valida para Data 1.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
						return;
					}
					else if(txt2.Text.Equals(string.Empty))
					{
						MessageBox.Show("Digite uma data valida para Data2.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
						return;
					}
					else
					{
						DateTime data = Convert.ToDateTime(txt1.Text);
						string dia = Convert.ToString(data.Day);
						string mes = Convert.ToString(data.Month);
						string ano = Convert.ToString(data.Year);
						string s_data = ano + "-" + mes + "-" + dia;
						data = Convert.ToDateTime(txt2.Text);
						dia = Convert.ToString(data.Day);
						mes = Convert.ToString(data.Month);
						ano = Convert.ToString(data.Year);
						string s_data2 = ano + "-" + mes + "-" + dia;	
						campo = "data";
						filtro = " where " + campo + " between '" + s_data + "' and '" + s_data2 + "';" ;
						dgv_minuta.DataSource = rgminuta.LocalizaMinuta(filtro);
					}	
					
			}
			else if(rbt_remetente.Checked.Equals(true))
			{
				campo = "clientes.idcliente";
				filtro = " where " + campo + " = " + minuta.IdCliente + " ;"; 
				dgv_minuta.DataSource = rgminuta.LocalizaMinuta(filtro);
			}
			else if(rbt_destinatario.Checked.Equals(true))
			{
				campo = "destinatario";
				filtro = " where " + campo + " = " + minuta.IdCliente + " ;"; 
				dgv_minuta.DataSource = rgminuta.LocalizaMinuta(filtro);
			}
			else
			{
				MessageBox.Show("Escolha uma opção valida!");
				return;
			}

//   0        1       2     3        4            5            6           7             8         9      10         11          12           13              14        
//idMinuta, NMinuta, data, hora, destinatario, NNotaFiscal, ValorNota, ModTransporte, QTDVolume, Peso, ValorPKG, ADValores, TaxaTOrigem, TaxaTDestino, FreteRegional, 

// 15       16          17          18      19            20         21          22                  23                     24                   25                 26           
//Total, Expedidor, TaxaRedispaxo, TDA, ValorExtenso, ModPagamento, OBS, clientes_idCliente, companias_idCompania, embalagens_idEmbalagem,conteudos_idConteudo, , siglaR

//   27          28        29    		30       31      32       33       34          35      36    37   38    39     40     41    42      43    44      45        46        47         48        49
// siglaD,	idEmbalagen, Descricao, idCliente, CPFCNPJ, Nome, Endereco, Complemento, Bairro, Cidade, UF, CEP, Fone1, Fone2, Fone3, Fone4, Email, Site, PessoaFJ, idCompania, Nome1, idConteudo, Descricao1


			dgv_minuta.Columns[0].Visible = false;
			dgv_minuta.Columns[1].Visible = true;
			dgv_minuta.Columns[2].Visible = true;
			dgv_minuta.Columns[3].Visible = false;
			dgv_minuta.Columns[4].Visible = false;
			dgv_minuta.Columns[5].Visible = true;
			dgv_minuta.Columns[6].Visible = true;
			dgv_minuta.Columns[7].Visible = false;
			dgv_minuta.Columns[8].Visible = false;
			dgv_minuta.Columns[9].Visible = false;
			dgv_minuta.Columns[10].Visible = false;
			dgv_minuta.Columns[11].Visible = false;
			dgv_minuta.Columns[12].Visible = false;
			dgv_minuta.Columns[13].Visible = false;
			dgv_minuta.Columns[14].Visible = false;
			dgv_minuta.Columns[15].Visible = false;
			dgv_minuta.Columns[16].Visible = false;
			dgv_minuta.Columns[17].Visible = false;
			dgv_minuta.Columns[18].Visible = false;
			dgv_minuta.Columns[19].Visible = false;
			dgv_minuta.Columns[20].Visible = false;
			dgv_minuta.Columns[21].Visible = false;
			dgv_minuta.Columns[22].Visible = false;
			dgv_minuta.Columns[23].Visible = false;
			dgv_minuta.Columns[24].Visible = false;
			dgv_minuta.Columns[25].Visible = false;
			dgv_minuta.Columns[26].Visible = false;
			dgv_minuta.Columns[27].Visible = false;
			dgv_minuta.Columns[28].Visible = false;
			dgv_minuta.Columns[29].Visible = false;
			dgv_minuta.Columns[30].Visible = false;
			dgv_minuta.Columns[31].Visible = false;
			dgv_minuta.Columns[32].Visible = true;
			dgv_minuta.Columns[33].Visible = false;
			dgv_minuta.Columns[34].Visible = false;
			dgv_minuta.Columns[35].Visible = false;
			dgv_minuta.Columns[36].Visible = false;
			dgv_minuta.Columns[37].Visible = false;
			dgv_minuta.Columns[38].Visible = false;
			dgv_minuta.Columns[39].Visible = false;
			dgv_minuta.Columns[40].Visible = false;
			dgv_minuta.Columns[41].Visible = false;
			dgv_minuta.Columns[42].Visible = false;
			dgv_minuta.Columns[43].Visible = false;
			dgv_minuta.Columns[44].Visible = false;
			dgv_minuta.Columns[45].Visible = false;
			dgv_minuta.Columns[46].Visible = false;
			dgv_minuta.Columns[47].Visible = true;
			dgv_minuta.Columns[48].Visible = false;
			dgv_minuta.Columns[49].Visible = false;
			
			dgv_minuta.Columns[1].HeaderText = "Nº MINUTA";
			dgv_minuta.Columns[2].HeaderText = "DATA";
			dgv_minuta.Columns[5].HeaderText = "Nº N.F";
			dgv_minuta.Columns[6].HeaderText = "VALOR N.F";
			dgv_minuta.Columns[32].HeaderText = "REMETENTE";
			dgv_minuta.Columns[47].HeaderText = "DESTINATARIO";		

			dgv_minuta.Columns[1].Width =   87;
			dgv_minuta.Columns[32].Width = 253;
			dgv_minuta.Columns[47].Width = 253;
			
			dgv_minuta.Columns[6].DefaultCellStyle.Format = "c2";
			
			int linha = 0;
			string destinatario;
			string idDest;
			int rows = dgv_minuta.RowCount;
			
			// laço para capturar o idDestinatario e faz um select no banco para retornar o nome do destinatario e preencher no grid.
			while(linha <= dgv_minuta.Rows.Count -1)
			{
				rows = dgv_minuta.Rows.Count;
				idDest = dgv_minuta.Rows[linha].Cells[4].Value.ToString();
				destinatario = rgminuta.RetornaNomeDestinatario(idDest);
				dgv_minuta.Rows[linha].Cells[47].Value = destinatario;
				linha += 1; 
			}	
			dgv_minuta.Focus();
		}
		
		

		
		void Txt1KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
		    {
				string nome = txt1.Text;
				if(rbt_remetente.Checked.Equals(true))
				{
					dgv_remetente.DataSource = rgminuta.RetornaNomeCliente(nome);
					dgv_remetente.Columns[0].Visible = false;
					dgv_remetente.Columns[1].Width = 290;
					dgv_remetente.Columns[1].HeaderText = "REMETENTE";
				}
				else if(rbt_destinatario.Checked.Equals(true))
				{
					dgv_remetente.DataSource = rgminuta.RetornaNomeCliente(nome);
					dgv_remetente.Columns[0].Visible = false;
					dgv_remetente.Columns[1].Width = 290;
					dgv_remetente.Columns[1].HeaderText = "DESTINATARIO";
				}
				else
				{
					return;
				}
		    }
		}
		
		void Dgv_remetenteKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				if(dgv_remetente.RowCount < 1)
				{
					MessageBox.Show("Não existe dados no gride, faça uma nova consulta!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					txt1.Text = dgv_remetente.SelectedCells[1].Value.ToString();
					minuta.IdCliente = int.Parse(dgv_remetente.SelectedCells[0].Value.ToString());
					dgv_remetente.DataSource = string.Empty;
					dgv_remetente.Visible = false;
				}
			}
			
		}
		
		
		
		void Dgv_minutaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				
				if(dgv_minuta.RowCount < 1)
				{
					MessageBox.Show("Não existe dados no gride, faça uma nova consulta!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
//   0        1       2     3        4            5            6           7             8         9      10         11          12           13              14        
//idMinuta, NMinuta, data, hora, destinatario, NNotaFiscal, ValorNota, ModTransporte, QTDVolume, Peso, ValorPKG, ADValores, TaxaTOrigem, TaxaTDestino, FreteRegional, 

// 15       16          17          18      19            20         21          22                  23                     24                   25                 26           
//Total, Expedidor, TaxaRedispaxo, TDA, ValorExtenso, ModPagamento, OBS, clientes_idCliente, companias_idCompania, embalagens_idEmbalagem,conteudos_idConteudo, , siglaR

//   27          28        29    		30       31      32       33       34          35      36    37   38    39     40     41    42      43    44      45        46        47         48        49
// siglaD,	idEmbalagen, Descricao, idCliente, CPFCNPJ, Nome, Endereco, Complemento, Bairro, Cidade, UF, CEP, Fone1, Fone2, Fone3, Fone4, Email, Site, PessoaFJ, idCompania, Nome1, idConteudo, Descricao1

					minuta.IdMinuta = int.Parse(dgv_minuta.SelectedCells[0].Value.ToString());
					minuta.s_ValorNota = dgv_minuta.SelectedCells[6].Value.ToString().Replace(",",".");
					minuta.s_ValorPKG = dgv_minuta.SelectedCells[10].Value.ToString().Replace(",",".");
					minuta.s_ADValores = dgv_minuta.SelectedCells[11].Value.ToString().Replace(",",".");
					minuta.s_FreteRegional = dgv_minuta.SelectedCells[14].Value.ToString().Replace(",",".");
					minuta.s_TDA = dgv_minuta.SelectedCells[18].Value.ToString().Replace(",",".");
					minuta.s_TaxaOrigem = dgv_minuta.SelectedCells[12].Value.ToString().Replace(",",".");
					minuta.s_TaxaDestino = dgv_minuta.SelectedCells[13].Value.ToString().Replace(",",".");
					minuta.s_TaxaRedispacho = dgv_minuta.SelectedCells[17].Value.ToString().Replace(",",".");
					minuta.s_Total = dgv_minuta.SelectedCells[15].Value.ToString().Replace(",",".");
					minuta.Peso = decimal.Parse(dgv_minuta.SelectedCells[9].Value.ToString());
					minuta.IdSigla = Convert.ToInt32( dgv_minuta.SelectedCells[26].Value.ToString());
					minuta.IdSiglaD = Convert.ToInt32(dgv_minuta.SelectedCells[27].Value.ToString());
					
					minuta.Data = Convert.ToDateTime(dgv_minuta.SelectedCells[2].Value.ToString());
					minuta.ValorNota = Convert.ToDecimal(dgv_minuta.SelectedCells[6].Value.ToString());
					minuta.ValorPKG = Convert.ToDecimal(dgv_minuta.SelectedCells[10].Value.ToString());
					minuta.ADValores = Convert.ToDecimal(dgv_minuta.SelectedCells[11].Value.ToString());
					minuta.FreteRegional = Convert.ToDecimal(dgv_minuta.SelectedCells[14].Value.ToString());
					minuta.TDA = Convert.ToDecimal(dgv_minuta.SelectedCells[18].Value.ToString());
					minuta.TaxaOrigem = Convert.ToDecimal(dgv_minuta.SelectedCells[12].Value.ToString());
					minuta.TaxaDestino = Convert.ToDecimal(dgv_minuta.SelectedCells[13].Value.ToString());
					minuta.TaxaRedispacho = Convert.ToDecimal(dgv_minuta.SelectedCells[17].Value.ToString());
					minuta.Total = Convert.ToDecimal(dgv_minuta.SelectedCells[15].Value.ToString());
	
					txt_Nminuta.Text = dgv_minuta.SelectedCells[1].Value.ToString();
					txt_data.Text = RetornaData(minuta.Data);
					txt_hora.Text = dgv_minuta.SelectedCells[3].Value.ToString();
					txt_expedidor.Text = dgv_minuta.SelectedCells[16].Value.ToString();
					txt_cliente.Text = dgv_minuta.SelectedCells[32].Value.ToString();
					txt_sigla.Text = Convert.ToString(rgminuta.RetornaNomeSigla(minuta.IdSigla));
					txt_endereco.Text = dgv_minuta.SelectedCells[33].Value.ToString();
					txt_complemento.Text = dgv_minuta.SelectedCells[34].Value.ToString();
					txt_bairro.Text = dgv_minuta.SelectedCells[35].Value.ToString();
					txt_cidade.Text = dgv_minuta.SelectedCells[36].Value.ToString();
					txt_uf.Text = dgv_minuta.SelectedCells[37].Value.ToString();
					txt_cep.Text = dgv_minuta.SelectedCells[38].Value.ToString();
					txt_fone1.Text = dgv_minuta.SelectedCells[39].Value.ToString();
					txt_fone2.Text = dgv_minuta.SelectedCells[40].Value.ToString();
					txt_email.Text = dgv_minuta.SelectedCells[41].Value.ToString();
					cliente.CPFCNPJ = dgv_minuta.SelectedCells[31].Value.ToString();
					cliente.PessoaFJ = dgv_minuta.SelectedCells[45].Value.ToString();
					cliente.Fone3 = dgv_minuta.SelectedCells[41].Value.ToString();
					cliente.Fone4 = dgv_minuta.SelectedCells[42].Value.ToString();
					cliente.Site = dgv_minuta.SelectedCells[44].Value.ToString();
					
					txt_NNotaFiscal.Text = dgv_minuta.SelectedCells[5].Value.ToString(); 
					txt_valorNota.Text = string.Format("{0:c}",dgv_minuta.SelectedCells[6].Value);
					txt_qtd.Text = dgv_minuta.SelectedCells[8].Value.ToString();
					txt_peso.Text = dgv_minuta.SelectedCells[9].Value.ToString();
					txt_valorKg.Text = string.Format("{0:c}",dgv_minuta.SelectedCells[10].Value);
					txt_conteudo.Text = rgminuta.RetornaNomeConteudo(dgv_minuta.SelectedCells[48].Value.ToString());			
					txt_embalagem.Text = rgminuta.RetornaNomeEmbalagem(dgv_minuta.SelectedCells[28].Value.ToString());
					txt_compania.Text = rgminuta.RetornaNomeCompania(dgv_minuta.SelectedCells[23].Value.ToString());
					cb_modalidade.Text = dgv_minuta.SelectedCells[7].Value.ToString();
					txt_adValor.Text = string.Format("{0:c}",dgv_minuta.SelectedCells[11].Value);
					txt_freteRegional.Text = string.Format("{0:c}",dgv_minuta.SelectedCells[14].Value);
					txt_tda.Text = string.Format("{0:c}",dgv_minuta.SelectedCells[18].Value);
					txt_ttOrigem.Text = string.Format("{0:c}",dgv_minuta.SelectedCells[12].Value);
					txt_ttDestino.Text = string.Format("{0:c}",dgv_minuta.SelectedCells[13].Value);
					txt_redispacho.Text = string.Format("{0:c}",dgv_minuta.SelectedCells[17].Value);
					txt_obs.Text = dgv_minuta.SelectedCells[21].Value.ToString();
					cb_modPagamento.Text = dgv_minuta.SelectedCells[20].Value.ToString();
					txt_total.Text = string.Format("{0:c}",dgv_minuta.SelectedCells[15].Value);
					txt_valorextenso.Text = dgv_minuta.SelectedCells[19].Value.ToString();
					
					
					// instancia as informaçoes do destinatario
					minuta.Destinatario = int.Parse(dgv_minuta.SelectedCells[4].Value.ToString());
					destinatario = rgcliente.RetornaDestinatario(minuta.Destinatario);
					txt_destinatario.Text = destinatario.Nome;
					txt_siglaD.Text = rgminuta.RetornaNomeSigla(minuta.IdSiglaD);
					txt_enderecoD.Text = destinatario.Endereco;
					txt_complementoD.Text = destinatario.Complemento;
					txt_bairroD.Text = destinatario.Bairro;
					txt_cidadeD.Text = destinatario.Cidade;
					txt_ufD.Text = destinatario.UF;
					txt_cepD.Text = destinatario.CEP;
					txt_fone1D.Text = destinatario.Fone1;
					txt_fone2D.Text = destinatario.Fone2;
					txt_emailD.Text = destinatario.Email;
					dgv_minuta.DataSource = string.Empty;
					tabControl1.SelectedTabIndex = 1;	
				}


			}
		}
		
		
		void Txt_conteudoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				RGminutas rgminuta = new RGminutas();
				cb_conteudo.DataSource = rgminuta.RetornaConteudo();
				cb_conteudo.ValueMember = "descricao";
				cb_conteudo.DisplayMember = "descricao";
				cb_conteudo.Visible = true;
				cb_conteudo.Focus();
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_valorKg.Focus();
			}
			
		}
		
		
		
		void Txt_embalagemKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				RGminutas rgminuta = new RGminutas();
				cb_embalagem.Visible = true;
				cb_embalagem.DataSource = rgminuta.RetornaEmbalagem();
				cb_embalagem.DisplayMember = "Descricao";
				cb_embalagem.ValueMember = "Descricao";
				cb_embalagem.Focus();
			}
			else if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_conteudo.Focus();
			}
		}
		
		
		
		void Txt_companiaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				RGminutas rgminuta = new RGminutas();
				cb_compania.Visible = true;
				cb_compania.DataSource = rgminuta.RetornaCompania();
				cb_compania.ValueMember = "nome";
				cb_compania.DisplayMember = "nome";
				cb_compania.Focus();
			}
			else if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_embalagem.Focus();
			}
		}
		
		
		
		
		void Txt_siglaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				pnl_siglaR.Visible = true;
				pnl_siglaR.Width = 132;
				pnl_siglaR.Height = 156;
				pnl_siglaR.Left = 360;
				txt_LocalizaSiglaR.Focus();
			}
		}
		
		void Txt_LocalizaSiglaRKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Escape))
			{
				pnl_siglaR.Visible = false;
				dgv_siglaR.DataSource = string.Empty;
				txt_LocalizaSiglaR.Clear();
				txt_sigla.Focus();
			}
			else if(e.KeyCode.Equals(Keys.Enter))
			{
				//    0          1        2     3
				// idsigla | NomeSigla| Cidade| UF
				dgv_siglaR.DataSource = rgsigla.RetornaSiglas(txt_LocalizaSiglaR.Text);
				dgv_siglaR.Columns[0].Visible = false;
				dgv_siglaR.Columns[1].Visible = true;
				dgv_siglaR.Columns[2].Visible = false;
				dgv_siglaR.Columns[3].Visible = false;
			}
			else if(e.KeyCode.Equals(Keys.Down))
			{
				dgv_siglaR.Focus();
			}
		}
		
		void Dgv_siglaRKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
					if(dgv_siglaR.RowCount < 1)
					{
						MessageBox.Show("Não existe dados no gride, faça uma nova consulta!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txt_LocalizaSiglaR.Focus();
					}
					else
					{
						minuta.IdSigla = Convert.ToInt32(dgv_siglaR.SelectedCells[0].Value.ToString());
						txt_sigla.Text = dgv_siglaR.SelectedCells[1].Value.ToString();
						dgv_siglaR.DataSource = string.Empty;
						pnl_siglaR.Visible = false;
						txt_LocalizaSiglaR.Clear();
						txt_destinatario.Focus();
					}
			}
			else if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_LocalizaSiglaR.Focus();
			}
		}
		
		void Txt_siglaDKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				pnl_siglaD.Visible = true;
				pnl_siglaD.Width = 132;
				pnl_siglaD.Height = 156;
				pnl_siglaD.Left = 858;
				txt_LocalizaSiglaD.Focus();
			}
		}
		
		void Txt_LocalizaSiglaDKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Escape))
			{
				pnl_siglaD.Visible = false;
				dgv_siglaD.DataSource = string.Empty;
				txt_LocalizaSiglaD.Clear();
				txt_siglaD.Focus();
			}
			else if(e.KeyCode.Equals(Keys.Enter))
			{
				//    0          1        2     3
				// idsigla | NomeSigla| Cidade| UF
				dgv_siglaD.DataSource = rgsigla.RetornaSiglas(txt_LocalizaSiglaD.Text);
				dgv_siglaD.Columns[0].Visible = false;
				dgv_siglaD.Columns[1].Visible = true;
				dgv_siglaD.Columns[2].Visible = false;
				dgv_siglaD.Columns[3].Visible = false;
			}
			else if(e.KeyCode.Equals(Keys.Down))
			{
				dgv_siglaD.Focus();
			}
		}
		
		
		
		
		void Dgv_siglaDKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
					if(dgv_siglaD.RowCount < 1)
					{
						MessageBox.Show("Não existe dados no gride, faça uma nova consulta!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txt_LocalizaSiglaD.Focus();
					}
					else
					{
						minuta.IdSiglaD = Convert.ToInt32(dgv_siglaD.SelectedCells[0].Value.ToString());
						txt_siglaD.Text = dgv_siglaD.SelectedCells[1].Value.ToString();
						dgv_siglaD.DataSource = string.Empty;
						pnl_siglaD.Visible = false;
						txt_LocalizaSiglaD.Clear();
						txt_NNotaFiscal.Focus();
					}
			}
			else if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_LocalizaSiglaD.Focus();
			}
		}
		
		
  }// classe
	
}// namespace


//TODO: resolver problema de conversão de data na hora de salvar, metodo RetornaData()
// TODO: adicionar o replace nos valores q estão no bt_salvar/Editar pq estão vindo com $

	
