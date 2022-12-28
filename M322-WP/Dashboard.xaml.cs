
using M322_WP.Models;

namespace M322_WP;

public partial class Dashboard : ContentPage {
    public Dashboard()
    {
        InitializeComponent();
        BindingContext = new DashboardViewModel();
    }
}

