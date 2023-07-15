/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-17
 * Hora: 21:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using P_7Transportadora.Entidades;
using P_7Transportadora.CAD;
using System.Data;

namespace P_7Transportadora.RG
{
	
	public class RGcompanias
	{
		Comandos banco = new Comandos();
		
		public void InserirCompania(String nome)
		{
			string sql = "INSERT INTO " + BD.NomeBD + ".companias (Nome) values('" + nome + "')";
			banco.ExecutaComando(sql);
		}
		
			public void EditarCompania(EntCompanias compania)
		{
			string sql = "Update " + BD.NomeBD + ".companias set nome = '" + compania.Nome + "' where idCompania = '" + compania.IdCompanias + "'";
			banco.ExecutaComando(sql);
		}
			
			
		public void ExcluirCompania(int idCompania)
		{
			string sql = "DELETE FROM " + BD.NomeBD + ".companias WHERE idCompania = '" + idCompania + "' ;" ;
			banco.ExecutaComando(sql);
		}
			
		
		public DataTable RetornaCompanias (string nome)
		{
			string sql = "SELECT * FROM " + BD.NomeBD + ".companias where nome like '%" + nome + "%'";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			return dt;	
		}
		
	}
}
