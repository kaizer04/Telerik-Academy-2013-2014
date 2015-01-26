
using System;
namespace GSM
{
    public class Battery
    {
        private string model = null;
        private int hoursIdle;
        private int hoursTalk;
        //Task 3
        private TypeBattery batteryType;

        public enum TypeBattery
        {
            LiIon, NiMH, NiCd, LiPo
        }

        //Task5
        public string Model
        {
            get 
            { 
                return this.model; 
            }
            set 
            { 
                this.model = value; 
            }
        }

        public int HoursIdle
        {
            get 
            { 
                return this.hoursIdle; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ApplicationException("Hours of talk time must be > 0!");
                }
                this.hoursIdle = value; 
            }
        }

        public int HoursTalk
        {
            get 
            { 
                return this.hoursTalk; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ApplicationException("Hours of talk time must be > 0!");
                }
                this.hoursTalk = value; 
            }
        }

        //Task2
        public Battery()
        {
        }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, int hoursIdle)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
        }

        public Battery(string model, int hoursIdle, int hoursTalk)
            : this(model, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        //Task 3
        public Battery(string model, int hoursIdle, int hoursTalk, TypeBattery batteryType)
            : this(model, hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
        }

        //property BatteryType - Task3
        public TypeBattery BatteryType
        {
            get  
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
    }
}
