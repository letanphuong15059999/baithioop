/*
 * Created by SharpDevelop.
 * User: C1-B06
 * Date: 1/8/2019
 * Time: 8:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LeTanPhuong_1706020067
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pbDraw = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbTamGiac = new System.Windows.Forms.ToolStripButton();
			this.tsbHinhThoi = new System.Windows.Forms.ToolStripButton();
			this.tsbLine = new System.Windows.Forms.ToolStripButton();
			this.btSave = new System.Windows.Forms.Button();
			this.btLoad = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbDraw
			// 
			this.pbDraw.BackColor = System.Drawing.Color.White;
			this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbDraw.Location = new System.Drawing.Point(0, 0);
			this.pbDraw.Name = "pbDraw";
			this.pbDraw.Size = new System.Drawing.Size(478, 250);
			this.pbDraw.TabIndex = 0;
			this.pbDraw.TabStop = false;
			this.pbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseDown);
			this.pbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseMove);
			this.pbDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseUp);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsbTamGiac,
									this.tsbHinhThoi,
									this.tsbLine});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(478, 38);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbTamGiac
			// 
			this.tsbTamGiac.Image = ((System.Drawing.Image)(resources.GetObject("tsbTamGiac.Image")));
			this.tsbTamGiac.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTamGiac.Name = "tsbTamGiac";
			this.tsbTamGiac.Size = new System.Drawing.Size(85, 35);
			this.tsbTamGiac.Text = "Tam Giác Cân";
			this.tsbTamGiac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsbHinhThoi
			// 
			this.tsbHinhThoi.Image = ((System.Drawing.Image)(resources.GetObject("tsbHinhThoi.Image")));
			this.tsbHinhThoi.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbHinhThoi.Name = "tsbHinhThoi";
			this.tsbHinhThoi.Size = new System.Drawing.Size(64, 35);
			this.tsbHinhThoi.Text = "Hình Thoi";
			this.tsbHinhThoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbHinhThoi.Click += new System.EventHandler(this.TsbLineClick);
			// 
			// tsbLine
			// 
			this.tsbLine.CheckOnClick = true;
			this.tsbLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbLine.Image")));
			this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLine.Name = "tsbLine";
			this.tsbLine.Size = new System.Drawing.Size(80, 35);
			this.tsbLine.Text = "đường thẳng";
			this.tsbLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbLine.Click += new System.EventHandler(this.TsbLineClick);
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(251, 15);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 23);
			this.btSave.TabIndex = 2;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			// 
			// btLoad
			// 
			this.btLoad.Location = new System.Drawing.Point(364, 15);
			this.btLoad.Name = "btLoad";
			this.btLoad.Size = new System.Drawing.Size(75, 23);
			this.btLoad.TabIndex = 2;
			this.btLoad.Text = "Load";
			this.btLoad.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 250);
			this.Controls.Add(this.btLoad);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.pbDraw);
			this.Name = "MainForm";
			this.Text = "LeTanPhuong-1706020067";
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btLoad;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.ToolStripButton tsbHinhThoi;
		private System.Windows.Forms.ToolStripButton tsbTamGiac;
		private System.Windows.Forms.ToolStripButton tsbLine;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.PictureBox pbDraw;
	}
}
