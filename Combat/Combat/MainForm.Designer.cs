/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 23.04.2024
 * Время: 17:41
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Combat
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox rtb;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rb3;
		private System.Windows.Forms.RadioButton rb2;
		private System.Windows.Forms.RadioButton rb1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.tb = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rb3 = new System.Windows.Forms.RadioButton();
			this.rb2 = new System.Windows.Forms.RadioButton();
			this.rb1 = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtb
			// 
			this.rtb.ForeColor = System.Drawing.SystemColors.WindowText;
			this.rtb.Location = new System.Drawing.Point(0, 0);
			this.rtb.Name = "rtb";
			this.rtb.Size = new System.Drawing.Size(324, 214);
			this.rtb.TabIndex = 0;
			this.rtb.Text = "";
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(6, 238);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(317, 20);
			this.tb.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(188, 284);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(68, 37);
			this.button1.TabIndex = 2;
			this.button1.Text = "Send";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(275, 284);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(68, 37);
			this.button2.TabIndex = 2;
			this.button2.Text = "Stop";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(362, 284);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(68, 37);
			this.button3.TabIndex = 2;
			this.button3.Text = "Close";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(345, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(143, 136);
			this.panel1.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rb3);
			this.groupBox1.Controls.Add(this.rb2);
			this.groupBox1.Controls.Add(this.rb1);
			this.groupBox1.Location = new System.Drawing.Point(0, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(142, 123);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pushing";
			// 
			// rb3
			// 
			this.rb3.Location = new System.Drawing.Point(17, 92);
			this.rb3.Name = "rb3";
			this.rb3.Size = new System.Drawing.Size(99, 25);
			this.rb3.TabIndex = 0;
			this.rb3.TabStop = true;
			this.rb3.Text = "BLACK";
			this.rb3.UseVisualStyleBackColor = true;
			this.rb3.CheckedChanged += new System.EventHandler(this.Rb3CheckedChanged);
			// 
			// rb2
			// 
			this.rb2.Location = new System.Drawing.Point(17, 61);
			this.rb2.Name = "rb2";
			this.rb2.Size = new System.Drawing.Size(99, 25);
			this.rb2.TabIndex = 0;
			this.rb2.TabStop = true;
			this.rb2.Text = "BLUE";
			this.rb2.UseVisualStyleBackColor = true;
			this.rb2.CheckedChanged += new System.EventHandler(this.Rb2CheckedChanged);
			// 
			// rb1
			// 
			this.rb1.Location = new System.Drawing.Point(17, 30);
			this.rb1.Name = "rb1";
			this.rb1.Size = new System.Drawing.Size(99, 25);
			this.rb1.TabIndex = 0;
			this.rb1.TabStop = true;
			this.rb1.Text = "RED";
			this.rb1.UseVisualStyleBackColor = true;
			this.rb1.CheckedChanged += new System.EventHandler(this.Rb1CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 337);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.rtb);
			this.Name = "MainForm";
			this.Text = "Combat";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
