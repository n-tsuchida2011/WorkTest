﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pcaButton1_Click(object sender, EventArgs e)
		{
			string message = this.pcaTextBox1.Text;
			if (String.IsNullOrEmpty(message))
			{
				message = "ボタンを押しました";
			}

			MessageBox.Show(message);
		}

		private void pcaCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.pcaTextBox1.Enabled = pcaCheckBox1.Checked;
		}
	}
}
