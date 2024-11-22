namespace WorkTest
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.pcaButton1 = new PCA.Controls.PcaButton();
			this.pcaTextBox1 = new PCA.Controls.PcaTextBox();
			this.pcaGuideLabel1 = new PCA.Controls.PcaGuideLabel();
			this.pcaCheckBox1 = new PCA.Controls.PcaCheckBox();
			this.SuspendLayout();
			// 
			// pcaButton1
			// 
			this.pcaButton1.Location = new System.Drawing.Point(132, 96);
			this.pcaButton1.Name = "pcaButton1";
			this.pcaButton1.Size = new System.Drawing.Size(72, 22);
			this.pcaButton1.TabIndex = 0;
			this.pcaButton1.Text = "ボタン1";
			this.pcaButton1.UseVisualStyleBackColor = true;
			this.pcaButton1.Click += new System.EventHandler(this.pcaButton1_Click);
			// 
			// pcaTextBox1
			// 
			this.pcaTextBox1.CellValue = "";
			this.pcaTextBox1.Location = new System.Drawing.Point(111, 57);
			this.pcaTextBox1.Name = "pcaTextBox1";
			this.pcaTextBox1.Size = new System.Drawing.Size(120, 20);
			this.pcaTextBox1.TabIndex = 1;
			// 
			// pcaGuideLabel1
			// 
			this.pcaGuideLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
			this.pcaGuideLabel1.ForeColor = System.Drawing.Color.Black;
			this.pcaGuideLabel1.Location = new System.Drawing.Point(74, 155);
			this.pcaGuideLabel1.MaxLine = 2;
			this.pcaGuideLabel1.MaxTextLength = 30;
			this.pcaGuideLabel1.Name = "pcaGuideLabel1";
			this.pcaGuideLabel1.Size = new System.Drawing.Size(206, 32);
			this.pcaGuideLabel1.TabIndex = 2;
			this.pcaGuideLabel1.Text = "テキストボックスに入力した文字列をメッセージ表示することができます。";
			// 
			// pcaCheckBox1
			// 
			this.pcaCheckBox1.Location = new System.Drawing.Point(84, 57);
			this.pcaCheckBox1.MaxTextLength = 3;
			this.pcaCheckBox1.Name = "pcaCheckBox1";
			this.pcaCheckBox1.Size = new System.Drawing.Size(18, 20);
			this.pcaCheckBox1.TabIndex = 2;
			this.pcaCheckBox1.UseVisualStyleBackColor = true;
			this.pcaCheckBox1.CheckedChanged += new System.EventHandler(this.pcaCheckBox1_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 338);
			this.Controls.Add(this.pcaGuideLabel1);
			this.Controls.Add(this.pcaCheckBox1);
			this.Controls.Add(this.pcaTextBox1);
			this.Controls.Add(this.pcaButton1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private PCA.Controls.PcaButton pcaButton1;
		private PCA.Controls.PcaTextBox pcaTextBox1;
		private PCA.Controls.PcaGuideLabel pcaGuideLabel1;
		private PCA.Controls.PcaCheckBox pcaCheckBox1;
	}
}

