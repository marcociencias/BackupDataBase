using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupDataBase
{
	public class ParametrosAppConfig
	{
		
			public Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			public string _instanciaBancoDeDados;
			public string _diretorioFile;
			public string _diretorioSpaceNet;
			public string _bancoDeDadosSac;
			public string _nomeDoBanco;

			public string InstanciaBancoDeDados
			{
		

				get { return ConfigurationManager.AppSettings["InstanciaBancoDeDados"]; }
				set { _instanciaBancoDeDados = Config.AppSettings.Settings["InstanciaBancoDeDados"].Value = value; }
			}
			public string DiretorioFile
			{
				get { return ConfigurationManager.AppSettings["DiretorioFile"]; }
				set { _diretorioFile = Config.AppSettings.Settings["DiretorioFile"].Value = value; }
			}
			public string DiretorioSpaceNet
			{
				get { return ConfigurationManager.AppSettings["DiretorioSpaceNet"]; }
				set { _diretorioSpaceNet = Config.AppSettings.Settings["DiretorioSpaceNet"].Value = value; }
			}
			public string BancoDeDadosSac
			{
				get { return ConfigurationManager.AppSettings["BancoDeDadosSac"]; }
				set { _bancoDeDadosSac = Config.AppSettings.Settings["BancoDeDadosSac"].Value = value; }
			}
			public string NomeDoBanco
			{
				get { return ConfigurationManager.AppSettings["NomeDoBanco"]; }
				set { _nomeDoBanco = Config.AppSettings.Settings["NomeDoBanco"].Value = value;}
			}

			public void SalvarParametrosAppConfig()
			{
			Config.Save(ConfigurationSaveMode.Minimal);
			}

			public void RefreshConfiguracoesAppConfig()
			{
				ConfigurationManager.RefreshSection("appSettings");
			}
		
	}
}
