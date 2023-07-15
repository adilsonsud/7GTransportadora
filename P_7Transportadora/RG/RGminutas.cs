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
using System.Text;
using MySql.Data.MySqlClient;

namespace P_7Transportadora.RG
{
	
	public class RGminutas
	{
		Comandos banco = new Comandos();
		
		public DataTable RetornaConteudo()
		{
			string sql = "SELECT descricao FROM " + BD.NomeBD + ".conteudos";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			return dt;	
		}
		
		
		public string RetornaNomeConteudo(string id)
		{
			string sql = "SELECT descricao FROM " + BD.NomeBD + ".conteudos where idconteudo = " + id ;
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			string nome = Convert.ToString(dt.Rows[0][0]);
			return nome;	
		}
		
		public DataTable RetornaEmbalagem()
		{
			string sql = "SELECT descricao FROM " + BD.NomeBD + ".embalagens";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			return dt;	
		}
		
		
		public string RetornaNomeEmbalagem(string id)
		{
			string sql = "SELECT descricao FROM " + BD.NomeBD + ".embalagens where idembalagen = " + id ;
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			string nome = Convert.ToString(dt.Rows[0][0]);
			return nome;	
		}
		
		
		public DataTable RetornaCompania()
		{
			string sql = "SELECT nome FROM " + BD.NomeBD + ".companias";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			return dt;	
		}
		
		
		public string RetornaNomeCompania(string id)
		{
			string sql = "SELECT nome FROM " + BD.NomeBD + ".companias where idcompania = " + id ;
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			string nome = Convert.ToString(dt.Rows[0][0]);
			return nome;	
		}
		
		
		
		
		public decimal CalculaValorPorPeso (decimal peso)
		{
			decimal valor;
			
			if(peso <= 5)
			{
				return valor = 0;
			}
			else
			{
				decimal excedente = peso - 5;
				valor = (excedente * Convert.ToDecimal(0.5)) + 15;
				return valor;
			}	
		}
		
		public string RetornaIdCliente(string nome)
		{
			string idCliente;
			string sql = "select idCliente from " + BD.NomeBD + ".clientes where nome = '" + nome + "'";
			idCliente = banco.RetornaValorUnico(sql);
			return idCliente;
		}
		
		public string RetornaIdConteudo(string nome)
		{
			string idConteudo;
			string sql = "select idConteudo from " + BD.NomeBD + ".conteudos where descricao = '" + nome + "'";
			idConteudo = banco.RetornaValorUnico(sql);
			return idConteudo;
		}
		
		public string RetornaIdEmbalagem(string nome)
		{
			string idEmbalagem;
			string sql = "select idembalagen from " + BD.NomeBD + ".embalagens where descricao = '" + nome + "'";
			idEmbalagem = banco.RetornaValorUnico(sql);
			return idEmbalagem;
		}
		
		public string RetornaIdCompania(string nome)
		{
			string idCompania;
			string sql = "select idCompania from " + BD.NomeBD + ".companias where nome = '" + nome + "'";
			idCompania = banco.RetornaValorUnico(sql);
			return idCompania;
		}
		
		
		public string RetornaNomeSigla(int id)
		{
			string sql = "SELECT NomeSigla FROM " + BD.NomeBD + ".siglas where idsigla = " + id ;
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			string nome = Convert.ToString(dt.Rows[0][0]);
			return nome;	
		}
		
		
		public void InserirMinuta(EntMinutas minuta)
		{
//| idMinuta| NMinuta| Data| Hora| Destinatario| NNotaFiscal| ValorNota| ModTransporte| QTDVolume| Peso| ValorPKG| ADValores| TaxaTOrigem| TaxaTDestino      
//| FreteRegional| Total| Expedidor| TaxaRedispacho| TDA| ValorExtenso| ModPagamento| OBS| clientes_idCliente| companias_idCompania| embalagens_idEmbalagen| conteudos_idConteudo| SiglaR| SiglaD
			
//			StringBuilder stb_sql = new StringBuilder();
//			stb_sql.Append("INSERT INTO " + BD.NomeBD + ".minutas (nminuta, data, hora, destinatario, nnotafiscal, valornota, modtransporte, qtdvolume, peso,  ");
//			stb_sql.Append("valorpkg, advalores, taxatorigem, taxatdestino, FreteRegional, Total, Expedidor, TaxaRedispacho, TDA, ValorExtenso, ModPagamento, OBS,  ");
//			stb_sql.Append("clientes_idCliente, companias_idCompania, embalagens_idEmbalagen, conteudos_idConteudo, SiglaR, SiglaD) ");
//			stb_sql.Append("values ('" + minuta.NMinuta + "', '");
//			stb_sql.Append(minuta.s_Data + "', '");
//			stb_sql.Append(minuta.s_Hora + "', '");
//			stb_sql.Append(minuta.Destinatario + "', '");
//			stb_sql.Append(minuta.NNotaFiscal + "', '");
//			stb_sql.Append(minuta.s_ValorNota + "', '");
//			stb_sql.Append(minuta.ModTransporte + "', '");
//			stb_sql.Append(minuta.QTD + "', '");
//			stb_sql.Append(minuta.s_peso + "', '");
//			stb_sql.Append(minuta.s_ValorPKG + "', '");
//			stb_sql.Append(minuta.s_ADValores + "', '");
//			stb_sql.Append(minuta.s_TaxaOrigem + "', '");
//			stb_sql.Append(minuta.s_TaxaDestino + "', '");
//			stb_sql.Append(minuta.s_FreteRegional + "', '");
//			stb_sql.Append(minuta.s_Total + "', '");
//			stb_sql.Append(minuta.Expedidor + "', '");
//			stb_sql.Append(minuta.s_TaxaRedispacho + "', '");
//			stb_sql.Append(minuta.s_TDA + "', '");
//			stb_sql.Append(minuta.ValorExtenso + "', '");
//			stb_sql.Append(minuta.ModPagamento + "', '");
//			stb_sql.Append(minuta.OBS + "', '");
//			stb_sql.Append(minuta.IdCliente + "', '");
//			stb_sql.Append(minuta.IdCompania + "', '");
//			stb_sql.Append(minuta.IdEmbalagem + "', '");
//			stb_sql.Append(minuta.IdConteudo + "', '");
//			stb_sql.Append(minuta.IdSigla + "', '");
//			stb_sql.Append(minuta.IdSiglaD + "'); ");
//			banco.ExecutaComando(stb_sql.ToString());

			string sql = "INSERT INTO 7transportadora.minutas (NMinuta, Data, Hora, Destinatario, NNotaFiscal, ValorNota, ModTransporte, QTDVolume, Peso, ValorPKG, ADValores , TaxaTOrigem, TaxaTDestino, FreteRegional, Total, Expedidor, TaxaRedispacho, TDA, ValorExtenso, ModPagamento, OBS, clientes_idCliente, companias_idCompania, embalagens_idEmbalagen, conteudos_idConteudo, SiglaR, SiglaD) VALUES " +
			"(@NMinuta, @Data, @Hora, @Destinatario, @NNotaFiscal, @ValorNota, @ModTransporte, @QTDVolume, @Peso, @ValorPKG, @ADValores , @TaxaTOrigem, @TaxaTDestino, @FreteRegional, @Total, @Expedidor, @TaxaRedispacho, @TDA, @ValorExtenso, @ModPagamento, @OBS, @idCliente, @idCompania, @idEmbalagen, @idConteudo, @SiglaR, @SiglaD);";
			MySqlCommand cmd = new MySqlCommand(sql);
			cmd.Parameters.Add("@NMinuta",MySqlDbType.String).Value = minuta.NMinuta;
			cmd.Parameters.Add("@Data",MySqlDbType.Date).Value = minuta.Data;
			cmd.Parameters.Add("@Hora",MySqlDbType.DateTime).Value = minuta.Hora;
			cmd.Parameters.Add("@Destinatario",MySqlDbType.Int32).Value = minuta.Destinatario;
			cmd.Parameters.Add("@NNotaFiscal",MySqlDbType.String).Value = minuta.NNotaFiscal;
			cmd.Parameters.Add("@ValorNota",MySqlDbType.Decimal).Value = minuta.ValorNota;
			cmd.Parameters.Add("@ModTransporte",MySqlDbType.String).Value = minuta.ModTransporte;
			cmd.Parameters.Add("@QTDVolume",MySqlDbType.Int32).Value = minuta.QTD;
			cmd.Parameters.Add("@Peso",MySqlDbType.Decimal).Value = minuta.Peso;
			cmd.Parameters.Add("@ValorPKG",MySqlDbType.Decimal).Value = minuta.ValorPKG;
			cmd.Parameters.Add("@ADValores",MySqlDbType.Decimal).Value = minuta.ADValores;
			cmd.Parameters.Add("@TaxaTOrigem",MySqlDbType.Decimal).Value = minuta.TaxaOrigem;
			cmd.Parameters.Add("@TaxaTDestino",MySqlDbType.Decimal).Value = minuta.TaxaDestino;
			cmd.Parameters.Add("@FreteRegional",MySqlDbType.Decimal).Value = minuta.FreteRegional;
			cmd.Parameters.Add("@Total",MySqlDbType.Decimal).Value = minuta.Total;
			cmd.Parameters.Add("@Expedidor",MySqlDbType.String).Value = minuta.Expedidor;
			cmd.Parameters.Add("@TaxaRedispacho",MySqlDbType.Decimal).Value = minuta.TaxaRedispacho;
			cmd.Parameters.Add("@TDA",MySqlDbType.Decimal).Value = minuta.TDA;
			cmd.Parameters.Add("@ValorExtenso",MySqlDbType.String).Value = minuta.ValorExtenso;
			cmd.Parameters.Add("@ModPagamento",MySqlDbType.String).Value = minuta.ModPagamento;
			cmd.Parameters.Add("@OBS",MySqlDbType.String).Value = minuta.OBS;
			cmd.Parameters.Add("@idCliente",MySqlDbType.Int32).Value = minuta.IdCliente;
			cmd.Parameters.Add("@idCompania",MySqlDbType.Int32).Value = minuta.IdCompania;
			cmd.Parameters.Add("@idEmbalagen",MySqlDbType.Int32).Value = minuta.IdEmbalagem;
			cmd.Parameters.Add("@idConteudo",MySqlDbType.Int32).Value = minuta.IdConteudo;
			cmd.Parameters.Add("@SiglaR",MySqlDbType.Int32).Value = minuta.IdSigla;
			cmd.Parameters.Add("@siglaD",MySqlDbType.Int32).Value = minuta.IdSiglaD;
			banco.ExecutaComando(cmd);		
		}
		
		public void EditarMinuta(EntMinutas minuta)
		{
//	 idMinuta| NMinuta| Data| Hora| Destinatario| NNotaFiscal| ValorNota| ModTransporte| QTDVolume| Peso| ValorPKG| ADValores| TaxaTOrigem| TaxaTDestino      
//   FreteRegional| Total| Expedidor| TaxaRedispacho| TDA| ValorExtenso| ModPagamento| OBS| clientes_idCliente| companias_idCompania| embalagens_idEmbalagen| conteudos_idConteudo| SiglaR| SiglaD

//			StringBuilder stb_sql = new StringBuilder();
//			stb_sql.Append("update " + BD.NomeBD + ".minutas set ");
//			stb_sql.Append("NMinuta = '" + minuta.NMinuta + "', ");
//			stb_sql.Append("Data = '" + minuta.s_Data + "', ");
//			stb_sql.Append("hora ='" + minuta.s_Hora + "', ");
//			stb_sql.Append("destinatario = '" + minuta.Destinatario + "', ");
//			stb_sql.Append("NNotafiscal = '" + minuta.NNotaFiscal + "', ");
//			stb_sql.Append("valorNota = '" + minuta.s_ValorNota + "', ");
//			stb_sql.Append("ModTransporte = '" + minuta.ModTransporte + "', ");
//			stb_sql.Append("QTDVolume = '" + minuta.QTD + "', ");
//			stb_sql.Append("peso = '" + minuta.s_peso + "', ");
//			stb_sql.Append("ValorPKG = '" + minuta.s_ValorPKG + "', ");
//			stb_sql.Append("ADValores = '" + minuta.s_ADValores + "', ");
//			stb_sql.Append("TaxaTOrigem = '" + minuta.s_TaxaOrigem + "', ");
//			stb_sql.Append("TaxaTDestino = '" + minuta.s_TaxaDestino + "', ");
//			stb_sql.Append("FreteRegional = '" + minuta.s_FreteRegional + "', ");
//			stb_sql.Append("Total = '" + minuta.s_Total + "', ");
//			stb_sql.Append("Expedidor = '" + minuta.Expedidor + "', ");
//			stb_sql.Append("TaxaRedispacho = '" + minuta.s_TaxaRedispacho + "', ");
//			stb_sql.Append("TDA = '" + minuta.s_TDA + "', ");
//			stb_sql.Append("ValorExtenso = '" + minuta.ValorExtenso + "', ");
//			stb_sql.Append("ModPagamento = '" + minuta.ModPagamento + "', ");
//			stb_sql.Append("obs = '" + minuta.OBS + "', ");
//			stb_sql.Append("clientes_idcliente = '" + minuta.IdCliente + "', ");
//			stb_sql.Append("companias_idCompania = '" + minuta.IdCompania + "', ");
//			stb_sql.Append("embalagens_idEmbalagen = '" + minuta.IdEmbalagem + "', ");
//			stb_sql.Append("conteudos_idConteudo = '" + minuta.IdConteudo + "', ");
//			stb_sql.Append("SiglaR = '" + minuta.IdSigla + "', ");
//			stb_sql.Append("SiglaD = '" + minuta.IdSiglaD + "' ");
//			stb_sql.Append("where idMinuta = '" + minuta.IdMinuta + "' ;");
//			banco.ExecutaComando(stb_sql.ToString());
			
			
//			sql = "update 7gfrota.clientes Set P_FisicaJuridica = @P_FisicaJuridica, CPF_CNPJ = @CPF_CNPJ, InscricaoEstadual = @InscricaoEstadual," & _
//				"			NomeFantasia = @NomeFantasia, RazaoSocial = @RazaoSocial, NomeCliente = @NomeCliente, DatNascimento = @DatNascimento," & _
//				"			Endereco = @Endereco, Complemento = @Complemento, Bairro = @Bairro, Cep = @Cep, Cidade = @Cidade, Estado = @Estado, " & _
//				"			Fone1 = @Fone1, Fone2 = @Fone2, Fone3 = @Fone3, Fone4 = @Fone4, Email1 = @Email1, Email2 = @Email2" & _
//				"			where idcliente = @idcliente"	
//			
//			cmd = New MySqlCommand(sql, conexao.conectar)	
//			cmd.Parameters.Add("@P_FisicaJuridica",MySqlDbType.String).Value = cliente.P_FisicaJuridica
//			cmd.Parameters.Add("@CPF_CNPJ", MySqlDbType.String).Value = cliente.CPF_CNPJ
//			cmd.Parameters.Add("@InscricaoEstadual",MySqlDbType.String).Value = cliente.InscricaoEstadual
//			cmd.Parameters.Add("@NomeFantasia",MySqlDbType.String).Value = cliente.NomeFantasia
			
			//idMinutas, NMinuta, Data, Hora, Destinatario, NNotaFiscal, ValorNota, ModTransporte, QTDVolume, Peso, ValorPKG, ADValores, TaxaTOrigem, TaxaTDestino,
			//FreteRegional, Total, Expedidor, TaxaRedispacho, TDA, ValorExtenso, ModPagamento, OBS, idCliente, idCompania, idEmbalagen, idConteudo, siglaR, siglaD
			
//| idMinuta| NMinuta| Data| Hora| Destinatario| NNotaFiscal| ValorNota| ModTransporte| QTDVolume| Peso| ValorPKG| ADValores| TaxaTOrigem| TaxaTDestino      
//| FreteRegional| Total| Expedidor| TaxaRedispacho| TDA| ValorExtenso| ModPagamento| OBS| clientes_idCliente| companias_idCompania| embalagens_idEmbalagen| conteudos_idConteudo| SiglaR| SiglaD
		
string sql = "UPDATE 7transportadora.minutas SET NMinuta= @NMinuta, Data= @Data, Hora = @Hora, Destinatario=@Destinatario, NNotaFiscal=@NNotaFiscal,ValorNota=@ValorNota, ModTransporte=@ModTransporte, QTDVolume=@QTDVolume, Peso=@Peso, ValorPKG=@ValorPKG, ADValores=@ADValores, TaxaTOrigem=@TaxaTOrigem, TaxaTDestino=@TaxaTDestino,FreteRegional=@FreteRegional, Total=@Total, Expedidor=@Expedidor, TaxaRedispacho=@TaxaRedispacho, TDA=@TDA, ValorExtenso=@ValorExtenso, ModPagamento=@ModPagamento,OBS=@OBS, clientes_idCliente=@idCliente, companias_idCompania=@idCompania, embalagens_idEmbalagen=@idEmbalagen, conteudos_idConteudo=@idConteudo,SiglaR=@SiglaR, SiglaD=@SiglaD WHERE idMinuta=@idMinuta;";
			MySqlCommand cmd = new MySqlCommand(sql);
			cmd.Parameters.Add("@NMinuta",MySqlDbType.String).Value = minuta.NMinuta;
			cmd.Parameters.Add("@Data",MySqlDbType.Date).Value = minuta.Data;
			cmd.Parameters.Add("@Hora",MySqlDbType.DateTime).Value = minuta.Hora;
			cmd.Parameters.Add("@Destinatario",MySqlDbType.Int32).Value = minuta.Destinatario;
			cmd.Parameters.Add("@NNotaFiscal",MySqlDbType.String).Value = minuta.NNotaFiscal;
			cmd.Parameters.Add("@ValorNota",MySqlDbType.Decimal).Value = minuta.ValorNota;
			cmd.Parameters.Add("@ModTransporte",MySqlDbType.String).Value = minuta.ModTransporte;
			cmd.Parameters.Add("@QTDVolume",MySqlDbType.Int32).Value = minuta.QTD;
			cmd.Parameters.Add("@Peso",MySqlDbType.Decimal).Value = minuta.Peso;
			cmd.Parameters.Add("@ValorPKG",MySqlDbType.Decimal).Value = minuta.ValorPKG;
			cmd.Parameters.Add("@ADValores",MySqlDbType.Decimal).Value = minuta.ADValores;
			cmd.Parameters.Add("@TaxaTOrigem",MySqlDbType.Decimal).Value = minuta.TaxaOrigem;
			cmd.Parameters.Add("@TaxaTDestino",MySqlDbType.Decimal).Value = minuta.TaxaDestino;
			cmd.Parameters.Add("@FreteRegional",MySqlDbType.Decimal).Value = minuta.FreteRegional;
			cmd.Parameters.Add("@Total",MySqlDbType.Decimal).Value = minuta.Total;
			cmd.Parameters.Add("@Expedidor",MySqlDbType.String).Value = minuta.Expedidor;
			cmd.Parameters.Add("@TaxaRedispacho",MySqlDbType.Decimal).Value = minuta.TaxaRedispacho;
			cmd.Parameters.Add("@TDA",MySqlDbType.Decimal).Value = minuta.TDA;
			cmd.Parameters.Add("@ValorExtenso",MySqlDbType.String).Value = minuta.ValorExtenso;
			cmd.Parameters.Add("@ModPagamento",MySqlDbType.String).Value = minuta.ModPagamento;
			cmd.Parameters.Add("@OBS",MySqlDbType.String).Value = minuta.OBS;
			cmd.Parameters.Add("@idCliente",MySqlDbType.Int32).Value = minuta.IdCliente;
			cmd.Parameters.Add("@idCompania",MySqlDbType.Int32).Value = minuta.IdCompania;
			cmd.Parameters.Add("@idEmbalagen",MySqlDbType.Int32).Value = minuta.IdEmbalagem;
			cmd.Parameters.Add("@idConteudo",MySqlDbType.Int32).Value = minuta.IdConteudo;
			cmd.Parameters.Add("@SiglaR",MySqlDbType.Int32).Value = minuta.IdSigla;
			cmd.Parameters.Add("@siglaD",MySqlDbType.Int32).Value = minuta.IdSiglaD;
			cmd.Parameters.Add("@idMinuta",MySqlDbType.Int32).Value = minuta.IdMinuta;
			banco.ExecutaComando(cmd);
		}
		
		
		public void ExcluirMinuta(int idMinuta)
		{
			string sql = "DELETE FROM " + BD.NomeBD + ".minutas WHERE idMinuta = '" + idMinuta + "' ;" ;
			banco.ExecutaComando(sql);
		}
		
		
		
		public DataTable LimpaCB()
		{
			//string sql = "SELECT descricao FROM " + BD.NomeBD + ".conteudos";
			DataTable dt = new DataTable();
			//dt = banco.RetornaSelect(sql);
			return dt;	
		}
		
		public DataTable LocalizaMinuta(string filtro)
		{
			StringBuilder  sql = new StringBuilder();
			sql.Append("select *  from (((" + BD.NomeBD + ".minutas minutas inner join " + BD.NomeBD + ".embalagens embalagens  ON (minutas.embalagens_idEmbalagen =  embalagens.idEmbalagen))");
			sql.Append("inner join " + BD.NomeBD + ".clientes clientes  ON (minutas.clientes_idCliente = clientes.idCliente))  INNER JOIN " + BD.NomeBD + ".companias companias ");
			sql.Append("ON (minutas.companias_idCompania = companias.idCompania)) INNER JOIN " + BD.NomeBD + ".conteudos conteudos ON (minutas.conteudos_idConteudo = conteudos.idConteudo)" + filtro);
    		DataTable dt = banco.RetornaSelect(sql.ToString());
			return dt;
		}
		
		public string RetornaNomeDestinatario(string id) // usadro para preencher no grid o nome do destinatario
		{
			string sql = "select nome from " + BD.NomeBD + ".clientes where idcliente = '" + id + "';";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			string nome = Convert.ToString(dt.Rows[0][0]);
			return nome;
		}
		
		public DataTable RetornaNomeCliente (string nome)
		{
			string sql = "SELECT idcliente, nome FROM " + BD.NomeBD + ".clientes where nome like '%" + nome + "%'";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			if(dt.Rows.Count < 1)
			{
				sql = "SELECT idcliente, nome FROM " + BD.NomeBD + ".clientes where cpfcnpj like '%" + nome + "%'";
				dt = banco.RetornaSelect(sql);
			}
			return dt;	
		}
		
		
	//	idMinuta,NMinuta,Data, Hora ,Destinatario ,NNotaFiscal ,ValorNota , ModTransporte , QTDVolume, Peso , ValorPKG , ADValores ,TaxaTOrigem ,TaxaTDestino , FreteRegional 
	// Total ,Expedidor ,TaxaRedispacho , TDA ,ValorExtenso, ModPagamento, OBS  ,clientes_idCliente ,companias_idCompania , embalagens_idEmbalagen , conteudos_idConteudo
		public DataTable RetornaRelatorioFinanceiro(string data1, string data2, string siglaD, string modTransporte)
		{
			
			string sql = "SELECT minutas.idMinuta, minutas.NMinuta, clientes.Nome, minutas.SiglaR, minutas.Data, minutas.ModTransporte, minutas.FreteRegional, minutas.ADValores, minutas.TaxaTOrigem, minutas.TaxaTDestino,  minutas.TaxaRedispacho, minutas.TDA,  minutas.Destinatario, minutas.SiglaD" +
 			" FROM    7transportadora.minutas minutas INNER JOIN " + BD.NomeBD + ".clientes clientes ON (minutas.clientes_idCliente = clientes.idCliente) where minutas.data beteween " + data1 + " and " + data2 + " and minutas.siglad = " + siglaD + " and minutas.ModTransporte = " + modTransporte; 
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			return dt;	
		}
		
		public DataTable RetornaRelatorioADM(string data1, string data2, string sigla)
		{
			string sql = "SELECT Data,  FROM " + BD.NomeBD + ".companias";
			DataTable dt = new DataTable();
			dt = banco.RetornaSelect(sql);
			return dt;	
		}
		
	 
		
	}
}
