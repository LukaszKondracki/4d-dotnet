public record WeatherRequestModel(string City, List<WeatherRequestInstance> Instances);

public record WeatherRequestInstance(string Day, decimal Temperature, string Weather);