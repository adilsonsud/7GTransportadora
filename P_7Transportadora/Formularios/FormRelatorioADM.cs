/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 08/07/2017
 * Hora: 18:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using P_7Transportadora.RG;

namespace P_7Transportadora.Formularios
{
	/// <summary>
	/// Description of FormRelatorioADM.
	/// </summary>
	public partial class FormRelatorioADM : Form
	{
		
		RGminutas rgminutas = new RGminutas();
		RGsiglas rgsiglas = new RGsiglas();
		
		public FormRelatorioADM()
		{
			InitializeComponent();
		}
		
		void Dti_1ValueChanged(object sender, EventArgs e)
		{
			txt1.Text = dti_1.Text;	
		}
		
		void Dti_2ValueChanged(object sender, EventArgs e)
		{
			txt2.Text = dti_2.Text;	
		}
		
	
		
		void Bt_aplicarClick(object sender, EventArgs e)
		{	
			DateTime d1 = new DateTime();
			DateTime d2 = new DateTime();
			
			if(txt1.Text.Equals(string.Empty))
			{	
				
				MessageBox.Show("O campo DATA 1 está em branco. \n Escolha uma data.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			else
			{
				d1 = Convert.ToDateTime(txt1.Text);
			}
			
			if(txt2.Text.Equals(string.Empty))
			{
				
				MessageBox.Show("O campo DATA 2 está em branco. \n Escolha uma data.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			else
			{
				d2 = Convert.ToDateTime(txt2.Text);
			}
			
			if(d1 > d2)
			{
				MessageBox.Show("A Data 1 não pode ser maior que a Data 2 . \n Escolha as datas corretamente!.","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
				
				
				if(rb_financeiro.Checked == true)
				{
				   	//    0         1      2      3      4        5               6            7           8            9              10        11      12          13
					//idMinuta, NMinuta, Nome, SiglaR, Data, ModTransporte, FreteRegional, ADValores, TaxaTOrigem, TaxaTDestino, TaxaRedispacho, TDA, Destinatario, SiglaD
					dgv_relatorio.DataSource = rgminutas.RetornaRelatorioFinanceiro(s_data, s_data2, txt_sigla.Text, cb_modalidade.Text);
					dgv_relatorio.Columns[0].Visible = false;
					dgv_relatorio.Columns[1].Visible = true;
					dgv_relatorio.Columns[2].Visible = true;
					dgv_relatorio.Columns[3].Visible = true;
					dgv_relatorio.Columns[4].Visible = true;
					dgv_relatorio.Columns[5].Visible = true;
					dgv_relatorio.Columns[6].Visible = true;
					dgv_relatorio.Columns[7].Visible = true;
					dgv_relatorio.Columns[8].Visible = true;
					dgv_relatorio.Columns[9].Visible = true;
					dgv_relatorio.Columns[10].Visible = true;
					dgv_relatorio.Columns[11].Visible = true;
					dgv_relatorio.Columns[12].Visible = true;
					dgv_relatorio.Columns[13].Visible = true;
					
					dgv_relatorio.Columns[6].DefaultCellStyle.Format = "C2";
					dgv_relatorio.Columns[7].DefaultCellStyle.Format = "C2";
					dgv_relatorio.Columns[8].DefaultCellStyle.Format = "C2";
					dgv_relatorio.Columns[9].DefaultCellStyle.Format = "C2";
					dgv_relatorio.Columns[10].DefaultCellStyle.Format = "C2";
					dgv_relatorio.Columns[11].DefaultCellStyle.Format = "C2";
					
				}
				else if(rb_adm.Checked == true)
				{
					//dgv_relatorio.DataSource = rgminutas.RetornaRelatorioADM();
				}	
	 	   }
		}
		
		void Txt_siglaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				pnl_sigla.Visible = true;
				pnl_sigla.Width = 160;
				pnl_sigla.Height = 177;
//				pnl_sigla.Left = 103;
//				pnl_cliente.Top = 141;
				txt_Localizasigla.Focus();
			}
		}
		
		
		
		void Rb_admCheckedChanged(object sender, EventArgs e)
		{
			txt_sigla.Focus();
			txt_sigla.Clear();
			txt1.Clear();
			txt2.Clear();
		}
		
		void Rb_financeiroCheckedChanged(object sender, EventArgs e)
		{
			txt_sigla.Focus();
			txt_sigla.Clear();
			txt1.Clear();
			txt2.Clear();
		}
		
		void Txt_LocalizasiglaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Escape))
			{	
				txt_Localizasigla.Clear();
				pnl_sigla.Visible = false;
				txt_sigla.Focus();	
				dgv_sigla.DataSource = string.Empty;				
			}
			
			if(e.KeyCode.Equals(Keys.Enter))
			{
				//    0           1         2      3
				//idsigla  | NomeSigla  | Cidade | UF
				dgv_sigla.DataSource = rgsiglas.RetornaSiglas(txt_Localizasigla.Text);
				dgv_sigla.Columns[0].Visible = false;
				dgv_sigla.Columns[1].Visible = true;
				dgv_sigla.Columns[2].Visible = false;
				dgv_sigla.Columns[3].Visible = false;
			}
			
			if(e.KeyCode.Equals(Keys.Down))
			{
				dgv_sigla.Focus();
			}
			   
		}
		
		
		
		void Dgv_siglaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(Keys.Enter))
			{
				if(dgv_sigla.Rows.Count == 0)
				{
					MessageBox.Show("Não existe dados no gride, Certifique-se de digitar dados validos!","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
					txt_Localizasigla.Focus();
				}
				else
				{
					txt_sigla.Text = dgv_sigla.SelectedCells[1].Value.ToString();
					pnl_sigla.Visible = false;
					txt_Localizasigla.Clear();
					dgv_sigla.DataSource = string.Empty;
				}
				
			}
			
			if(e.KeyCode.Equals(Keys.Escape))
			{
				txt_Localizasigla.Focus();
			}
		}
	}
}


//TODO: Adicionar as colunas Remetente, SiglaR, Destinatario, SiglaD
//TODO: Filtrar por sigla do destinatario, modofrete,