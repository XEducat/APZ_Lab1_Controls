using System.Media;
using WinFormsControlLibrary1;

namespace SA_Lab1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			label1.Text = "";
			label2.Text = "";
		}

		private void infoTextBox1_ByteSizeChanged(object sender, EventArgs e)
		{
			label2.Text = "";
			label1.Text = $"In bytes: {infoTextBox1.ByteSize}";
		}

		private void infoTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true; // Скасовуємо подальшу обробку клавіші Enter

				try
				{
					infoTextBox1.ConvertToByte();
				}
				catch (ArgumentException ex)
				{
					label1.Text = "";
					label2.Text = ex.Message;
				}
			}
		}
	}
}
