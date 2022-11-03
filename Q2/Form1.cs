using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//寫不出來
			/*亂數取得四個點數
			 * 如果點數不同就重新,直到至少兩顆相同
			 * 若兩顆相同,例如2236就傳回9
			 * 若三顆相同,例如2226就傳回8
			 * 若四顆相同,例如2222就傳回4
			*/
			Random random = new Random();
		}
	}
}
