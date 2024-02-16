namespace SolidPrincipalsDemo.LSP
{

    // Base class representing a generic car
    class BeforeCar
    {
        public virtual void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }

    // Derived class representing an electric car
    class BeforeElectricCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Driving an electric car.");
        }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging the battery of an electric car.");
        }
    }
}
