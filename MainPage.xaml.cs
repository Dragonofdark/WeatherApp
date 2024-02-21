namespace WeatherApp;

public partial class MainPage : ContentPage
{
    readonly RestService _restService;

	public MainPage()
	{
         InitializeComponent();
		_restService = new RestService();
	}

	async void OnGetWeatherButtonClicked(object sender,EventArgs e) {
		if (!string.IsNullOrWhiteSpace(_cityEntry.Text)) {
			Clima weatherData = await 
				_restService.
				GetWeatherData(GenerateRequestURL(Constantes.OpenWeatherMapEndpoint));

            BindingContext = weatherData;
		}
	}

	string GenerateRequestURL(string endPoint) {
		string requestUri = endPoint;
		requestUri += $"?q={_cityEntry.Text}";
		requestUri += "&units=imperial";
		requestUri += $"&APPID={Constantes.OpenWeatherMapAPIKey}";
		return requestUri;
	}
}

