using Application_Kassa;
using System.Text.Json;


namespace Program
{
    class Program
    {
        public static void Main()
        {

            UI ui = new UI();
            using FileStream fs = new("JsonFile.json", FileMode.OpenOrCreate);
            using StreamReader sr = new StreamReader(fs);
            string jsonline = sr.ReadToEnd();
            if (jsonline != null)  ui.management.Goods = JsonSerializer.Deserialize<List<Good>>(jsonline);
 

            while (ui.Flag)
            {
                ui.ShowOptions();
            }
        }
    }
}
