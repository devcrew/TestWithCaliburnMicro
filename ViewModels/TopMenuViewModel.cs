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
	/// Description of TopMenuViewModel.
	/// </summary>
	public class TopMenuViewModel : PropertyChangedBase
	{
		public TopMenuViewModel()
		{
			// Constructor testing
			MessageBox.Show("Inside constructor");
		}
		
	}
}
