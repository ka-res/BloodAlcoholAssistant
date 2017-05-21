namespace BloodAlcoholAssistant.Converters
{
    public class ResultToText
    {
        public static string GetResultValue(double value)
        {
            return double.IsNaN(value) 
                ? "Nie można obliczyć żądanej wartości... ¯\\_(ツ)_/¯" 
                : $"Zawartośc alkoholu w Twojej krwi to około {value} [promil]";
        }
    }
}