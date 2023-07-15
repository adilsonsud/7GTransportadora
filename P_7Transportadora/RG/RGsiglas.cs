/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-02-09
 * Hora: 21:59
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data;
using System.Text;
using P_7Transportadora.CAD;
using P_7Transportadora.Entidades;

namespace P_7Transportadora.RG
{
	
	public class RGsiglas
	{
		Comandos banco = new Comandos();
		
		public void InserirSiglas(EntSiglas sigla)
		{
			StringBuilder sql = new StringBuilder();
			sql.Append("INSERT INTO " + BD.NomeBD + ".siglas (NomeSigla, Cidade, uf) values('" + sigla.NomeSigla + "','");
			sql.Append(sigla.Cidade + "', '");
			sql.Append(sigla.UF + "')");
			
			banco.ExecutaComando(sql.ToString());
		}
		
			public void EditarSiglas(EntSiglas siglas)
		{
			StringBuilder sql = new StringBuilder();
			sql.Append("Update " + BD.NomeBD + ".siglas set nomesigla = '" + siglas.NomeSigla + "',");
			sql.Append("cidade = '" + siglas.Cidade + "',");	
			sql.Append("uf = '" + siglas.UF);
			sql.Append("' where idsigla = '" + siglas.idSigla + "'");
			banco.ExecutaComando(sql.ToString());
		}
			
			
		public void ExcluirSiglas(int idsigla)
		{
			string sql = "DELETE FROM " + BD.NomeBD + ".siglas WHERE idsigla = '" + idsigla + "' ;" ;
			banco.ExecutaComando(sql);
		}
			
		
		public DataTable RetornaSiglas (string nome)
		{
			string sql = "SELECT * FROM " + BD.NomeBD + ".siglas where NomeSigla like '%" + nome + "%'";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			return dt;	
		}
	}
}
