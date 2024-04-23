/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 23.04.2024
 * Время: 17:41
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Combat
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public int cout,d,v;
		Random rnd;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button3Click(object sender, EventArgs e)
		{
			Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			rtb.AppendText(tb.Text+'\n');
			cout=0;
			rnd= new Random();
			if (cout==0)
			{
				v= rnd.Next(20);
				cout=1;
			}
			if (cout==v)
			{
				rtb.AppendText("Push maybe STOP"+'\n');
			}
		}
		void Rb1CheckedChanged(object sender, EventArgs e)
		{
			rtb.ForeColor=(Color.Red);
		}
		void Rb2CheckedChanged(object sender, EventArgs e)
		{
			rtb.ForeColor=(Color.Blue);
		}
		void Rb3CheckedChanged(object sender, EventArgs e)
		{
			rtb.ForeColor=(Color.Black);
		}
	}
}
