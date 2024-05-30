namespace SA_Lab1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			roundButton2 = new WinFormsControlLibrary1.RoundButton();
			infoTextBox1 = new WinFormsControlLibrary1.InfoTextBox();
			label1 = new Label();
			label2 = new Label();
			roundButton3 = new WinFormsControlLibrary1.RoundButton();
			SuspendLayout();
			// 
			// roundButton2
			// 
			roundButton2.AutoSize = true;
			roundButton2.BackColor = Color.SkyBlue;
			roundButton2.BorderRadius = 20;
			roundButton2.FlatAppearance.BorderColor = Color.Black;
			roundButton2.FlatAppearance.BorderSize = 0;
			roundButton2.FlatStyle = FlatStyle.Flat;
			roundButton2.Location = new Point(12, 77);
			roundButton2.Name = "roundButton2";
			roundButton2.Size = new Size(161, 40);
			roundButton2.TabIndex = 2;
			roundButton2.Text = "roundButton2";
			roundButton2.UseVisualStyleBackColor = false;
			// 
			// infoTextBox1
			// 
			infoTextBox1.ByteSize = 0L;
			infoTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			infoTextBox1.Location = new Point(305, 195);
			infoTextBox1.Name = "infoTextBox1";
			infoTextBox1.Size = new Size(226, 29);
			infoTextBox1.TabIndex = 3;
			infoTextBox1.TabStop = false;
			infoTextBox1.ByteSizeChanged += infoTextBox1_ByteSizeChanged;
			infoTextBox1.KeyDown += infoTextBox1_KeyDown;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(280, 156);
			label1.Name = "label1";
			label1.Size = new Size(278, 32);
			label1.TabIndex = 4;
			label1.Text = "Label";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(280, 227);
			label2.Name = "label2";
			label2.Size = new Size(278, 101);
			label2.TabIndex = 5;
			label2.Text = "Label";
			label2.TextAlign = ContentAlignment.TopCenter;
			// 
			// roundButton3
			// 
			roundButton3.AutoSize = true;
			roundButton3.BackColor = Color.FromArgb(255, 128, 0);
			roundButton3.BorderRadius = 100;
			roundButton3.FlatAppearance.BorderColor = SystemColors.WindowFrame;
			roundButton3.FlatAppearance.BorderSize = 0;
			roundButton3.FlatStyle = FlatStyle.Flat;
			roundButton3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			roundButton3.ForeColor = SystemColors.Control;
			roundButton3.Location = new Point(50, 181);
			roundButton3.Name = "roundButton3";
			roundButton3.Size = new Size(83, 217);
			roundButton3.TabIndex = 6;
			roundButton3.Text = "Start";
			roundButton3.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(roundButton3);
			Controls.Add(roundButton2);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(infoTextBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private WinFormsControlLibrary1.RoundButton roundButton2;
		private WinFormsControlLibrary1.InfoTextBox infoTextBox1;
		private Label label1;
		private Label label2;
		private WinFormsControlLibrary1.RoundButton roundButton3;
	}
}
