namespace TestDraw
{
	partial class DrawLine
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
			this.btnDrawLine = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnDrawLine
			// 
			this.btnDrawLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnDrawLine.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDrawLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDrawLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnDrawLine.Location = new System.Drawing.Point(12, 315);
			this.btnDrawLine.Name = "btnDrawLine";
			this.btnDrawLine.Size = new System.Drawing.Size(151, 85);
			this.btnDrawLine.TabIndex = 0;
			this.btnDrawLine.Text = "Draw Line";
			this.btnDrawLine.UseVisualStyleBackColor = false;
			this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 422);
			this.Controls.Add(this.btnDrawLine);
			this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Draw";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDrawLine;
	}
}

