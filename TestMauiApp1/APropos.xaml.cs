namespace TestMauiApp1;

public partial class APropos : ContentPage
{
	public APropos()
	{
		InitializeComponent();
	}

    private async void Apropos_Clicked(object sender, EventArgs e)
    {
		await Launcher.Default.OpenAsync("https://www.3il-ingenieurs.fr");
    }
}