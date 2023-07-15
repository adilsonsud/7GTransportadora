/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-07
 * Hora: 06:33
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Text;
using P_7Transportadora.Entidades;
using P_7Transportadora.CAD;

namespace P_7Transportadora.RG
{
	
	public class RGclientes
	{	
		Comandos banco = new Comandos();
		
		public RGclientes() // Construtor
		{
		}
		
		public void InserirCliente(EntClientes cliente)
		{
			StringBuilder stb_sql = new StringBuilder();
			stb_sql.Append("INSERT INTO " + BD.NomeBD + ".clientes (CPFCNPJ, Nome, Endereco, Complemento, Bairro, Cidade, UF, CEP, Fone1, Fone2, Fone3, Fone4, Email, Site, PessoaFJ) ");
			stb_sql.Append("values ('" + cliente.CPFCNPJ + "', '");
			stb_sql.Append(cliente.Nome + "', '");
			stb_sql.Append(cliente.Endereco + "', '");
			stb_sql.Append(cliente.Complemento + "', '");
			stb_sql.Append(cliente.Bairro + "', '");
			stb_sql.Append(cliente.Cidade + "', '");
			stb_sql.Append(cliente.UF + "', '");
			stb_sql.Append(cliente.CEP + "', '");
			stb_sql.Append(cliente.Fone1 + "', '");
			stb_sql.Append(cliente.Fone2 + "', '");
			stb_sql.Append(cliente.Fone3 + "', '");
			stb_sql.Append(cliente.Fone4 + "', '");
			stb_sql.Append(cliente.Email + "', '");
			stb_sql.Append(cliente.Site + "', '");
			stb_sql.Append(cliente.PessoaFJ + "')");
			banco.ExecutaComando(stb_sql.ToString());
		}
		
		public void EditarCliente(EntClientes cliente)
		{
			StringBuilder stb_sql = new StringBuilder();
			stb_sql.Append("Update " + BD.NomeBD + ".clientes set ");
			stb_sql.Append("cpfcnpj = '" + cliente.CPFCNPJ + "' ,");
			stb_sql.Append("nome = '" + cliente.Nome + "' ,");
			stb_sql.Append("endereco = '" + cliente.Endereco + "' ,");
			stb_sql.Append("complemento = '" + cliente.Complemento + "' ,");
			stb_sql.Append("bairro = '" + cliente.Bairro + "' ,");
			stb_sql.Append("cidade = '" + cliente.Cidade + "' ,");
			stb_sql.Append("uf = '" + cliente.UF + "' ,");
			stb_sql.Append("cep = '" + cliente.CEP + "' ,");
			stb_sql.Append("fone1 = '" + cliente.Fone1 + "' ,");
			stb_sql.Append("fone2 = '" + cliente.Fone2 + "' ,");
			stb_sql.Append("fone3 = '" + cliente.Fone3 + "' ,");
			stb_sql.Append("fone4 = '" + cliente.Fone4 + "' ,");
			stb_sql.Append("email = '" + cliente.Email + "' ,");
			stb_sql.Append("site = '" + cliente.Site + "' ,");
			stb_sql.Append("pessoafj = '" + cliente.PessoaFJ + "' ");
			stb_sql.Append("where idcliente = '" + cliente.IdCliente + "'");
			banco.ExecutaComando(stb_sql.ToString());
		}
		
		public void ExcluirCliente(int idCliente)
		{
			string sql = "DELETE FROM " + BD.NomeBD + ".clientes WHERE idCliente = '" + idCliente + "' ;" ;
			banco.ExecutaComando(sql);
		}
	
		
		public DataTable RetornaClientes (string nome)
		{
			string sql = "SELECT * FROM " + BD.NomeBD + ".clientes where nome like '%" + nome + "%'";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			if(dt.Rows.Count < 1)
			{
				sql = "SELECT * FROM " + BD.NomeBD + ".clientes where cpfcnpj like '%" + nome + "%'";
				dt = banco.RetornaSelect(sql);
			}
			return dt;	
		}
		
		
		public EntClientes RetornaDestinatario (int idCliente) // utilizado para retornar um cliente em forma de destinatario para o Form minuta
		{
			EntClientes destinatario = new EntClientes();
			string sql = "SELECT * FROM " + BD.NomeBD + ".clientes where idCliente = " + idCliente;;
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			//    0           1        2        3          4          5       6    7    8      9     10    11     12     13     14     15       16
			// idCliente | CPFCNPJ | Nome | Endereco| Complemento| Bairro| Cidade| UF| CEP| Fone1| Fone2| Fone3| Fone4| Email| Site| PessoaFJ |Sigla  
			destinatario.IdCliente = int.Parse(dt.Rows[0][0].ToString()); destinatario.CPFCNPJ = Convert.ToString(dt.Rows[0][1].ToString()); destinatario.Nome = Convert.ToString(dt.Rows[0][2].ToString());
			destinatario.Endereco = Convert.ToString(dt.Rows[0][3].ToString()); destinatario.Complemento = Convert.ToString(dt.Rows[0][4].ToString()); destinatario.Bairro = Convert.ToString(dt.Rows[0][5].ToString());
			destinatario.Cidade = Convert.ToString(dt.Rows[0][6].ToString()); destinatario.UF = Convert.ToString(dt.Rows[0][7].ToString()); destinatario.CEP = Convert.ToString(dt.Rows[0][8].ToString());
			destinatario.Fone1 = Convert.ToString(dt.Rows[0][9].ToString()); destinatario.Fone2 = Convert.ToString(dt.Rows[0][10].ToString()); destinatario.Fone3 = Convert.ToString(dt.Rows[0][11].ToString());
			destinatario.Fone4 = Convert.ToString(dt.Rows[0][12].ToString()); destinatario.Email = Convert.ToString(dt.Rows[0][13].ToString()); destinatario.Site = Convert.ToString(dt.Rows[0][14].ToString());
			destinatario.PessoaFJ = Convert.ToString(dt.Rows[0][15].ToString()); 
			return destinatario;	
		}
		
		
		public int verificaCliente(string cliente) // usadro para evitar q o cliente seja cadastrado duplicado
		{
			string sql = "select nome from " + BD.NomeBD + ".clientes where cpfcnpj = '" + cliente + "';";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			if(dt.Rows.Count < 1)
			{
				return 0; // não tem cadastro
			}
			else
			{
				string nome = Convert.ToString(dt.Rows[0][0]);
				MessageBox.Show("O cliente " + nome + " já está cadastrado com este número de CPF/CNPJ informado.", "ATENÇÃO - CPF/CNPJ DUPLICADO", MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return 1; // ja tem alguem cadastrado com o cpf/cnpj informado
			}
			
		}
		
		
	}
	
	
}
