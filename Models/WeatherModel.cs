public class WeatherModel {
    public TimeOnly MeasurementTime { get; set; }
    public List<WeatherInstance> Instances { get; set; }
}

public record WeatherInstance(string City, double Temperature, string Weather);