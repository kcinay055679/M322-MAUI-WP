using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace M322_WP.Models
{
    public class Profile: INotifyPropertyChanged
    {
        public string name { get; set; }
        public string lockScreenPath { get; set; }
        public string homeScreenPath { get; set; }

        public Profile(string name, string lockScreenPath, string homeScreenPath)
        {
            this.name = name;
            this.lockScreenPath = lockScreenPath;
            this.homeScreenPath = homeScreenPath;
        }


		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null )
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected bool SetProperty<T>( ref T storage, T value, [CallerMemberName] string propertyName = null )
		{
			if (Object.Equals(storage, value))
				return false;

			storage = value;
			OnPropertyChanged(propertyName);
			return true;
		}
	}
}
