using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsControlLibrary1
{
	[ToolboxBitmap(typeof(RoundButton), "E:\\Visual Studio Projects\\WinFormsControlLibrary1\\RoundButton.ico")]
	public partial class RoundButton : Button
	{
		private int _borderRadius = 20; // Значення заокруглення за замовчуванням

		public int BorderRadius
		{
			get { return _borderRadius; }
			set
			{
				_borderRadius = value;
				Invalidate(); // Перемальовуємо кнопку при зміні заокруглення
			}
		}

		public RoundButton()
		{
			InitialSetup();
			InitializeComponent();
		}

		// Базове налаштування кнопки
		private void InitialSetup()
		{
			AutoSize = true;
			FlatStyle = FlatStyle.Flat;
			FlatAppearance.BorderSize = 0;
			BackColor = Color.SkyBlue;
			SetStyle(ControlStyles.Selectable, false);
		}

		// Створює форму для малювання кнопки
		private GraphicsPath GetRoundPath(int radius)
		{
			GraphicsPath borderPath = new GraphicsPath();

			// Підготовка даних для розрахунку
			RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
			int cornerRadius = Math.Min(_borderRadius, Math.Min(Width / 2, Height / 2)) * 2;

			// Будуємо границі форми враховуючи радіус
			borderPath.AddArc(Rect.Left, Rect.Top, cornerRadius, cornerRadius, 180, 90);
			borderPath.AddArc(Rect.Right - cornerRadius, Rect.Top, cornerRadius, cornerRadius, 270, 90);
			borderPath.AddArc(Rect.Right - cornerRadius, Rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
			borderPath.AddArc(Rect.Left, Rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
			borderPath.CloseAllFigures();

			return borderPath;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			// Відображаємо фігуру на основі форми
			GraphicsPath GraphPath = GetRoundPath(BorderRadius);
			this.Region = new Region(GraphPath);

			DrawOutline(e, GraphPath);
		}

		// Відображає контур для кнопки, якщо він заданий
		private void DrawOutline(PaintEventArgs e, GraphicsPath GraphPath)
		{
			if (FlatAppearance.BorderSize > 0)
			{
				using (Pen pen = new Pen(FlatAppearance.BorderColor, FlatAppearance.BorderSize))
				{
					pen.Alignment = PenAlignment.Inset;
					e.Graphics.DrawPath(pen, GraphPath);
				}
			}
		}
	}
}
