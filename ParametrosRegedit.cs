using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupDataBase
{
	public class ParametrosRegedit
	{

		public void CriarRegistro()
		{
			string PATH = @"SOFTWARE\SPACENET";
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(PATH);
			registryKey.SetValue("REGISTROBACKUP", "ATIVO");
			registryKey.Close();
			MessageBox.Show("Registro criado com sucesso");

		}

		public bool LerRegistro()
		{
			string PATH = @"SOFTWARE\SPACENET";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PATH);
			if(registryKey.GetValue("REGISTROBACKUP").ToString() == "ATIVO")
			{
				return true;
			}
			return false;

		}
	}
}
