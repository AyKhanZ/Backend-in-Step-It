using System;
using System.Windows;
using Weather.Models;
using Weather.Services;
namespace Weather.Views;
public partial class Home : Window
{
    public Forecast ForecastResult { get; set; } = new();
    public DeserializeService DeserializeService { get; set; } = new();
    public GetJsonService GetJsonService { get; set; } = new();
    public string? Search { get; set; }


    public Home()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        string? json = null;

        if (Search != null)
        {
            try
            {
                json = GetJsonService.GetWeatherJson(Search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        try
        {
            ForecastResult = DeserializeService.Deserialize<Forecast>(json);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}