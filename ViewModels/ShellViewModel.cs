/*
 * Created by SharpDevelop.
 * User: davidr
 * Date: 6/17/2012
 * Time: 9:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Caliburn.Micro;
using System.Windows;

namespace TestWithCaliburnMicro.ViewModels
{
	/// <summary>
	/// Description of ShellViewModel.
	/// </summary>
	public class ShellViewModel : PropertyChangedBase
	{
		string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get { return !string.IsNullOrWhiteSpace(Name); }
        }

        public void SayHello()
        {
            MessageBox.Show(string.Format("Hello {0}!", Name)); //Don't do this in real life :)
        }
        
        private BottomMenuViewModel _bottomMenu;
        public BottomMenuViewModel BottomMenu {
        	get { return _bottomMenu; }
        }
        
        private TopMenuViewModel _topMenu;
        public TopMenuViewModel TopMenu {
        	get { return _topMenu;} 
        }
	}
}
