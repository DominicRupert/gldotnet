using System;


namespace gldotnet.Models
{
    public class Car
    {
        public Car(string make, int price, string color, int year, string description, string image)
        {
            Id = Guid.NewGuid().ToString();
            Make = make;

            Price = price;
            Year = year;
            Color = color;
            Description = description;
            Image = image;
        }








        public string Id { get; set; }
        public string Make { get; set; }


        public int Price { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}