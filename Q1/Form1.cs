using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string value = string.Empty;
			int[] ans = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			Random random = new Random();
			ans = ans.OrderBy(x => random.Next()).ToArray();
			for(int i = 0; i < 4; i++)
			{
				value+=(ans[i]).ToString();
			}
			answerlabel.Text = value;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int a = 0;int b = 0;
			string input = textBox1.Text;
			string answer = answerlabel.Text;

			int[] aa = new int[] { input[0], input[1],input[2], input[3] };
			int[] ans = new int[] { answer[0], answer[1], answer[2], answer[3] };
			for(int i = 0; i < aa.Length; i++)
			{
				for(int j = 0; j < ans.Length; j++)
				{
					if(ans[i] == aa[j])
					{
						b++;
						if (i == j)
						{
							b = b - 1;
							a = a + 1;
						}
					}
				}
				ABlabel.Text = $"{a}A{b}B";
			}
		}
	}
}
