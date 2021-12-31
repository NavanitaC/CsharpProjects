using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarConsole
{
    public class Maruti
    {
        public string EngineConfigVersion = "1.0";
        private string EngineConfigDetails = "2x.10.0";
         public void BreakDetails()
         {
            Console.WriteLine(EngineConfigDetails);
            string breaksystem = "Complex";
            string breakversion = "1.0";
            string breakType = "ABS";
            //return breaksystem +  breakversion + breakType;
            Console.WriteLine(breaksystem + breakversion + breakType);
         }

         public void CarModels(string ModelType, int modelyear)
         {
            Console.WriteLine("Model Type: " + ModelType);
            Console.WriteLine("Model Year: " + modelyear);
         }

        public void data()
        {

        }
    }
}
