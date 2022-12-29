using M322_WP.Models;

namespace M322_WP;

[QueryProperty(nameof(Profile), "Profile")]
public partial class FormPage : ContentPage
{
    Profile profile;
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
    }
}