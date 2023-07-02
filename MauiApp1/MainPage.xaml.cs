using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private MainViewModel myViewModel;

    public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = myViewModel = viewModel;
	}

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        myViewModel.Proxies.Add(new Proxy
        {
            Name = $"Proxy #{myViewModel.Proxies.Count()}",
            Description = $"Created {DateTime.Now.ToLongDateString()}"
        });

    }
}

