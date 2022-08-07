namespace CarManufacturer
{
    class Car
    {
        public Car()
        {

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            var consumtion = distance * (FuelConsumption / 100);
            if (consumtion <= FuelQuantity)
            {
                FuelQuantity -= consumtion;
            }
            else
            {
                System.Console.WriteLine($"Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}";
        }
    }
}