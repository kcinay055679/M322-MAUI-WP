using M322_WP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace M322_WP
{
    class DashboardViewModel : INotifyPropertyChanged
    {
        private List<Profile> _profiles = new List<Profile>();

        public List<Profile> Profiles
        {
            get { return _profiles; }
            set { SetProperty(ref _profiles, value); }
        }

        public DashboardViewModel()
        {
            List<Profile> list = new List<Profile>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Profile($"name {i}", $"screen{i}.png", $"screen{i}.png"));
            }
            Profiles= list;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
