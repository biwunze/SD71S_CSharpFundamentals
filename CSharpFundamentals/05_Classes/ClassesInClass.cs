using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesInClass
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookies cookie = new Cookies();
            cookie.NameOfCookie = "Cocoa Chip";
            cookie.HasPeanuts = false;
            cookie.GramsOfSugar = 10;

            Cookies littleCookie = new Cookies();
            littleCookie.NameOfCookie = "Mini cookies";
            cookie.HasPeanuts = true;
            cookie.GramsOfSugar = 8;
        }

        [TestMethod]
        public void VehicleTest()
        {
            Vehicles car = new Vehicles();
            car.TypeOfVehicles = VehicleTypes.Coupe;
        }
    }
}
