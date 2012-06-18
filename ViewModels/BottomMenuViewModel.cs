/*
 * Created by SharpDevelop.
 * User: davidr
 * Date: 06/17/2012
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Caliburn.Micro;
using System.Windows;

namespace TestWithCaliburnMicro.ViewModels
{
	/// <summary>
	/// Description of BottomMenuViewModel.
	/// </summary>
	public class BottomMenuViewModel : PropertyChangedBase
	{
		public BottomMenuViewModel()
		{
			// Constructor test
			int x = 0;
			MessageBox.Show("x = " + x.ToString());
		}
		
	}
}
