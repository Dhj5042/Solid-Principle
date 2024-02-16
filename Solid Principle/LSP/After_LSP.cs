namespace SolidPrincipalsDemo.LSP
{
    // Base interface representing a vehicle
    interface IVehicle
    {
        void Drive();
    }

    // Base class representing a generic car
    class Car : IVehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }

    // Derived class representing an electric car
    class ElectricCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving an electric car.");
        }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging the battery of an electric car.");
        }
    }

}
