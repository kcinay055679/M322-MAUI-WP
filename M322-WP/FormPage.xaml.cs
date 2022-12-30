using M322_WP.Models;

namespace M322_WP;

[QueryProperty(nameof(Profile), nameof(Profile))]
public partial class FormPage : ContentPage
{
    Profile profile = new (0, "", "edit_wp.png", "add_wp.png");
    private string name = "";
    public Profile Profile
    {
        get => profile;
        set
        {
            profile = value;
            OnPropertyChanged();
        }
    }
    public FormPage()
    {
        InitializeComponent();

        BindingContext = this;

       
    }

    private void NameInput_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        name = entry.Text;
        entry.TextColor = !IsValid(name) ? Colors.Red : Colors.Black;
    }

    private async void Apply_OnClicked(object sender, EventArgs e)
    {
        ((Button) sender).BackgroundColor = Colors.Red;
        if (IsValid(name))
        {
            await Shell.Current.GoToAsync("dashboard");
        }
    }
    private async void Cancel_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("dashboard");
    }

    private static bool IsValid(string text)
    {
        return text.Length is > 2 and < 25;
    }
}