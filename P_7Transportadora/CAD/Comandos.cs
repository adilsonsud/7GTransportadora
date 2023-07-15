/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2016-08-25
 * Hora: 23:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using P_7Transportadora.CAD;
using P_7Transportadora.Entidades;

namespace P_7Transportadora.CAD
{
	
	public class Comandos
	{
		Conexao con;
		
		
		
		// usado para executar comandos Insert, Update e delete		
		public void ExecutaComando(string sql)
		{	
			try
			{	
				con = new Conexao();
				MySqlCommand cmd = new MySqlCommand(sql, con.Conectar());
				cmd.ExecuteNonQuery();
			}
			catch( MySqlException erro)
			{
				MessageBox.Show("Erro ao executar comando no banco de dados -> " + erro, "ERRO NO BANCO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			finally
			{
				con.Desconectar();
			}
		}
		
		public void ExecutaComando(MySqlCommand cmd)
		{
			try
			{
				cmd.Connection = con.Conectar();
				cmd.ExecuteNonQuery();
			}
			catch(MySqlException erro)
			{
				MessageBox.Show("Erro ao executar MySqlCommand no banco de dados -> " + erro, "ERRO NO BANCO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			finally
			{
				con.Desconectar();
			}
		}
		
		
		public string RetornaValorUnico(string sql)
		{
			string valor = null;
			
			try
			{
				con = new Conexao();
				MySqlCommand cmd = new MySqlCommand(sql, con.Conectar());
				valor = Convert.ToString(cmd.ExecuteScalar());
			}
			catch(MySqlException erro)
			{
				MessageBox.Show("Erro ao retornar valor unico." + erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			finally
			{
				con.Desconectar();
			}
			return valor;
		}
		
		
		
		
		public DataTable RetornaSelect (string sql)
		{
			DataTable dt = new DataTable();
			try
			{
				con = new Conexao();
				MySqlDataAdapter da = new  MySqlDataAdapter(sql,con.Conectar());
				da.Fill(dt);
			}
			catch( MySqlException erro)
			{
				MessageBox.Show("CL_Comandos -> Erro ao retornar Select" + erro,"ERRO " , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				con.Desconectar();
			}
			return dt;
		}
		
	}
}
