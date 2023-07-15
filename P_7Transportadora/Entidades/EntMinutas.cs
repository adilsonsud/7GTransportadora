/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-17
 * Hora: 20:57
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using MySql.Data.Types;

namespace P_7Transportadora.Entidades
{
	public class EntMinutas
	{
		public int IdMinuta { get; set; }
		public string NMinuta { get; set; }
		public DateTime Data { get; set; }
		public DateTime Hora { get; set; }
		public int Destinatario { get; set; }
		public string NNotaFiscal { get; set; }
		public decimal ValorNota { get; set; }
		public string ModTransporte { get; set; }
		public int QTD { get; set; }
		public decimal Peso { get; set; }
		public decimal ValorPKG { get; set; }
		public decimal ADValores { get; set; }
		public decimal TaxaOrigem { get; set; }
		public decimal TaxaDestino { get; set; }
		public decimal FreteRegional { get; set; }
		public decimal Total { get; set; }
		public string Expedidor { get; set; }
		public decimal TaxaRedispacho { get; set; }
		public decimal TDA { get; set; }
		public string ValorExtenso { get; set; }
		public string ModPagamento { get; set; }
		public string OBS { get; set; }
		public int IdCliente { get; set; }
		public int IdCompania { get; set; }
		public int IdEmbalagem { get; set; }
		public int IdConteudo { get; set; }	
		public int IdSigla { get; set; }	
		public int IdSiglaD { get; set; }
		
		//strings para armazenar valores monetarios para salvar no banco.
		public string s_ValorNota { get; set; }
		public string s_ValorPKG { get; set; }
		public string s_ADValores { get; set; }
		public string s_TaxaOrigem { get; set; }
		public string s_TaxaDestino { get; set; }
		public string s_FreteRegional { get; set; }
		public string s_TaxaRedispacho { get; set; }
		public string s_TDA { get; set; }
		public string s_Total { get; set; }
		public string s_Data { get; set; }
		public string s_Hora { get; set; }
		public string s_peso { get; set; }
		
		
		
	}
}
