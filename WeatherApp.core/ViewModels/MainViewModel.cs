using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using WeatherApp.core.Services;

namespace WeatherApp.core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
		MvxAsyncCommand GoButtonCommand { get; }
		private readonly IWeatherService _weatherService;
		private readonly IMvxNavigationService _navigationservice;




		public MainViewModel(IWeatherService weatherService, IMvxNavigationService navigationservice)
		{

			_navigationservice = navigationservice;
			_weatherService = weatherService;

			GoButtonCommand = new MvxAsyncCommand(btnCommand, btnSwitch);
        }

		


		public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }


		private string _location;
		public string Location
		{
			get => _location;
			set => SetProperty(ref _location, value);
			//btnSwitch
		}

		async Task btnCommand() {

			try
			{
				var Result = await _weatherService.GetWeatherAsync(Location);
				if (Result != null) {
					
				}

			}
			catch (System.Exception) { }

		}



	}
}