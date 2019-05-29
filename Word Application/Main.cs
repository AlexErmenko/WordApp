using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using static System.Environment;
using static System.Environment.SpecialFolder;
using Application = Microsoft.Office.Interop.Word.Application;
using Font = System.Drawing.Font;

namespace Word_Application
{
	public partial class Main : Form
	{
		private readonly Dictionary<string, WdParagraphAlignment> Aligment =
				new Dictionary<string, WdParagraphAlignment>
				{
						[key: "По центру"]       = WdParagraphAlignment.wdAlignParagraphCenter,
						[key: "По левому краю"]  = WdParagraphAlignment.wdAlignParagraphLeft,
						[key: "По правому краю"] = WdParagraphAlignment.wdAlignParagraphRight,
						[key: "По ширине"]       = WdParagraphAlignment.wdAlignParagraphJustify
				};

		//Co

		private readonly Application                            Application;
		private readonly Microsoft.Office.Interop.Word.Bookmark Bookmark;

		private readonly DocumentManager manager;
		private readonly Paragraph       Paragraph;

		private readonly SaveFileDialog saveFile = new SaveFileDialog
													{
															Filter =
																	"Word Document (*.docx,*.doc)|*.doc|*.docx",
															AddExtension  = true,
															ValidateNames = true,
															InitialDirectory =
																	$@"{GetFolderPath(folder: MyDocuments)}",
															OverwritePrompt  = true,
															CreatePrompt     = true,
															RestoreDirectory = true
													};

		private readonly Selection Selection;
		private          Document  Document;
		private          Font      FileFont;

		private Image  Picture;
		private Range  Range;
		private object start = 0, end = 0;
		private Table  Table;

		public Main()
		{
			InitializeComponent();
			Application = new Application();
			manager     = new DocumentManager(app: Application);

			//Range = Document.Paragraphs[1].Range;
			//Range.Find.Execute("Hello");
			//Range.Select();
			//Range.Font.Size = 25;

			////object start = 0, end = 0;

			////Range = Document.Range(ref start , ref end);

			////Range.InsertParagraphAfter();
			////Range.InsertParagraphAfter();

			////Range.SetRange(Range.End , Range.End);

			////Range.Tables.Add(Document.Paragraphs[2].Range , 3 , 2 , Value , Value);

			//Document.SaveAs2(@"C:\try.doc" , WdSaveOptions.wdSaveChanges);
			//Document.Close();
			//Application.Quit();
		}

		private void Comutication()
		{
			//Уже висит открытый документ
			if (Document != null)
			{
				DialogResult NeedSave =
						MessageBox.Show(text: "Бажаєте зберегти поточний документ ?");

				if (NeedSave == DialogResult.OK)
				{
					var SaveDialog = new SaveFileDialog
									{
											Filter =
													"Word Document (*.docx,*.doc)|*.doc;*.docx",
											AddExtension = true
									};

					DialogResult SaveResult = SaveDialog.ShowDialog();

					//Сохраняем по выбраному пути и обнуляем ссылку на Doc
					if (SaveResult == DialogResult.OK)
					{
						Document.SaveAs2(FileName: SaveDialog.FileName);
						Document.Close();
						Document = null;
					}
				}
				else
					Document = null;
			}
		}

		private void CreateDocument_Click(object sender, EventArgs e) => manager.Create();

		private void OpenDocument_Click(object sender, EventArgs e) => manager.Open();

		private void SaveDoc_Click(object sender, EventArgs e) => manager.Save();

		private void SearchInDocument_Click(object sender, EventArgs e)
		{
			if (Document == null)
			{
				MessageBox.Show(text: "Не відкрито жодного документу!");

				return;
			}

			if (Document.Content.Start == (Document.Content.End + 1))
			{
				MessageBox.Show(text: "Документ порожній");

				return;
			}

			if (Application.Selection.Find.Execute(FindText: "Привет"))
				MessageBox.Show(text: "Текст был найден");
			else
				MessageBox.Show(text: "Не удалось ничего отыскать(");
		}

		private void search_test()
		{
			var text  = SearchText.Text;
			var count = 0;

			if (!string.IsNullOrEmpty(value: text))
			{
				Range              = Document.Content;
				Range.Find.Forward = true;
				Range.Find.Text    = text;

				Range.Find.Execute();

				while (Range.Find.Found)
				{
					Range.Select();

					count++;
					Range.Find.Execute();
				}

				MessageBox.Show(text: $@"Count find : {count}");

				//Range = Document.Paragraphs[2].Range;
				//Range.Find.Execute(text);
				//Range.Select();
				//MessageBox.Show($@"Start text: {Range.Start} | End text : {Range.End}");
			}
		}

		private void test()
		{
			Range = Document.Range(Start: ref start, End: ref end);
			#pragma warning disable CS0219 // Переменной "i" присвоено значение, но оно ни разу не использовано.
			var i = 5;
			#pragma warning restore CS0219 // Переменной "i" присвоено значение, но оно ни разу не использовано.
			Document.Bookmarks.Add(Name: "f", Range: Range);
			Microsoft.Office.Interop.Word.Bookmark book = Document.Bookmarks[Index: 1];

			book.Range.Text = "Aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

			Console.WriteLine(value: Range);

			//Range = Document.Range(Range.End , Range.StoryLength);
			Range.SetRange(Start: Range.End, End: Range.StoryLength);

			Console.WriteLine(value: Document.Bookmarks.Count);

			Document.Bookmarks.Add(Name: "Next", Range: Range);

			Microsoft.Office.Interop.Word.Bookmark b = Document.Bookmarks[Index: 1];

			b.Range.Text = "SSSSSSSSSSSSSSSSSSS";
			Console.WriteLine(value: Document.Bookmarks.Count);

			////contentControl.Range.Text = "SSSSSSSSSSSSSSSSSSSSSSSS";
		}

		private void CreateTable_Click(object sender, EventArgs e)
		{
			DataGridView table   = DocumentTable;
			var          rows    = table.Rows.Count;
			var          collums = table.Columns.Count;

			DataGridViewCellCollection header = table.Rows[index: 0].Cells;
			foreach (DataGridViewTextBoxCell item in header) Console.WriteLine(value: item.Value);

			if (Document == null)
			{
			}

			var RowCount  = DocumentTable.RowCount;
			var CollCount = DocumentTable.ColumnCount;

			//if ( Range == null )
			//{
			//	object start = 0, end = 0;
			//	Range = Document.Range(ref start , ref end);
			//	Range.InsertParagraphAfter();
			//	Range.InsertParagraphAfter();

			//	Range.SetRange(Range.End , Range.End);

			//	Range.Tables.Add(Document.Paragraphs[2].Range , 3 , 2 , Value , Value);
			//	Table =Document.Tables[1];

			//	Table.Range.Font.Size = 12;
			//	Table.Columns.DistributeWidth();
			//	object styleName = "Table Professional";

			//	Table.set_Style(ref styleName);
			//}

			Range = Document.Range(Start: 0, End: 0);

			Document.Tables.Add(Range: Range, NumRows: RowCount, NumColumns: CollCount);

			Table                 = Document.Tables[Index: 1];
			Table.Range.Font.Size = 12;
			Table.Borders.Enable  = 5;
		}

		private void Main_Load(object sender, EventArgs e)
		{
			var aligmentVal = Aligment.Keys.ToArray();
			AligmentCbb.Items.AddRange(items: aligmentVal);
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e) =>
				Application
					.Quit(); //try//{//    if (Document != null)//    {//        Marshal.FinalReleaseComObject(Document);//    }//    if (Application != null)//    {//        Application.Quit();//    }//}//catch (Exception)//{//}//finally//{//    Exit();//}

		//Pick Image for add in doc
		private void PickImage_Click(object sender, EventArgs e)
		{
			var openFile = new OpenFileDialog
							{
									Filter =
											"Image Files (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
							};

			DialogResult res = openFile.ShowDialog();

			if (res == DialogResult.OK)
				Picture = new Bitmap(original: Image.FromFile(filename: openFile.FileName));
		}

		private void FontDoc_Click(object sender, EventArgs e)
		{
			DialogResult res = fontDialog1.ShowDialog();

			if (res == DialogResult.OK) FileFont = fontDialog1.Font;
		}

		//set visible doc
		private void CheckBox1_CheckedChanged(object sender, EventArgs e) =>
				Application.Visible = VisibleDoc.Checked;
	}
}