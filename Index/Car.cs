using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    public class Car
{
    public string Model { get; set; }
    public string LicensePlate { get; set; }
    public decimal RentalPricePerDay { get; set; }
    public bool IsRented { get; set; }

    public Car(string model, string licensePlate, decimal rentalPricePerDay)
    {
        Model = model;
        LicensePlate = licensePlate;
        RentalPricePerDay = rentalPricePerDay;
        IsRented = false;
    }
}

}
