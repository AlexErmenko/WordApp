using Microsoft.Office.Interop.Word;

namespace Word_Application.Bookmark
{
	internal class BookmarkWorker
	{
		private Range Range;

		public BookmarkWorker(Document document) => Document = document;
		public Document Document { get; }

		public void SetText(string s)
		{
		}
	}
}