using System.Text;

namespace TestMauiApp1.Views;

public partial class vEcran : ContentPage
{
	public vEcran()
	{
		InitializeComponent();
		ecran_Infos();
	}

	public void ecran_Infos()
	{
		StringBuilder sb = new StringBuilder();

		sb.AppendLine($"\nResolution : Height {DeviceDisplay.Current.MainDisplayInfo.Height}, Width {DeviceDisplay.Current.MainDisplayInfo.Width} ");
        sb.AppendLine($"Densité : {DeviceDisplay.Current.MainDisplayInfo.Density}");
        sb.AppendLine($"Orientation : {DeviceDisplay.Current.MainDisplayInfo.Orientation}");
        sb.AppendLine($"Vitesse : {DeviceDisplay.Current.MainDisplayInfo.Rotation}");

		lbEcranInfo.Text = sb.ToString();
    }
}