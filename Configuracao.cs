using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace BackupDataBase
{
	public partial class Configuracao : Form
	{
		ParametrosAppConfig value = new ParametrosAppConfig();
		ParametrosDiretorio diretorio = new ParametrosDiretorio();
		ParametrosSpacenetConfig parametros = new ParametrosSpacenetConfig();

		public Configuracao()
		{
			InitializeComponent();
			BotaoSalvarConfig();
			ImagemDeAlterarConfiguracao();
			DesabilitarConfiguracoes();
			CarregarAppConfig();
		}

		public void AbrirTelaPrincipal()
		{
			Principal principal = new Principal
			{
				Visible = true
			};
		}

		public void FecharTelaConfiguracao()
		{
			this.Close();
		}


		public void AtualizarAppConfig()
		{
			value.InstanciaBancoDeDados = textBox1.Text;
			value.BancoDeDadosSac = textBox3.Text;
			value.DiretorioSpaceNet = textBox4.Text;
			value.DiretorioFile = textBox5.Text;
			value.RefreshConfiguracoesAppConfig();
			value.SalvarParametrosAppConfig();
			
		}

		public void CarregarAppConfig()
		{
			textBox1.Text = value.InstanciaBancoDeDados;
			textBox3.Text = value.BancoDeDadosSac;
			textBox4.Text = value.DiretorioSpaceNet;
			textBox5.Text = value.DiretorioFile;
		}

		public void DesabilitarConfiguracoes()
		{
			textBox1.Enabled = false;
			textBox3.Enabled = false;
			textBox4.Enabled = false;
			textBox5.Enabled = false;
		}

		public void HabilitarAlterarConfiguracoes()
		{
			textBox1.Enabled = true;	
			textBox3.Enabled = true;
			textBox4.Enabled = true;
			textBox5.Enabled = true;
		}
		
		private void Configuracao_Load(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			BotaoAlterarConfig(false);
			BotaoSalvarConfig(true);
			ImagemDeAlterarConfiguracao(true);
			HabilitarAlterarConfiguracoes();
		}

		private void button1_Click(object sender, EventArgs e)
		{
				AtualizarAppConfig();
				value.SalvarParametrosAppConfig();
				value.RefreshConfiguracoesAppConfig();
				FecharTelaConfiguracao();
				AbrirTelaPrincipal();		
		}

		private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FecharTelaConfiguracao();
			AbrirTelaPrincipal();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(diretorio.DiretorioSpacenet(textBox4.Text)== false)
			{
				menuStrip1.Enabled = false;
				return;
			}

			if(diretorio.DiretorioDataBase(textBox5.Text) == false)
			{
				menuStrip1.Enabled = false;
				return;

			}
			    menuStrip1.Enabled = true;
			    BotaoAlterarConfig(true);
				BotaoSalvarConfig(false);
				ImagemDeAlterarConfiguracao();
				AtualizarAppConfig();
				value.RefreshConfiguracoesAppConfig();
				DesabilitarConfiguracoes();
		}

		public void BotaoSalvarConfig(bool check = false)
		{
			btnSalvarConfig.Enabled = check;
		}

		public void BotaoAlterarConfig(bool check = true)
		{
			btnAlterarConfig.Enabled = check;
		}

		public void ImagemDeAlterarConfiguracao(bool check = false)
		{
			AlterarConfigImage.Visible = check;
		}


	}
}
