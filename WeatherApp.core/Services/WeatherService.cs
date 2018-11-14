using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.core.Services
{
	class WeatherService : IWeatherService
	{
		const string WBase="https://api.openweathermap.org/data/2.5/weather?q=";
		const string AppID = "&appid=4c3173a69df39b2c40c66cff3f0a3ec7&units=metric";
		HttpClient httpClient;

		WeatherService() {
			httpClient = new HttpClient();
		}


		public async Task<WeatherInfo.RootObject> GetWeatherAsync(string Location)
		{
			WeatherInfo.RootObject result = null;

			var Url = WBase + Location + AppID;

			try
			{
				var json = await httpClient.GetAsync(Url);

				if (json.IsSuccessStatusCode)
				{
					var jsonRaw = await json.Content.ReadAsStringAsync();
					result = JsonConvert.DeserializeObject<WeatherInfo.RootObject>(jsonRaw);
				}

			}
			catch (System.Exception) { }
			return result;
							   
			
		}
	}
}
