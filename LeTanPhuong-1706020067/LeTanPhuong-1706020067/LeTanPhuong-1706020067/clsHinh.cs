/*
 * Created by SharpDevelop.
 * User: C1-B06
 * Date: 1/8/2019
 * Time: 9:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
namespace LeTanPhuong_1706020067
{
	/// <summary>
	/// Description of clsHinh.
	/// </summary>
	public class clsHinh
		{
		clsDiem d1, d2;
		clsDiem r1, r2;
		clsDiem c1, c2;
		public clsDiem D1
		{
			get
			{
				return d1;
			}
			set
			{
				d1.X = value.X;
				d1.Y = value.Y;
			}
		}
		public clsDiem R1
		{
			get
			{
				return r1;
			}
			set
			{
				r1.X = value.X;
				r1.Y = value.Y;
			}
		}
		public clsDiem C1
		{
			get
			{
				return c1;
			}
			set
			{
				c1.X = value.X;
				c1.Y = value.Y;
			}
		}
		public clsDiem D2
		{
			get
			{
				return d2;
			}
			set
			{
				d2.X = value.X;
				d2.Y = value.Y;
			}
		}
		public clsDiem R2
		{
			get
			{
				return r2;
			}
			set
			{
				r2.X = value.X;
				r2.Y = value.Y;
			}
		}
		public clsDiem C2
		{
			get
			{
				return c2;
			}
			set
			{
				c2.X = value.X;
				c2.Y = value.Y;
			}
		}
		public clsHinh()
		{
			d1 = new clsDiem();
			d2 = new clsDiem();
			r1 = new clsDiem();
			r2 = new clsDiem();
			c1 = new clsDiem();
			c2 = new clsDiem();
		}
		public virtual void Draw(Graphics g, Pen p)
		{
		}
	}
}
