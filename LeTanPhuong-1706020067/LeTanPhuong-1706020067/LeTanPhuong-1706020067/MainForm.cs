/*
 * Created by SharpDevelop.
 * User: C1-B06
 * Date: 1/8/2019
 * Time: 8:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LeTanPhuong_1706020067
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsDiem D1 = new clsDiem();
		clsDiem D2 = new clsDiem();
		clsDiem R1 = new clsDiem();
		clsDiem R2 = new clsDiem();
		clsDiem C1 = new clsDiem();
		clsDiem C2 = new clsDiem();
		bool isDrawing = false;
		List<clsHinh> lsHinh = new List<clsHinh>();
		
		Image  File;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		void PbDrawMouseMove(object sender, MouseEventArgs e)
		{
			if(isDrawing == true)
			{
				if(tsbLine.Checked == true)
				{
					System.Drawing.Graphics g = pbDraw.CreateGraphics();
					g.DrawLine(new Pen(Color.White),D1.X,D1.Y,D2.X,D2.Y);
					D2.X = e.X;
					D2.Y = e.Y;
					foreach (var element in lsHinh) {
						element.Draw(g,new Pen(Color.Black));
					}
					g.DrawLine(new Pen(Color.Black),D1.X,D1.Y,D2.X,D2.Y);
				}
			}
			if(isDrawing == true)
			{
				if(tsbHinhThoi.Checked == true)
				{
					System.Drawing.Graphics gr = pbDraw.CreateGraphics();
					gr.DrawRectangle(new Pen(Color.White),R1.X,R1.Y,R2.X,R2.Y);
					R2.X = e.X;
					R2.Y = e.Y;
					foreach (var element in lsHinh) {
						element.Draw(gr,new Pen(Color.Black));
					}
					gr.DrawRectangle(new Pen(Color.Black),R1.X,R1.Y,R2.X,R2.Y);
				}
			}
			if(isDrawing == true)
			{
				if(tsbTamGiac.Checked == true)
				{
					System.Drawing.Graphics gc = pbDraw.CreateGraphics();
					gc.DrawEllipse(new Pen(Color.White),C1.X,C1.Y,C2.X,C2.Y);
					C2.X = e.X;
					C2.Y = e.Y;
					foreach (var element in lsHinh) {
						element.Draw(gc,new Pen(Color.Black));
					}
					gc.DrawEllipse(new Pen(Color.Black),C1.X,C1.Y,C2.X,C2.Y);
				}
			}
		}
		
		void PbDrawMouseUp(object sender, MouseEventArgs e)
		{
			if(tsbLine.Checked == true)
			{
				D2.X = e.X;
				D2.Y = e.Y;
				System.Drawing.Graphics g = pbDraw.CreateGraphics();
				g.DrawLine(new Pen(Color.Black),D1.X,D1.Y,D2.X,D2.Y);
				isDrawing = false;
				
//				clsLine l = new clsLine();
//				l.D1 = D1;
//				l.D2 = D2;
				clsLine l = new clsLine(D1,D2);
				lsHinh.Add(l);
				foreach (var element in lsHinh) {
						element.Draw(g,new Pen(Color.Black));
					}
			}
//			if(tsbHinhThoi.Checked == true)
//			{
//				R2.X = e.X;
//				R2.Y = e.Y;
//				System.Drawing.Graphics gr = pbDraw.CreateGraphics();
//				gr.DrawRectangle(new Pen(Color.Black),R1.X,R1.Y,R2.X,R2.Y);
//				isDrawing = false;
//
//				clsHinhThoi l = new clsHinhThoi(R1,R2);
//				lsHinh.Add(l);
//				foreach (var element in lsHinh) {
//						element.Draw(gr,new Pen(Color.Black));
//					}
//			}
//				if(tsbTamGiac.Checked == true)
//			{
//				C2.X = e.X;
//				C2.Y = e.Y;
//				System.Drawing.Graphics gc = pbDraw.CreateGraphics();
//				gc.DrawEllipse(new Pen(Color.Black),C1.X,C1.Y,C2.X,C2.Y);
//				isDrawing = false;
//
//				clsTamGiacCan l = new clsTamGiacCan(C1,C2);
//				lsHinh.Add(l);
//				foreach (var element in lsHinh) {
//						element.Draw(gc,new Pen(Color.Black));
//					}
//			}
		}
		
		void PbDrawMouseDown(object sender, MouseEventArgs e)
		{
			if(tsbLine.Checked == true)
			{
				isDrawing = true;
				D1.X = e.X;
				D1.Y = e.Y;
			}
//				if(tsbHinhThoi.Checked == true)
//			{
//				isDrawing = true;
//				R1.X = e.X;
//				R1.Y = e.Y;
//			}
//				
//			if(tsbTamGiac.Checked == true)
//			{
//				isDrawing = true;
//				C1.X = e.X;
//				C1.Y = e.Y;
//			}		
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
//			SaveFileDialog f =new SaveFileDialog();
//			//File = new Image();
//			f.Filter = "JPG(*.JPG)|*.jpg";
//			if(f.ShowDialog() == DialogResult.OK)
//			{
//				pbDraw.Image.Save(f.FileName);
//			}
		}
		void TsbLineClick(object sender, EventArgs e)
		{
//			if (tsbLine.Checked== true)
//			{
//				pbDraw.Refresh();
//			}
		}
		void TsbRectangleClick(object sender, EventArgs e)
		{
	
		}
	}
}
