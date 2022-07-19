using System.Collections.Generic;
using gldotnet.Models;


namespace gldotnet.db
{
    public class FakeDb
    {
        public static List<Car> Cars { get; set; } = new List<Car>(){
            new Car("Fiat"),
            new Car("Ford"),
            new Car("Chevrolet"),
            new Car("Dodge")

            
        };
    }
}