using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace _4d_dotnet.Controllers;

public class WeatherController : Controller
{
    public IActionResult Index()
    {
        var model = new WeatherModel
        {
            MeasurementTime = TimeOnly.FromDateTime(DateTime.Now),
            Instances = new List<WeatherInstance> {
                new WeatherInstance("Wrocław", 28.7, "deszcz"),
                new WeatherInstance("Warszawa", 25.0, "słonecznie"),
                new WeatherInstance("Kraków", 19.9, "pochmurnie"),
                new WeatherInstance("Gdynia", 30.1, "słonecznie"),
            }
        };

        return View(model);
    }

    public IActionResult Request([FromQuery] string city) {

        var weathers = new[] {
            "descz",
            "słońce",
            "zachmurzenie",
            "mgła",
            "przelotny deszcz",
            "lekkie zachmurzenie"
        };

        var instances = Enumerable.Range(0, 6)
            .Select(v => new WeatherRequestInstance(
                CultureInfo.CurrentCulture.DateTimeFormat.DayNames[v],
                Random.Shared.Next(200, 300) / 10m,
                weathers[Random.Shared.Next(0, weathers.Length - 1)]
            ))
            .ToList();

        var model = new WeatherRequestModel(city, instances);

        return View(model);
    }
}
