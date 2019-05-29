using System;
using System.Windows.Forms;

namespace Word_Application
{
	internal static class Program
	{
		/// <summary>
		///     Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.Run(mainForm: new Start());
		}
	}
}