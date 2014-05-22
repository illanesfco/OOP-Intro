using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP
{
    public class Greeter
    {
        #region Fields and Properties
        // traditional Field + Property combination
        //Field
        private string _GreetingMessage;
        //Property
        public string GreetingMessage                                                                                                                                                                                  
        {
            get
            {
                return _GreetingMessage;
            }
            private set
            {
                _GreetingMessage = value;
            }
        }

        // Auto-implemented Property (field as a "backing store" is "auto-generated")
        public string FarewellMessage { get; private set; }
        #endregion

        #region Constructors
        //Constructor
        public Greeter(string greeting, string farewell)
        {
            GreetingMessage = greeting;
            FarewellMessage = farewell;
        }
        #endregion

        #region Methods
        //Method
        public string SayGreeting(string name)
        {
            return name + ", " + GreetingMessage;
        }

        //Method
        public string SayGreeting()
        {
            return GreetingMessage;
        }

        //Method
        public string SayGoodbye(string name)
        {
            return name + " - " + FarewellMessage;
        }

        //Method
        public string SayGoodbye()
        {
            return FarewellMessage;
        }
        #endregion
    }
}
