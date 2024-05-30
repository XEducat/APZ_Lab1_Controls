using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsControlLibrary1
{
	[ToolboxBitmap(@"D:\MyPrograms\Microsoft VS Projects\KHAI Projs\SA_Controls_Lab1\WinFormsControlLibrary1\Icons\Sprite-0001.ico")]
	public partial class InfoTextBox : TextBox
	{
		private long _byteSize;

		// Подія, яка відбувається при зміні значення обсягу інформації
		public event EventHandler? ByteSizeChanged;

		// Властивість для зберігання обсягу інформації у байтах
		public long ByteSize
		{
			get { return _byteSize; }
			set
			{
				if (_byteSize != value)
				{
					_byteSize = value;
					ByteSizeChanged?.Invoke(this, EventArgs.Empty);
				}
			}
		}

		// Конвертація рядка в байти
		private long ParseByteString(string input)
		{
			long result = 0;
			string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (parts.Length == 2)
			{
				long value;
				if (long.TryParse(parts[0], out value))
				{
					switch (parts[1].ToUpper())
					{
						case "B":
						case "BYTE":
							result = value;
							break;
						
						case "KB":
						case "KILOBYTE":
							result = value * 1024;
							break;
						
						case "MB":
						case "MEGABYTE":
							result = value * 1024 * 1024;
							break;
						
						case "GB":
						case "GIGABYTE":
							result = value * 1024 * 1024 * 1024;
							break;
						default:
							throw new ArgumentException("Invalid size format. You can use only B - Byte, KB - Kilobyte, MB - Megabyte, GB - Gigabyte");
					}
				}
				else
				{
					throw new ArgumentException("Invalid number format. Сheck if you entered a number");
				}
			}
			else
			{
				throw new ArgumentException("Invalid size format. Data must be entered with a space\n[num] [type], Example: \"3 KB\"");
			}
			return result;
		}

		public void ConvertToByte() => ByteSize = ParseByteString(Text);
	}
}
