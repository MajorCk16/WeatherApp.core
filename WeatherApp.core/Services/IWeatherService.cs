using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.core.Services
{
	interface IWeatherService
	{
		Task<WeatherInfo.RootObject> GetWeatherAsync(String Location);
	}
}
