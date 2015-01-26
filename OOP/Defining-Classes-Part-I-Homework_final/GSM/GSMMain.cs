
namespace GSM
{
    using System;
    using System.Collections.Generic;
    

    class GSMMain
    {
        static void Main()
        {
            //HERE`S SOME TESTS, YOU CAN TRY. DOWN ARE THE TASKS!!!!!!!!!!!!!!!!

            //GSMDevice nokiaE71 = new GSMDevice("Nokia", "E71", 45, "Ivan");
            //Call nokiaE60 = new Call("0888136384", 54);
            ////Console.WriteLine(nokiaE71);
            //Console.WriteLine(nokiaE60);
            //// some test what happens
            //GSMDevice mygsm = new GSMDevice("E71", "Nokia");
            ////Console.Write("Phone manufacturer: {0}\nPhone model: {1}\nPhone price: {2}\nPhone owner: {3}", mygsm.Manufacturer, mygsm.Model, mygsm.Price, mygsm.Owner);
            ////mygsm.Battery.BatteryType = Battery.TypeBattery.NiMH;
            ////Console.WriteLine(nokiaE71.ToString());
            ////some other test
            ////add gsm properties directly
            //mygsm.Owner = "me";
            //mygsm.Price = 0; //no negative value check implemented int this property!
            //mygsm.Display.Size = 1000;
            //mygsm.Display.Colors = 2;
            //mygsm.Battery.HoursIdle = 1;
            //mygsm.Battery.HoursTalk = 1;
            //mygsm.Battery.Model = "who cares";
            ////Console.WriteLine(mygsm.Owner);
            ////....
            ////add new batery and than add it to the gsm
            //Battery mybaterry = new Battery();
            //mybaterry.Model = "blabla";
            //mybaterry.HoursIdle = 1;
            ////mybaterry.HoursTalk = 0;

            //mygsm.Battery = mybaterry;
            
            //Task7
            GSMDevice gsm1 = new GSMDevice("E71", "Nokia", 140.00M, "Ivan", new Display(3, 16000000), new Battery("Nokia Battery", 100, 10, Battery.TypeBattery.LiIon));

            GSMDevice gsm2 = new GSMDevice("V1", "All View");

            GSMDevice gsm3 = new GSMDevice("E60", "Nokia", 100, "Soni", new Display(), new Battery());

            GSMDevice[] gsmArray = new GSMDevice[] { gsm1, gsm2, gsm3 };

            foreach (var gsm in gsmArray)
            {
                Console.WriteLine(gsm);
            }

            //Display the information about the static property IPhone4S.
            Console.WriteLine(GSMDevice.IPhone4S);
            
            //Task12
            GSMDevice myGsm = new GSMDevice("E71", "Nokia");

            myGsm.AddCall("+359873432142", 53);
            myGsm.AddCall("+359811432142", 123);
            myGsm.AddCall("+359872412142", 41);
            myGsm.AddCall("+359833332142", 72);
            myGsm.AddCall("+359614432142", 231);



            myGsm.ShowCallHistory();

            Console.WriteLine("Total call price: " + myGsm.TotalCallPrice());

            //Remove the longest call from the history            
            myGsm.DelCall(5);
            Console.WriteLine("Removed Longest call!");

           
            
            //calculate the total price again
            Console.WriteLine("Total call price: " + myGsm.TotalCallPrice());

            //clear the call history and print it
            myGsm.ClearCallHistory();
                       
            myGsm.ShowCallHistory();

        }
    }
}
