using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupDataBase
{
	public class ParametrosDiretorio
	{
		
		public bool DiretorioComunicador(string diretorio)
		{

			if (File.Exists($"{diretorio}\\SpnComm.exe"))
			{
				MessageBox.Show("Aplicação não pode ser executada ", "Erro SpnComm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}

			return false;
		}

		public bool DiretorioSpacenet(string diretorio)
		{
			DirectoryInfo file = new DirectoryInfo(diretorio);
			if (file.Exists)
			{
				return true;
			}
			MessageBox.Show($"O diretorio {diretorio} não foi encontrado !!", "Erro Diretorio Spacenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;

		}

		public bool DiretorioSpacenetIt(string diretorio)
		{
			if (File.Exists($"{diretorio}\\SpacenetIt.exe"))
			{
				return true;
			}

			MessageBox.Show($"Aplicação Spacenet It não foi encontrada do diretorio {diretorio}", "Erro Spacenet It", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}

		public bool DiretorioDataBase(string diretorio)
		{
			DirectoryInfo file = new DirectoryInfo(diretorio);
			if (file.Exists)
			{
				return true;
			} 
			MessageBox.Show($"O diretorio {diretorio} não foi encontrado !!", "Erro DataBase", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
			
		}
		public bool BancoDeDadosSelecionado(string diretorio)
		{
			if (diretorio.Equals(""))
			{
				MessageBox.Show("Necessário selecionar o banco de dados", "Erro Seleção do Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

	}
}
