using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M322_WP;

public partial class InformationPage : ContentPage
{
    public InformationPage()
    {
        InitializeComponent();
    }

    private async void NavigateDashboard(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("dashboard");
    }
}