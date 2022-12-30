using System.Collections.ObjectModel;
using M322_WP.Models;

namespace M322_WP.Repositories;

public class SettingsRepository
{
    public SettingsRepository()
    {
        SettingEntries = GenerateDefaultValues(6);
    }

    public ObservableCollection<SettingEntry> SettingEntries { get; set; }

    private static ObservableCollection<SettingEntry> GenerateDefaultValues(int amount)
    {
        ObservableCollection<SettingEntry> settingEntries = new();
        for (var i = 1; i <= amount; i++)
            settingEntries.Add(new SettingEntry("Random entry"));
        return settingEntries;
    }
}