/*
 * Criado por Adilson Freire.
 * Usuário: adilson
 * Data: 2016-08-25
 * Hora: 22:06
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace P_7Transportadora.CAD
{
	
	public class Conexao	
	{
		private MySqlConnection con = new MySqlConnection();
		
		public MySqlConnection Conectar()
		{
			try
			{						  
				con.ConnectionString = "Server=localhost;Database = " + BD.NomeBD + ";Uid=root;Pwd=root123;Connect Timeout=30"; 
			    con.Open();
			}
			catch (MySqlException erro)
			{
				MessageBox.Show("Problema ao conectar no Banco de Dados " + erro, "ERRO DE CONEXÃO", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return con;
		}
		
		public void Desconectar()
		{
			try
			{
				con.Close();
			}
			catch(MySqlException erro)
			{
				MessageBox.Show("Problema para desconectar do Banco "+ erro.Message);
			}
		}
	}
}
