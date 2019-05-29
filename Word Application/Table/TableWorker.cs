using Microsoft.Office.Interop.Word;

namespace Word_Application
{
	internal class TableWorker
	{
		private readonly Document Document;

		public TableWorker(Document doc)
		{
			Document = doc;
			Range    = Document.Content.NextStoryRange;
		}

		private Range Range { get; }

		public void Create(int row, int coll)
		{
		}

		public void AddRow()
		{
		}
	}
}