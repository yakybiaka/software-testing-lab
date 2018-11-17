using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Framework.Utils
{
    class GettingTwoDaysAgoDate
    {
        public static DateTime date = DateTime.Now;
        public string twoDaysAgoDate = date.AddDays(-2).ToString("dd.MM.yyyy");
    }
}
