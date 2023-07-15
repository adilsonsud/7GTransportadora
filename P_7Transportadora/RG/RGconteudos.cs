/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-17
 * Hora: 21:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data;
using P_7Transportadora.CAD;
using P_7Transportadora.Entidades;


namespace P_7Transportadora.RG
{
	
	public class RGconteudos
	{
		Comandos banco = new Comandos();
		
		public void InserirConteudo(String descricao)
		{
			string sql = "INSERT INTO " + BD.NomeBD + ".conteudos (descricao) values('" + descricao + "')";
			banco.ExecutaComando(sql);
		}
		
			public void EditarConteudo(EntConteudos conteudo)
		{
			string sql = "Update " + BD.NomeBD + ".conteudos set descricao = '" + conteudo.Descricao + "' where idConteudo = '" + conteudo.IdConteudo + "'";
			banco.ExecutaComando(sql);
		}
			
			
		public void ExcluirConteudo(int idConteudo)
		{
			string sql = "DELETE FROM " + BD.NomeBD + ".conteudos WHERE idConteudo = '" + idConteudo + "' ;" ;
			banco.ExecutaComando(sql);
		}
			
		
		public DataTable RetornaConteudos (string descricao)
		{
			string sql = "SELECT * FROM " + BD.NomeBD + ".conteudos where descricao like '%" + descricao + "%'";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			return dt;	
		}
		
	}
}
