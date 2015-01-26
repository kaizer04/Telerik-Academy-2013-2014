
using System;
using System.Text;
namespace GSM
{
   
    //task8
    class Call
    {
        //private fields
        private DateTime dateTime;
        private string phoneNumber;
        private int duration;

        //the only constructor - phonenumber and duaration needed
        public Call(string phoneNumber, int duration)
        {
            this.dateTime = DateTime.Now;//setting the private field (there is no setter)
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        //property DateTime (readonly - setted in the constructor when instance is created (with DateTime.Now())
        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
        }

        //property PhoneNumber
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Phonenumber can not be null or empty!");
                }
                //if ((value.Length != 10 && value.Length != 13) || (value[0] != '0' && value[0] != '+'))
                //{
                //    throw new ApplicationException("Phonenumber must be in format +359xxxxxxxxx OR 0xxxxxxxxx !");
                //}
                this.phoneNumber = value;
            }
        }

        //property Duaration
        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ApplicationException("Duaration can not be a negative number!");
                }
                this.duration = value;
            }
        }

        //better view for each call
        public override string ToString()
        {
            StringBuilder strCreator = new StringBuilder();
            strCreator.AppendFormat("Call with {0} : {1} sec on {2}", this.phoneNumber, this.duration, this.dateTime);
            strCreator.AppendLine();
            
            return strCreator.ToString();
        }
    }
}
