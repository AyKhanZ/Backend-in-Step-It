using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class CashRegisterService
    {
        private string api_key = "c27933953c-5635c4f831-rjspgj";
        public string GetCashRegister()
        {
            string url = $"https://api.fastforex.io/fetch-all?api_key={api_key}";

            WebClient client_ = new();

            var result = client_.DownloadString(url);
            return result;
        }
    }
}