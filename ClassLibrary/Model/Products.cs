using System;

namespace ClassLibrary.Model
{
    public class Products
    {
        private long id;
        private String name;
        private double price;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
    }
}
