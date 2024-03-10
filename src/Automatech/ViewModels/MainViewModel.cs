using Automatech.Controls.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatech.ViewModels
{
    public class MainViewModel : ObservableObject
    {
		private Status status;

		public Status Status
        {
			get { return status; }
			set { SetProperty(ref status, value); }
		}
	}
}
