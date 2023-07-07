using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CashRegister
{
    internal class History
    {
        List<DateFromWhereHowMuch> List = new List<DateFromWhereHowMuch>();


        public void ToJson(List<DateFromWhereHowMuch> list)
        {
            // -------------------------------------------------------- To JSON ------------------------------------------------------
            #region Write Json

            var json = JsonSerializer.Serialize(list);
            bool check = File.Exists("History_now.json");
            if (!check)
            {
                var i = File.Create("History_now.json");
                i.Close();
            }
            FileStream f = new FileStream("History_now.json", FileMode.Truncate);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine(json);

            s.Close();
            f.Close();
            #endregion
        }

        public void ShowHistory()
        {
            FileStream fs = new("History_now.json", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string? jsonline = sr.ReadToEnd();
            if (jsonline != null)
            {
                if (jsonline.Length > 0) List = JsonSerializer.Deserialize<List<DateFromWhereHowMuch>>(jsonline);
                else
                {
                    Console.WriteLine("History is empty!");
                    return;
                }
            }
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - <<< History >>> - - - - - - - - - - - - - - - - - - ");
            foreach (var item in List)
            {
                Console.WriteLine($"------------------------------------------" +
                                  $"\nDate:  {item.date}\nFrom valute:  {item.from}\nHow much:  {item.HowMuch}\nTo:  {item.where}\nResult:  {item.result}\n");
            }
            sr.Close();
            fs.Close();

        }
    }
}
