
using M322_WP.Models;
using M322_WP.Repositories;

namespace M322_WP;

public partial class Dashboard : ContentPage {
    public Dashboard()
    {
        InitializeComponent();
        BindingContext = new ProfileRepository();
    }

	private void Edit_Profile( object sender, EventArgs e )
	{
		ImageButton settings = (ImageButton)sender;
		Grid listViewItem = (Grid)settings.Parent;
		Label label = (Label)listViewItem.Children[0];
		label.Text = "selected";
		
	}
}

