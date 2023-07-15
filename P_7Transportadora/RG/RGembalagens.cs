/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-17
 * Hora: 21:28
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data;
using P_7Transportadora.CAD;
using P_7Transportadora.Entidades;


namespace P_7Transportadora.RG
{
	
	public class RGembalagens
	{
		
		Comandos banco = new Comandos();
		
		public void InserirEmbalagem(String descricao)
		{
			string sql = "INSERT INTO " + BD.NomeBD + ".embalagens (descricao) values('" + descricao + "')";
			banco.ExecutaComando(sql);
		}
		
			public void EditarEmbalagem(EntEmbalagens embalagem)
		{
			string sql = "Update " + BD.NomeBD + ".embalagens set descricao = '" + embalagem.Descricao + "' where idEmbalagen = '" + embalagem.IdEmbalagem + "'";
			banco.ExecutaComando(sql);
		}
			
			
		public void ExcluirEmbalagem(int idEmbalagem)
		{
			string sql = "DELETE FROM " + BD.NomeBD + ".embalagens WHERE idEmbalagen = '" + idEmbalagem + "' ;" ;
			banco.ExecutaComando(sql);
		}
			
		
		public DataTable RetornaEmbalagem (string descricao)
		{
			string sql = "SELECT * FROM " + BD.NomeBD + ".embalagens where Descricao like '%" + descricao + "%'";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			return dt;	
		}
		
	}
}
