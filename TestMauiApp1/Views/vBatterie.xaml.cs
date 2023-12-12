namespace TestMauiApp1.Views;

public partial class vBatterie : ContentPage
{
	public vBatterie()
	{
		InitializeComponent();
		Battery.Default.BatteryInfoChanged += Battery_InfoChanged;
		Battery.Default.EnergySaverStatusChanged += Battery_ModeEcoChanged;

    }	

    private void Afficher(object sender, EventArgs e)
    {
		string bat = "";
		var batterie = Battery.Default.PowerSource;

		switch (batterie)
		{
			case BatteryPowerSource.AC:
				bat = "AC 220V";
				break;

			case BatteryPowerSource.Usb:
				bat = "Câble USB";
				break;

			case BatteryPowerSource.Wireless:
				bat = "Chargeur sans fil";
				break;
			case BatteryPowerSource.Battery:
				bat = "Sur Batterie";
				break;
			default: 
				bat = "Unknown"; break;
				
		}

		lbalimentation.Text = bat;
    }

	private void Battery_InfoChanged(object sender, BatteryInfoChangedEventArgs e )
	{
		string etatbat = "";

        if (e.State == BatteryState.Charging )
        {
			etatbat = $"Batterie en charge \n Batterie chargée à {e.ChargeLevel * 100}%";
        }
		if (e.State == BatteryState.Discharging)
        {
			etatbat = $"Batterie déchargée \nBatterie chargée à{e.ChargeLevel * 100}%";
        }
        if (e.State == BatteryState.Full)
        {
			etatbat = $"Batterie Pleine \nBatterie chargée à{e.ChargeLevel * 100} %";
        }

		lbetatbatterie.Text = etatbat;
    }

	private async void Battery_ModeEcoChanged(object sender, EnergySaverStatusChangedEventArgs e)
	{
		string eco = "";

        if (Battery.Default.EnergySaverStatus == EnergySaverStatus.On)
        {
			eco = " Mode Eco Activé";
        }
		await DisplayAlert("Alert", eco, "ok");
    }
}