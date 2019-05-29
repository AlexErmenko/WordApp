using System.Windows.Forms;

namespace Word_Application
{
	public static class Navigator

	{
		public static void Nav(this Form from, Form to)
		{
			from.Hide();
			to.Show();
		}
	}
}