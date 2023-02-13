namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void MauiToVue3Clicked(object sender, EventArgs eventArgs)
    {
        var main = new Main();
        await main.InvokeCommunication();
    }
}