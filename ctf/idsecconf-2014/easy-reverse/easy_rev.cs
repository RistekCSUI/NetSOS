using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
	public class Form1 : Form
	{
		private IContainer components = null;
		private Button button1;
		private TextBox textBox1;
		private string Oye = "abcdefghijklmnopqrstuvwxyz0123456789";
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.button1 = new Button();
			this.textBox1 = new TextBox();
			base.SuspendLayout();
			this.button1.Location = new Point(110, 96);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 47);
			this.button1.TabIndex = 0;
			this.button1.Text = "Check Beibe";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.textBox1.Location = new Point(80, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(157, 20);
			this.textBox1.TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(320, 174);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.Name = "Form1";
			this.Text = "IDSECCONF 2014 - EASY REVERSE";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		public Form1()
		{
			this.InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string text = this.Oye.Substring(6, 1);
			text += this.Oye.Substring(0, 1);
			text += this.Oye.Substring(13, 1);
			text += this.Oye.Substring(19, 1);
			text += this.Oye.Substring(4, 1);
			text += text.Substring(2, 1);
			text += text.Substring(0, 1);
			text += this.Oye.Substring(26, 5);
			text = text.Remove(10, 1);
			text = text.Replace(text.Substring(9, 1), text.Substring(7, 1));
			text = text.Replace(text.Substring(7, 1), this.Oye.Substring(28, 1));
			text = text.Replace(text.Substring(8, 2), this.Oye.Substring(26, 2));
			MD5 mD = MD5.Create();
			byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(text));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			if (this.textBox1.Text == text)
			{
				MessageBox.Show(stringBuilder.ToString(), "Flag");
			}
			else
			{
				MessageBox.Show("Dikocok lagi bro");
			}
		}
	}
}
