using System;
using System.Collections.Generic;

namespace algoexpert_tv.Workers
{
    public class Hostess
    {
        private List<string> _defaultWelcomeGreetingsList = new List<string> {
            "Howdy", "Yo", "Your Greatness", "Hello"
        };
        private string _customWelcomeGreeting;

        private string welcomeGreeting { get
            {
                if (_customWelcomeGreeting.Length > 0)
                {
                    return _customWelcomeGreeting;
                }
                else
                {
                    var random = new Random();
                    var randomIndex = random.Next(_defaultWelcomeGreetingsList.Count);
                    return _defaultWelcomeGreetingsList[randomIndex];
                }
            }
        }

        public Hostess(string personalWelcomeGreeting = "")
        {
            if (personalWelcomeGreeting != null)
            {
                _customWelcomeGreeting = personalWelcomeGreeting;
            }
        }

        public void OpenGreeting()
        {
            Console.WriteLine(welcomeGreeting);
        }
    }
}
