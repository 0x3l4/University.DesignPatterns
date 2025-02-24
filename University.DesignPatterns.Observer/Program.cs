//Необходимо разработать ПО для метеостанции.
//Она работает с использованием класса WeatherData, поставляемый в исходниках.
//Метеостанция отслеживает три параметра (Температура, Давление, Влажность).
//Нужно создать приложение, которое отображает три визуальных элемента.
//текущую сводку
//статистику погоды
//простой прогноз  
//	Данные обновляются в Real-time.
//	Кроме того необходимо предусмотреть возможность расширения,
//	определить API, чтобы другие разрабы могли писать собственные UI-элементы и подключать их к приложению
// Класс WeatherData содержит get-методы для считывания показания трёх датчиков

namespace University.DesignPatterns.Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            var statisticDisplay = new StatisticDisplay(weatherData);
            currentConditionDisplay.Subscribe();
            statisticDisplay.Subscribe();
            SetRandomWeather(weatherData);
        }

        public static void SetRandomWeather(WeatherData weatherData, int count = 1000)
        {
            float minTemperature = -40;
            float maxTemperature = 40;
            float minHumidity = 0;
            float maxHumidity = 100;
            float minPressure = 730;
            float maxPressure = 760;
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(500);
                Console.Clear();
                weatherData.SetMeasurements(
                    (float)(minTemperature + (float)(maxTemperature - minTemperature) * random.NextDouble()),
                    (float)(minHumidity + (float)(maxHumidity - minHumidity) * random.NextDouble()),
                    (float)(minPressure + (maxPressure - minPressure) * random.NextDouble()));
            }
        }
    }
}
