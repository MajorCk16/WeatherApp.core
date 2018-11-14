using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using WeatherApp.core.Services;

namespace WeatherApp.core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
			Mvx.RegisterType<IWeatherService, WeatherService>();


#pragma warning disable CS0618 // Type or member is obsolete
			RegisterAppStart<ViewModels.MainViewModel>();
#pragma warning restore CS0618 // Type or member is obsolete
		}
    }
}
