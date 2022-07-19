using System;

namespace gldotnet.Models
{
    public class House
    {
        public House(int floors, int price, string color, string description, string image)
        {
            Id = Guid.NewGuid().ToString();
            Floors = floors;
            Price = price;
            Color = color;
            Description = description;
            Image = image;
        }
   
        public string Id { get; set; }
        public int Floors { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
    
}