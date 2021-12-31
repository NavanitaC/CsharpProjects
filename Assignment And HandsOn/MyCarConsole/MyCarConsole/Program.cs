using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        /* int value1 = 100;
            string value2 = value1.ToString();
            string mymsg = "Welcome";
            int value3 = 200;
            object value4 = value3;
            int value5 = Convert.ToInt32(value4);  */
         

            Maruti marutiObj=new Maruti();    //object creation
                                              // string resultstr=marutiObj.BreakDetails();    function call or access class methods
                                              // Console.WriteLine(resultstr);
            Console.WriteLine(marutiObj.EngineConfigVersion);
            marutiObj.BreakDetails();
            marutiObj.CarModels("Swift",100);


            Swift swiftObj = new Swift();
            swiftObj.DisplaySwiftModelDetails();
            swiftObj.BreakDetails();
            swiftObj.CarModels("Alto",2021);

            SwiftDezire swiftDezireObj = new SwiftDezire();
            swiftDezireObj.data();
            Console.ReadKey();


        }
    }
}
