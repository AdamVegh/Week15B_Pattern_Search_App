using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PatternSearchApp
{
	public partial class FormMatcher : Form
	{
		public FormMatcher()
		{
			InitializeComponent();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			richTextBox2.Text = "";
			string pattern = textBoxPattern.Text;
			Match match;

			foreach (var item in richTextBox1.Text.Split('\n'))
			{
				match = Regex.Match(item, pattern);
				if (match.Length > 0)
					richTextBox2.Text += item + '\n';
			}
		}
	}
}
