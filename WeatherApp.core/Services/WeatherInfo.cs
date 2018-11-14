using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherApp.core.Services
{
	public class WeatherInfo
	{

		public class Coord
		{
			[JsonProperty(PropertyName = "lon")]
			public double Longitude { get; set; }

			[JsonProperty(PropertyName = "lat")]
			public double Latitude { get; set; }
		}

		public class Weather
		{
			[JsonProperty(PropertyName = "id")]
			public int Id { get; set; }

			[JsonProperty(PropertyName = "main")]
			public string Main { get; set; }

			[JsonProperty(PropertyName = "description")]
			public string Description { get; set; }

			[JsonProperty(PropertyName = "icon")]
			public string Icon { get; set; }
		}

		public class Main
		{
			[JsonProperty(PropertyName = "temp")]
			public double Temperature { get; set; }

			[JsonProperty(PropertyName = "pressure")]
			public double Pressure { get; set; }

			[JsonProperty(PropertyName = "humidity")]
			public int Humidity { get; set; }

			[JsonProperty(PropertyName = "temp_min")]
			public double MinTemperature { get; set; }

			[JsonProperty(PropertyName = "temp_max")]
			public double MaxTemperature { get; set; }

			[JsonProperty(PropertyName = "sea_level")]
			public double SeaLevel { get; set; }

			[JsonProperty(PropertyName = "grnd_level")]
			public double GroundLevel { get; set; }
		}

		public class Wind
		{
			[JsonProperty(PropertyName = "speed")]
			public double Speed { get; set; }

			[JsonProperty(PropertyName = "deg")]
			public long Degrees { get; set; }
		}

		public class Clouds
		{
			[JsonProperty(PropertyName = "all")]
			public int All { get; set; }
		}

		public class Sys
		{

			[JsonProperty(PropertyName = "message")]
			public double Message { get; set; }

			[JsonProperty(PropertyName = "country")]
			public string Country { get; set; }

			[JsonProperty(PropertyName = "sunrise")]
			public long Sunrise { get; set; }

			[JsonProperty(PropertyName = "sunset")]
			public long Sunset { get; set; }

		}

		public class RootObject
		{

			[JsonProperty(PropertyName = "coord")]
			public Coord Coordinate { get; set; }
			[JsonProperty(PropertyName = "sys")]
			public Sys Sys { get; set; }
			[JsonProperty(PropertyName = "weather")]
			public List<Weather> Weather { get; set; }
			[JsonProperty(PropertyName = "@base")]
			public string Base { get; set; }
			[JsonProperty(PropertyName = "main")]
			public Main Main { get; set; }
			[JsonProperty(PropertyName = "wind")]
			public Wind Wind { get; set; }
			[JsonProperty(PropertyName = "clouds")]
			public Clouds Clouds { get; set; }
			[JsonProperty(PropertyName = "dt")]
			public int Lastupdate { get; set; }
			[JsonProperty(PropertyName = "id")]
			public int Id { get; set; }
			[JsonProperty(PropertyName = "name")]
			public string Name { get; set; }
			[JsonProperty(PropertyName = "cod")]
			public int Cod { get; set; }

		}
	}
}