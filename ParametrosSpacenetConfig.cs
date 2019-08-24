using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupDataBase
{
	public class ParametrosSpacenetConfig
	{
		public void SpacenetConfig(string diretorioSpacenet, string nomeBancoDeDados , string instanciaDoBancoDeDados , string nomeBancoDeDadosSac)
		{
			StreamWriter testes;
			string caminhoNome = diretorioSpacenet + "\\SpacenetConfig.txt";
			testes = File.CreateText(caminhoNome);
			testes.WriteLine("| Parametros de Acesso ao Banco de Dados |");
			testes.WriteLine("StrDataBase =" + nomeBancoDeDados);
			testes.WriteLine("StrDBServer =" + instanciaDoBancoDeDados);
			testes.WriteLine("StrSACDataBase =" + nomeBancoDeDadosSac);
			testes.WriteLine("StrSACServer =" + instanciaDoBancoDeDados);
			testes.WriteLine("\n");
			testes.Close();
		
			StreamWriter parametros = new StreamWriter(diretorioSpacenet+"\\SpacenetConfig.txt", true);
			parametros.WriteLine("[Modes] ");
			parametros.WriteLine("TimeDB = 1000 ");
			parametros.WriteLine("SIAC = 0"); 
			parametros.WriteLine("OptNormBtnShow = 1");
			parametros.WriteLine("PDVMifare = 1");
			parametros.WriteLine("ServerFeature = 1");
			parametros.WriteLine("ServerPort =63767");
			parametros.WriteLine("TimeAdjustSynchroTime = 06:00");
			parametros.WriteLine("TimeAdjustSynchroTime = 12:00");
			parametros.WriteLine("TimeAdjustSynchroTime = 18:00");
			parametros.WriteLine("TimeAdjustSynchroTime = 23:00");
			parametros.WriteLine("BlackListSynchroTime = 04:00");
			parametros.WriteLine("xDPlusIP = 192.168.0.51" );
			parametros.WriteLine("xDPlusPort = 2563" );
			parametros.WriteLine("DPlusTimeOutMSecs = 1500");
			parametros.WriteLine("DPlusInReader = 11" );
			parametros.WriteLine("DPlusPayReader = 12" );
			parametros.WriteLine("DPlusExitReader = 12" );
			parametros.WriteLine("DPlusXvpcReader = 12" );
			parametros.WriteLine("DPlusInNeededArea = 0" );
			parametros.WriteLine("DPlusPayNeededArea = 1" );
			parametros.WriteLine("DPlusExitNeededArea = 1" );
			parametros.WriteLine("DPlusXvpcNeededArea = 1" );
			parametros.WriteLine("DPlusInValMinutes = -1" );
			parametros.WriteLine("DPlusPayValMinutes = 20" );
			parametros.WriteLine("DPlusExitValMinutes = 15" );
			parametros.WriteLine("EnDateTimeShow = 1" );
			parametros.WriteLine("EnBListFromCtrl = 1" );
			parametros.WriteLine("DPlusDoAllwaysGetDbLastSeq = 1");

			parametros.WriteLine("AutoConnect = 1");
			parametros.WriteLine("EstaparEmpresa = 0");
			parametros.WriteLine("EstaparFilial = 0");
			parametros.WriteLine("");
			parametros.WriteLine("| Utilizado para esconder o progresso do comunicador automaticamente|");
			parametros.WriteLine("showMemo = 1");
			parametros.WriteLine("");
			parametros.WriteLine("| Utilizado para habilitar ou desabilitar o SAC nos aplicativos Spacenet|");
			parametros.WriteLine("DisableLogin = 1");
			parametros.WriteLine("");
			parametros.WriteLine("| Utilizado apra desabilitar o SAC no Comunicador|");
			parametros.WriteLine("DisableLoginComm = 1");
			parametros.WriteLine("");
			parametros.WriteLine("[DBTRANS_N2]");
			parametros.WriteLine("Est_id = 1");
			parametros.WriteLine("Ecr_id = 20");
			parametros.WriteLine("DBTransPath = \\192.168.0.222\\publica ");
			parametros.WriteLine("SeqDbt = 78");
			parametros.WriteLine("DBTransInterval = 300 ");
			parametros.WriteLine("DBTransPort = 12350");
			parametros.WriteLine("DBTransIp = 192.168.0.234");

			parametros.WriteLine("[CONTROLE]");

			parametros.WriteLine("| Utilizado como botão de pânico para envio de comando para múltiplas cancelas |");
			parametros.WriteLine("| 0  Não habilitado                                                                       | ");
			parametros.WriteLine("| 1  Comando enviado para entradas, passagens e saídas                                    | ");
			parametros.WriteLine("| 2  Comando enviado para todas as entradas |												");
			parametros.WriteLine("| 3  Comando enviado para todas as passagens e saídas                                     | ");
			parametros.WriteLine("| 4  Comando enviado para entradas, passagens, saídas, caixas de entrada, caixas de saída | ");
			parametros.WriteLine("| 5  Comando enviado para passagens, saídas, caixas de saída                              | ");
			parametros.WriteLine("| 6  Comando enviado para entradas, caixas de entrada                                     | ");
			parametros.WriteLine("MultipleBarriers = 4");

			parametros.WriteLine("| IRREGULARIDADES: Ao alterar cartões atualizar versão para esta | ");
			parametros.WriteLine(" CardVersionChange = 1");

			parametros.WriteLine("| Controle - controle de vagas tela completa|");
			parametros.WriteLine("| 0 = não aparece coluna do DBTrans |");
			parametros.WriteLine("| 1 = aparece coluna do DBTrans |");
			parametros.WriteLine("ControleVagasUtilizaDBTrans = 0 ");

			parametros.WriteLine("| Controle - controle de vagas tela completa |");
			parametros.WriteLine("| 0 = não aparece coluna do ViaFacil |");
			parametros.WriteLine("| 1 = aparece coluna do ViaFacil | ");
			parametros.WriteLine(" ControleVagasUtilizaViaFacil = 0 ");
			parametros.WriteLine("");
			parametros.WriteLine("| Qual tela mostrar |");
			parametros.WriteLine("| 0 = Tela completa | ");
			parametros.WriteLine("| 1 = Tela simplificada | ");
			parametros.WriteLine("ControleTelaControleVagas = 0 ");

			parametros.WriteLine("|| TELA CONTROLE DE VAGAS - SIMPLIFICADA ||");
			parametros.WriteLine("");
			parametros.WriteLine("| Mostra ou não valores de pagamento |");
			parametros.WriteLine("| 0 = Não mostra | ");
			parametros.WriteLine("| 1 = Mostra |");
			parametros.WriteLine("ControleMostraValoresPagamento = 0 ");
			parametros.WriteLine("");
			parametros.WriteLine("[CONTROLE E COMUNICADOR - Controle de vagas] ");
			parametros.WriteLine("| Pelo Comunicador: Horário para zerar vagas          | ");
			parametros.WriteLine("| Pelo Controle: Horário para selecionar dados       | ");
			parametros.WriteLine("| Horario para escolher um horário específico | ");
			parametros.WriteLine("| DB ou sem este registro para o Day Change do banco |");
			parametros.WriteLine("HorarioZeraControleVagas = DB ");
			parametros.WriteLine("");
			parametros.WriteLine("[CONFIGURADOR]");
			parametros.WriteLine("");
			parametros.WriteLine("|| CRIAÇÃO DE CARTOES MENSALISTAS ||");
			parametros.WriteLine("");
			parametros.WriteLine("");
			parametros.WriteLine("|| NUMERO DO LOTE(DECIMAL)| ");
			parametros.WriteLine("						  LotNumber = 2456 ");
			parametros.WriteLine(""); 
			parametros.WriteLine("| NUMERO DO SUBLOTE| ");
			parametros.WriteLine("SubLotNumber = 00 ");
			parametros.WriteLine("");
			parametros.WriteLine("| NUMERO DE INICIO DO TIPO MENSALISTAS | ");
			parametros.WriteLine("NumberTypeStart = 6");
			parametros.WriteLine("");
			parametros.WriteLine("| NUMERO DE FIM DO TIPO MENSALISTAS | ");
			parametros.WriteLine("NumberTypeEnd = 8");
			parametros.WriteLine("");
			parametros.WriteLine("| MODO | ");
			parametros.WriteLine("Mode = e");
			parametros.WriteLine("");
			parametros.WriteLine("| VERSAO | ");
			parametros.WriteLine("CardVersionCreate = 3 ");
			parametros.WriteLine("");
			parametros.WriteLine("| CARTOES EXTRA EM MENSALISTAS | ");
			parametros.WriteLine("| 0 = Desabilitado | ");
			parametros.WriteLine("| 1 = Habilitado | ");
			parametros.WriteLine("EnableExtraCards = 0 ");
			parametros.WriteLine("");
			parametros.WriteLine("| LEITOR DE PROXIMIDADE| ");
			parametros.WriteLine("| 0 = NENHUM | ");
			parametros.WriteLine("| 1 = ACURA |");
			parametros.WriteLine("| 2 = HID |");
			parametros.WriteLine("EnableProximity = 0");
			parametros.WriteLine("");
			parametros.WriteLine("| PORTA COMM SERIAL PROXIMITY | ");
			parametros.WriteLine("SerialCommPortProximity = 1 ");
			parametros.WriteLine("");
			parametros.WriteLine("||CRIAÇÃO DE CARTÕES MENSALISTA DBTRANS ||");
			parametros.WriteLine("");
			parametros.WriteLine("| Porta servidor DBTrans| ");
			parametros.WriteLine("DBTransPort = 12350");
			parametros.WriteLine("");
			parametros.WriteLine("| Ip servidor DBTrans|");
			parametros.WriteLine("DBTransIp = 192.168.1.150");
			parametros.WriteLine("");
			parametros.WriteLine("| Exibe Campos DBTrans nas abas Mensalistas e Atualiza BC|");
			parametros.WriteLine("hasDbtrans = 0 ");
			parametros.WriteLine("");
			parametros.WriteLine("| PERMITE DELETAR CARTÕES DBTrans pela Aba Mensalistas|");
			parametros.WriteLine("EnableDeleteDbtCardConfig = 0");
			parametros.Close();

		}
	}
}
