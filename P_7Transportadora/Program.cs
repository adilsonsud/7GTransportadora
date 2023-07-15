/*Inicio do Projeto 04/01/2017
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-04
 * Hora: 19:59
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Windows.Forms;

namespace P_7Transportadora
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Formularios.FormMenu());
		}
		
	}
}
