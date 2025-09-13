using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the classes
        Vehicle myVehicle = new Vehicle();
        Car myCar = new Car();
        Boat myBoat = new Boat();

        myCar.Model = "BMW";
        myBoat.Model = "Sea";

        // Call Go method
        myVehicle.Go();
        Console.WriteLine("My car is a " + myCar.Model + " and has " + myCar.Wheels + " wheels.");
        myBoat.Go();
        Console.WriteLine("My boat is a " + myBoat.Model + " and has " + myBoat.Wheels + " wheels.");
    }
}

