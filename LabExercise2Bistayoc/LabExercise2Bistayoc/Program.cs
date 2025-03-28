using System;

namespace LabExercise2Bistayoc
{
    // Base class: Shoes
    class Shoes
    {
        // Private fields (Encapsulation)
        private string brand;
        private int size;
        private string priceRange;

        // Constructor
        public Shoes(string brand, int size, string priceRange)
        {
            this.brand = brand;
            this.size = size;
            this.priceRange = priceRange;
        }

        // Getters and Setters
        public string GetBrand() { return brand; }
        public void SetBrand(string brand) { this.brand = brand; }

        public int GetSize() { return size; }
        public void SetSize(int size) { this.size = size; }

        public string GetPriceRange() { return priceRange; }
        public void SetPriceRange(string priceRange) { this.priceRange = priceRange; }

        // Public method
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Brand: {brand}, Size: {size}, Price Range: {priceRange} PHP");
        }
    }

    // Derived class (Inheritance)
    class SportsShoes : Shoes
    {
        // Additional field
        private string sportType;

        // Constructor
        public SportsShoes(string brand, int size, string priceRange, string sportType)
            : base(brand, size, priceRange)
        {
            this.sportType = sportType;
        }

        // New method specific to SportsShoes
        public void ShowSportType()
        {
            Console.WriteLine($"This shoe is designed for {sportType}.");
        }

        // Method overriding
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Sport Type: {sportType}");
        }
    }

    // Main method to demonstrate functionality
    class Program
    {
        static void Main()
        {
            // Creating objects with Philippine Peso price ranges
            SportsShoes runningShoes = new SportsShoes("Nike", 10, "5,000 - 10,500", "Running");
            SportsShoes basketballShoes = new SportsShoes("Under Armour", 11, "6,500 - 9,000", "Basketball");
            SportsShoes trainingShoes = new SportsShoes("Converse", 9, "3,500 - 5,500", "Training");

            // Displaying details of each shoe
            runningShoes.DisplayDetails();
            runningShoes.ShowSportType();

            Console.WriteLine(); // Line break for clarity

            basketballShoes.DisplayDetails();
            basketballShoes.ShowSportType();

            Console.WriteLine();

            trainingShoes.DisplayDetails();
            trainingShoes.ShowSportType();
        }
    }

}