using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Word_Application
{
	/// <summary>
	///     Класс реализует:
	/// </summary>
	public class DocumentManager
	{
		#region OpenFileBuilder

		private readonly OpenFileDialog open = new OpenFileDialog
												{
														Filter =
																"Word Document (*.docx,*.doc)|*.doc;*.docx"
												};

		#endregion

		private readonly string Question = "Бажаєте зберегти поточний документ ?";

		#region SaveDialogBuilder

		private readonly SaveFileDialog save = new SaveFileDialog
												{
														Filter =
																"Word Document (*.docx,*.doc)|*.doc;*.docx",
														AddExtension = true
												};

		#endregion

		private Application App;

		/// <summary>
		///     Получем ссылку на экземпляр приложения
		/// </summary>
		/// <param name="app"></param>
		public DocumentManager(Application app) => App = app;

		private Document Document { get; set; }

		/// <summary>
		///     Освобождаем ссылки на Application и Document для коректного завершения работы процесса COM
		///     взаимодействия
		/// </summary>
		~DocumentManager()
		{
			App      = null;
			Document = null;
		}

		/// <summary>
		///     Проверяем текущее состояние документа
		/// </summary>
		private void CheckDocumentState()
		{
			if (Document == null)
				return;

			if (MessageBox.Show(text: $"{Question}", caption: "Демонстраційна программа",
								buttons: MessageBoxButtons.OKCancel)
				== DialogResult.OK)
			{
				if (save.ShowDialog() == DialogResult.OK)
				{
					Document.SaveAs2(FileName: save.FileName);
					Document.Close();
					Document = null;
				}
			}
		}

		/// <summary>
		///     Открываем выбраный документ
		/// </summary>
		public void Open()
		{
			CheckDocumentState();

			if (open.ShowDialog() == DialogResult.OK)
			{
				App.Documents.Open(FileName: open.FileName);
				Document = App.ActiveDocument;
			}
		}

		/// <summary>
		///     Создаем новый документ
		/// </summary>
		public void Create()
		{
			CheckDocumentState();
			App.Documents.Add();
			Document = App.ActiveDocument;
		}

		/// <summary>
		///     Сохраняем текущий документ
		/// </summary>
		public void Save() => CheckDocumentState();

		public void CreateTable(DataGridView view)
		{
		}
	}
}