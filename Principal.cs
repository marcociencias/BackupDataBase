using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupDataBase
{
	public partial class Principal : Form
	{
		public Principal()
		{
			InitializeComponent();
			AtualizarComboBoxBancoDeDados();
			Inicializacao();
			SelecionarBaseDeDados();
		}

		ParametrosSpacenetConfig diretorioSpacenet = new ParametrosSpacenetConfig();
		ParametrosDiretorio diretorio = new ParametrosDiretorio();
		ParametrosAppConfig value = new ParametrosAppConfig();
		Configuracao configuracao = new Configuracao();
		ParametrosRegedit regedit = new ParametrosRegedit();
		System.Diagnostics.Process pProcess = new System.Diagnostics.Process();


		public void Inicializacao()
		{
			if(diretorio.DiretorioComunicador(value.DiretorioSpaceNet))
			{
				btnAbrirSpacenetIt.Enabled = false;
				return;
			}
			//if (regedit.LerRegistro() == false)
			//{
			//	btnAbrirSpacenetIt.Enabled = false;
			//	MessageBox.Show("Licença do aplicativo não foi encontrada");
			//}
		}

		public void AtualizarComboBoxBancoDeDados()
		{
			comboBox1.Text = value.NomeDoBanco;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (diretorio.DiretorioSpacenetIt(value.DiretorioSpaceNet))
			{
				diretorioSpacenet.SpacenetConfig(value.DiretorioSpaceNet,comboBox1.Text, value.InstanciaBancoDeDados , value.BancoDeDadosSac);
				Thread.Sleep(1500);
				pProcess.StartInfo.FileName = ($@"{value.DiretorioSpaceNet}\\spacenetIt.exe");
				pProcess.Start();
			}
		}

		private void SelecionarBaseDeDados()
		{
			if (diretorio.DiretorioDataBase(value.DiretorioFile))
			{
				DirectoryInfo diretorioDB = new DirectoryInfo(value.DiretorioFile);
				FileInfo[] Arquivos = diretorioDB.GetFiles();
				string valor;
				foreach (FileInfo arquivo in Arquivos)
				{
					valor = arquivo.Name;
					if (valor.EndsWith("mdf") && valor.StartsWith("Spacen"))
					{
						comboBox1.Items.Add(valor.Substring(0, valor.Length - 4));
					}
				}
			}
			else
			{
				value.RefreshConfiguracoesAppConfig();
				diretorio.DiretorioDataBase(value.DiretorioFile);
			}
		}


		private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			configuracao.Visible = true;
		}

		private void AtualizarUltimoBancoAcessado()
		{
			value.NomeDoBanco = comboBox1.Text;
			value.SalvarParametrosAppConfig();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Deseja realmente sair ?", "NEPOS BACKUP - SAIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
			{
				value.NomeDoBanco = comboBox1.Text;
				value.SalvarParametrosAppConfig();
				this.Close();
				Environment.Exit(0);
			}
		}

	}
}
