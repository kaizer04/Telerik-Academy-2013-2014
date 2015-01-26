
namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSMDevice
    {
        Display display = new Display();
        Battery battery = new Battery();
        
        //Task11
        private const decimal pricePerMinute = 0.37m;

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        //private Battery battery;
        //private Display display;
        
        //Task9
        private List<Call> callHistory;


        //Task6
        private static GSMDevice iPhone4S = new GSMDevice("IPhone 4S", "Apple", 1300.00m, "Stoyan Ganchev", new Display(5, 16000000),
                                                    new Battery("Apple", 8, 200, Battery.TypeBattery.LiPo));

        //Task 2
        public GSMDevice(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;

            this.callHistory = new List<Call>();
        }

        public GSMDevice(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSMDevice(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSMDevice(string model, string manufacturer, decimal price, string owner, Display display, Battery battery)
            : this(model, manufacturer, price, owner)
        {
            this.Display = display;
            this.Battery = battery;

            //this.callHistory = new List<Call>();
        }

        //Task5
        public Display Display
        {
            get 
            { 
                return this.display; 
            }
            set 
            { 
                this.display = value; 
            }
        }
        
        public Battery Battery
        {
            get 
            { 
                return this.battery; 
            }
            set 
            { 
                this.battery = value; 
            }
        }

        public string Model
        {
            get 
            { 
                return this.model; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Model can NOT be null or empty!");
                }
                this.model = value; 
            }
        }
        
        public string Manufacturer
        {
            get 
            { 
                return this.manufacturer; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Manufacturer can NOT be null or empty!");
                }
                this.manufacturer = value; 
            }
        }
        
        public decimal Price
        {
            get 
            { 
                return this.price; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ApplicationException("Price can NOT be a negative number!");
                }
                this.price = value; 
            }
        }
        
        public string Owner
        {
            get 
            { 
                return this.owner; 
            }
            set
            {
                this.owner = value;
            }
        }

        //Task6
        public static GSMDevice IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }
        
        //Task4
        public override string ToString()
        {
            StringBuilder strCreator = new StringBuilder();
            strCreator.Append("GSM Specifications:");
            strCreator.AppendLine(" ");
            strCreator.AppendFormat("GSM Model: {0}", this.model);
            strCreator.AppendLine();
            strCreator.AppendFormat("GSM Manufacturer: {0}", this.manufacturer);
            strCreator.AppendLine();
            strCreator.AppendFormat("GSM Price: {0}", this.price);
            strCreator.AppendLine();
            strCreator.AppendFormat("GSM Owner: {0}", this.owner);
            strCreator.AppendLine();
            strCreator.AppendFormat("GSM Battery Specifications: \nModel: {1} \nType: {0} \nTalk time: {2} \nIdle time: {3}"
                          , this.Battery.BatteryType, this.Battery.Model, this.Battery.HoursTalk, this.Battery.HoursIdle);
            strCreator.AppendLine();
            strCreator.AppendFormat("GSM Display Specifications: \nSize: {0} \nNumber of Colors: {1}",
                            this.Display.Size, this.Display.Colors);
            strCreator.AppendLine();
            
            return strCreator.ToString();
        }
        
        //Task10
        //add call method 
        public void AddCall(string currPhoneNumber, int currDuaration)
        {
            this.callHistory.Add(new Call(currPhoneNumber, currDuaration));
        }

        //remove call - takes a position from the ShowcallHistoryMethod - starts count from 1 not 0 for more user friendly interface
        public void DelCall(int position)
        {
            if ((position - 1 < 0) || (this.callHistory.Count <= position - 1))
            {
                throw new ApplicationException("No call on this position!");
            }
            this.callHistory.RemoveAt(position - 1);
        }
        
        public void ShowCallHistory()       //This metod is a part of Task12
        {
            Console.WriteLine("Current call history:");
            int indexer = 1;
            foreach (var called in this.callHistory)
            {
                Console.Write(indexer++);
                Console.Write(" ---> ");
                Console.WriteLine(called.ToString());
            }
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        //Task11
        public decimal TotalCallPrice()
        {
            int allCallDuration = 0;
            foreach (var call in this.callHistory)
            {
                allCallDuration += call.Duration;
            }

            return allCallDuration * pricePerMinute / 60;      //Duration is in seconds, that`s why, we need to divide pricePerMinute to 60 secs
        }
    }
}
