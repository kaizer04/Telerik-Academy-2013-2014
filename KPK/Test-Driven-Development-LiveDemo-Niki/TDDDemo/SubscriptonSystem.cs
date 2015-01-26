using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDDemo
{
    class SubscriptonSystem
    {
        public ICollection<User> Users { get; set;}
        private ILogger logger;

        public SubscriptonSystem(ILogger logger)
        { 
            this.Users = new List<User>();
            this.logger = logger;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        internal void Subscribe(User user)
        {
            this.Users.Add(user);
        }

        internal void Charge(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException();         
            }

            foreach (var user in this.Users) 
            {
                user.Balance += amount;
            }

            logger.Log(amount.ToString());
        }
    }
}
