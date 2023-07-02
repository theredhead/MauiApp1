using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class ProxiesPage : ContentPage
{
    private ProxiesViewModel myViewModel;

    public ProxiesPage(ProxiesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = myViewModel = viewModel;
	}

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        myViewModel.Proxies.Add(new Proxy
        {
            Name = $"Proxy #{myViewModel.Proxies.Count()}",
            Description = $"Created {DateTime.Now.ToLongDateString()}",
            InternalUrl = "something.local",
            ExternalUrl = "something.theredhead.nl"
        });

    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if(e.CurrentSelection[0] is Proxy proxy)
        {
            Title = proxy.Name;
        } 
        else
        {
            Title = "No selection";
        }
    }
}

