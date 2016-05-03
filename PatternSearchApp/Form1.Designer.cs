namespace PatternSearchApp
{
	partial class FormMatcher
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelText = new System.Windows.Forms.Label();
			this.labelMatched = new System.Windows.Forms.Label();
			this.textBoxPattern = new System.Windows.Forms.TextBox();
			this.labelPattern = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// labelText
			// 
			this.labelText.AutoSize = true;
			this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelText.Location = new System.Drawing.Point(39, 20);
			this.labelText.Name = "labelText";
			this.labelText.Size = new System.Drawing.Size(35, 17);
			this.labelText.TabIndex = 2;
			this.labelText.Text = "Text";
			// 
			// labelMatched
			// 
			this.labelMatched.AutoSize = true;
			this.labelMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelMatched.Location = new System.Drawing.Point(361, 20);
			this.labelMatched.Name = "labelMatched";
			this.labelMatched.Size = new System.Drawing.Size(62, 17);
			this.labelMatched.TabIndex = 3;
			this.labelMatched.Text = "Matched";
			// 
			// textBoxPattern
			// 
			this.textBoxPattern.Location = new System.Drawing.Point(99, 250);
			this.textBoxPattern.Name = "textBoxPattern";
			this.textBoxPattern.Size = new System.Drawing.Size(234, 20);
			this.textBoxPattern.TabIndex = 4;
			// 
			// labelPattern
			// 
			this.labelPattern.AutoSize = true;
			this.labelPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelPattern.Location = new System.Drawing.Point(39, 251);
			this.labelPattern.Name = "labelPattern";
			this.labelPattern.Size = new System.Drawing.Size(54, 17);
			this.labelPattern.TabIndex = 5;
			this.labelPattern.Text = "Pattern";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(364, 248);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 6;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(42, 40);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(291, 186);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Enabled = false;
			this.richTextBox2.Location = new System.Drawing.Point(364, 40);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(283, 186);
			this.richTextBox2.TabIndex = 8;
			this.richTextBox2.Text = "";
			// 
			// FormMatcher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 311);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.labelPattern);
			this.Controls.Add(this.textBoxPattern);
			this.Controls.Add(this.labelMatched);
			this.Controls.Add(this.labelText);
			this.MaximumSize = new System.Drawing.Size(700, 350);
			this.MinimumSize = new System.Drawing.Size(700, 350);
			this.Name = "FormMatcher";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Matcher";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelText;
		private System.Windows.Forms.Label labelMatched;
		private System.Windows.Forms.TextBox textBoxPattern;
		private System.Windows.Forms.Label labelPattern;
		private System.Windows.Forms.Button buttonSearch;
		public System.Windows.Forms.ListBox listBoxMatched;
		public System.Windows.Forms.ListBox listBoxText;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
	}
}

