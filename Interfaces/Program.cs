using Interfaces.Entityes;
using Interfaces.Services;
using System;


namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            MockLocation();
            
        }

        private static void MockLocation()
        {
            Vehicle vehicle = new("Vectra");
            CarRental carRental = new(DateTime.Now, DateTime.Now.AddHours(4.1), vehicle);
            RentalService rentalService = new(10, 130, new BrasilTaxService());
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("Invoice:\n"+carRental.Invoice);

            Vehicle vehicle2 = new Vehicle("Vectra");
            CarRental carRental2 = new(
                new DateTime(2018, 06, 25, 10, 30, 00),
                new DateTime(2018, 06, 27, 11, 40, 00), vehicle2);
            RentalService rentalService2 = new(10, 130, new BrasilTaxService());
            rentalService2.ProcessInvoice(carRental2);
            Console.WriteLine("Invoice:\n"+carRental2.Invoice);

        }
    }
}
