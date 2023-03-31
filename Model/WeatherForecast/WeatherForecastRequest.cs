using MediatR;

namespace CQRSTest.Model.WeatherForecast
{
    public record WeatherForecastRequest:IRequest<IEnumerable<WeatherForecast>>
    {
        private WeatherForecastRequest() { }

        public static readonly WeatherForecastRequest Instane = new();
    }
}
