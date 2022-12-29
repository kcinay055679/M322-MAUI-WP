using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace M322_WP.Models;

public class Profile : INotifyPropertyChanged
{
    public Profile(int id, string name, string lockScreenPath, string homeScreenPath)
    {
        Id = id;
        Name = id + ". " + name;
        LockScreenPath = lockScreenPath;
        HomeScreenPath = homeScreenPath;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string LockScreenPath { get; set; }
    public string HomeScreenPath { get; set; }


    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
    {
        if (Equals(storage, value))
            return false;

        storage = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}