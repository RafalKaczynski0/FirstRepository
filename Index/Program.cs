using Index;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        RentalOffice rentalOffice = new RentalOffice();

        rentalOffice.AddCar(new Car("Toyota Camry", "XYZ123", 50));
        rentalOffice.AddCar(new Car("Ford Focus", "ABC456", 40));
        rentalOffice.AddCar(new Car("BMW 3 Series", "LMN789", 70));

        Customer customer1 = new Customer("John Doe", "D123456");
        Customer customer2 = new Customer("Jane Smith", "D987654");

        rentalOffice.DisplayAvailableCars();

        rentalOffice.RentCar(customer1, "XYZ123");
        rentalOffice.RentCar(customer2, "ABC456");

        rentalOffice.DisplayAvailableCars();

        rentalOffice.ReturnCar(customer1);
        rentalOffice.DisplayAvailableCars();
    }
}
