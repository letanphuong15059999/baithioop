/*
 * Created by SharpDevelop.
 * User: C1-B06
 * Date: 1/8/2019
 * Time: 8:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LeTanPhuong_1706020067
{
	/// <summary>
	/// Description of clsDiem.
	/// </summary>
	public class clsDiem
	{
		int ix, iy;
		public int X
		{
			get
			{
				return ix;
			}
			set
			{
				ix = value;
			}
		}
		public int Y
		{
			get
			{
				return iy;
			}
			set
			{
				iy = value;
			}
		}
		public clsDiem()
		{
			X=0;
			Y=0;
		}
		public clsDiem(int a, int b)
		{
			X = a;
			Y = b;
		}
	}
}
