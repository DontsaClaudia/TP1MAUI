using System.Text;

namespace TestMauiApp1.Views;

public partial class vPhone : ContentPage
{
	public vPhone()
	{
		InitializeComponent();
		Phone_info();
		Get_Idiom();
		Routing.RegisterRoute($"{nameof(vEcran)}", typeof(vEcran));
        Routing.RegisterRoute($"{nameof(vBatterie)}", typeof(vBatterie));

    }

	/// <summary>
	/// affiche les infos de l'appareil lancer
	/// </summary>
	public void Phone_info()
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"Modele : {DeviceInfo.Current.Model}");
		sb.AppendLine($"Manufacturer : {DeviceInfo.Current.Manufacturer}");
		sb.AppendLine($"Name : {DeviceInfo.Name}");
		sb.AppendLine($"VersionString : {DeviceInfo.Version}");
		sb.AppendLine($"Platforme : {DeviceInfo.Current.Platform}");

        lbPhoneInfo.Text = sb.ToString();

    }

	/// <summary>
	/// affiche le type de l'appareil utiliser
	/// </summary>
	public void Get_Idiom()
	{
        
        if (DeviceInfo.Current.Idiom == DeviceIdiom.Desktop)
        {
			lbPhoneInfo.Text += "Type : PC";
        }

		if (DeviceInfo.Current.Idiom == DeviceIdiom.Tablet)
        {
            lbPhoneInfo.Text += "Type : Tablette";
        }

        if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone)
        {
            lbPhoneInfo.Text += "Type : Téléphone";
        }

		
    }

    private async void Ecran_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(vEcran));
    }

    private async void Batterie_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(vBatterie));
    }
}