using System.ComponentModel.DataAnnotations;

namespace CustomBadRequestSample
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

     
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Required(ErrorMessage = "Required is Summary ")]
        public string Summary { get; set; }
    }
}