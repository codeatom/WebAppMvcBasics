using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcBasics.Models
{
    public class BodyTemperature
    {
        public static string TemperatureStatus(string temp)
        {
            bool isDouble = false;
            double bodyTemp = 0.0;
            string status = "";

            isDouble = double.TryParse(temp, out bodyTemp);


            if (isDouble && bodyTemp >= 37.5)
            {
                status = "Your temperature is above normal levels!";
            }
            else if (isDouble && bodyTemp < 36.5)
            {
                status = "Your temperature is below normal levels!";
            }
            else
            {
                status = "Your temperature is normal";
            }

            return status;
        }
    }
}
