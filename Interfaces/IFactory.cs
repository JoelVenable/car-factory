using System;
using System.Collections.Generic;
using System.Text;

namespace car_factory.Interfaces
{
    public interface IFactory<T>
    {
        int MinimumEmployees { get; }
        int MaximumEmployees { get; }


        void HireEmployee(T employee);

        void HireEmployees(List<T> employees);

    }
}
