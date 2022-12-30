using M322_WP.Repositories;
using Microsoft.VisualBasic.CompilerServices;

namespace M322_WP;

public partial class Dashboard : ContentPage
{
    public Dashboard()
    {
        InitializeComponent();
        BindingContext = new ProfileRepository();
    }

    private async void Edit_Profile(object sender, EventArgs e)
    {
        var settings = (ImageButton) sender;
        var listViewItem = (Grid) settings.Parent;
        var label = (Label) listViewItem.Children[0];
        var id = IntegerType.FromString(label.Text.Split(".")[0]);
        var profile = (from thing in new ProfileRepository().Profiles
            where thing.Id == id
            select thing).SingleOrDefault();

        // label.Text = profile?.HomeScreenPath;

        var navigationParameter = new Dictionary<string, object>
        {
            {"Profile", profile}
        };
        await Shell.Current.GoToAsync("form", navigationParameter);
    }
}