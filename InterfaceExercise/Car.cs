using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : iVehicle, iCompany
    {
        public Car ()
        {

        }
        public double EngineSize { get; set; } = 5.8;
        public string Make { get; set; } = "Chevy";
        public string Model { get; set; } = "Nova";
        public int SeatCount { get; set; } = 2;
        public string CompanyName { get; set; } = "Chevrolet";
        public string Motto { get; set; } = "Like a rock";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
        }
        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
            
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }

        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
