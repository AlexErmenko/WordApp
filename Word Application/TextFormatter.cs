using Microsoft.Office.Interop.Word;
using Font = System.Drawing.Font;

namespace Word_Application
{
	internal class TextFormatter
	{
		public string               Text      { get; set; }
		public Font                 Font      { get; set; }
		public WdParagraphAlignment Alignment { get; set; }
	}
}