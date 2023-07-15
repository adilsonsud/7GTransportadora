/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-02-22
 * Hora: 22:18
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using P_7Transportadora.CAD;
using System.Globalization;

namespace P_7Transportadora
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			CultureInfo usa = new CultureInfo("en-US");

			string n1 = txt_n1.Text.Replace(",",".");
			string n2 = txt_n2.Text;
			//txt_redispacho.Text = minuta.TaxaRedispacho.ToString("c2",br);
			
			//value.ToString("C3", new CultureInfo("en-US")
			decimal v1, v2 ;
			v1 = decimal.Parse(n2);
			v2 = Convert.ToDecimal(v1.ToString("c3", new CultureInfo("en-US")));
			
			
			string sql = "INSERT INTO " + BD.NomeBD + ".teste (n1, n2) values('" + n1 + "', '" + n2 + "')";
			Comandos banco = new Comandos();
			banco.ExecutaComando(sql);
			
		}
	}
}
