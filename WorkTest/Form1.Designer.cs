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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 338);
			this.Controls.Add(this.pcaButton1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private PCA.Controls.PcaButton pcaButton1;
	}
}

