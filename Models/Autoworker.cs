using System;
using System.Collections.Generic;
using System.Text;

namespace car_factory
{
    class Autoworker
    {
        public string FirstName { get; set; } = "No name";
        public string LastName { get; set; } = "No name";

        public void Work()
        {
            Console.WriteLine("Just workin' my nine to five...");
        }
    }
}
