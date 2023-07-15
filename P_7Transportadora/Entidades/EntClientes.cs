/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-05
 * Hora: 15:53
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace P_7Transportadora.Entidades
{
	
	public class EntClientes
	{
		public int IdCliente { get; set; }
		public string CPFCNPJ { get; set; }
		public string Nome { get; set; }
		public string Endereco { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string UF { get; set; }
		public string CEP { get; set; }
		public string Fone1 { get; set; }
		public string Fone2 { get; set; }
		public string Fone3 { get; set; }
		public string Fone4 { get; set; }
		public string Email { get; set; }
		public string Site { get; set; }
		public string PessoaFJ { get; set; }
	}
}
