using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    using System;
    using System.Collections.Generic;

    public class RentalOffice
    {
        private List<Car> cars = new List<Car>();
        private Dictionary<Customer, Car> rentals = new Dictionary<Customer, Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void RentCar(Customer customer, string licensePlate)
        {
            Car car = cars.Find(c => c.LicensePlate == licensePlate && !c.IsRented);
            if (car != null)
            {
                car.IsRented = true;
                rentals[customer] = car;
                Console.WriteLine($"{customer.Name} rented {car.Model}.");
            }
            else
            {
                Console.WriteLine("Car not available.");
            }
        }

        public void ReturnCar(Customer customer)
        {
            if (rentals.TryGetValue(customer, out Car car))
            {
                car.IsRented = false;
                rentals.Remove(customer);
                Console.WriteLine($"{customer.Name} returned {car.Model}.");
            }
            else
            {
                Console.WriteLine($"{customer.Name} has no rented cars.");
            }
        }

        public void DisplayAvailableCars()
        {
            Console.WriteLine("Available cars:");
            foreach (var car in cars)
            {
                if (!car.IsRented)
                {
                    Console.WriteLine($"{car.Model} ({car.LicensePlate}) - {car.RentalPricePerDay} per day");
                }
            }
        }
    }

}
