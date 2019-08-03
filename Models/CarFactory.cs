using System;
using System.Collections.Generic;
using System.Text;
using car_factory.Interfaces;

namespace car_factory
{
    class CarFactory : IFactory<Autoworker>
    {
        public List<Autoworker> employees { get; set; } = new List<Autoworker>();

        public void HireEmployee(Autoworker employee)
        {
            employees.Add(employee);
        }
    }
}
