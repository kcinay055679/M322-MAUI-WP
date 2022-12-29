using M322_WP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Sockets;

namespace M322_WP.Repositories
{
    class ProfileRepository
    {
		public ObservableCollection<Profile> Profiles { get; set; } = new();

		public ProfileRepository()
		{
			Profiles = GernerateDefatultValues();
		}

		private ObservableCollection<Profile> GernerateDefatultValues()
		{
			ObservableCollection<Profile> _Profiles  = new();
			for (int i = 0; i < 10; i++)
			{
				_Profiles.Add(new Profile($"name {i}", $"screen{i}.png", $"screen{i}.png"));
			}
			return _Profiles;

	}
}
}
