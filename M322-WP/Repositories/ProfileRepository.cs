using System.Collections.ObjectModel;
using M322_WP.Models;

namespace M322_WP.Repositories;

internal class ProfileRepository
{
    public ProfileRepository()
    {
        Profiles = GenerateDefaultValues(10);
    }

    public ObservableCollection<Profile> Profiles { get; set; }

    private static ObservableCollection<Profile> GenerateDefaultValues(int amount)
    {
        ObservableCollection<Profile> profiles = new();
        for (var i = 1; i <= amount; i++)
            profiles.Add(new Profile(i, "Example name", $"screen{i}.png", $"screen{i}.png"));
        return profiles;
    }
}