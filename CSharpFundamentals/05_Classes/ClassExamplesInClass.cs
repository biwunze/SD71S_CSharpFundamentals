using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookies
    {                                                 //Property is a variable for a class
        public string NameOfCookie { get; set; }      //These are methods.  get= to get the value of name; set= to set, change or modify the value of name
        public bool HasPeanuts { get; set; }
        public double GramsOfSugar { get; set; }
        public int Calories { get; set; }
    }

    public enum VehicleTypes { Car, Van, Coupe, Convertible, Jet, Boat}

    public class Vehicles
    {
        public string Make { get; set; }
        public string Model { get; set; }
        /*public double Mileage { get; set }*/
        public string Color { get; set; }
        public int Year { get; set; }
        public VehicleTypes TypeOfVehicles { get; set; }        //Have to pick from the VehicleTypes
    }

    public class Orders
    {
        public int CustomerValueAccount { get; set; }
        public Cookies CookieOrder { get; set; }
        public decimal CostForOrder { get; set; }
    }
}
