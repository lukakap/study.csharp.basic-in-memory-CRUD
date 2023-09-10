namespace BasicCRUDOperations
{
    public class Product
    {
        private string _name;
        private double _price;

        public string Id { get; private set; }

        public string Name 
        {
            get { return _name; }
            
            set 
            {
                if (string.IsNullOrEmpty(value))
                { 
                    throw new ArgumentNullException("invalid argument for name");
                }
                _name = value;  
            }
        }

        public double Price
        {
            get { return _price; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid argument for price");
                }
                _price = value;
            }
        }

        // constructor
        public Product(string id, string name, double price) 
        { 
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID - {Id} | NAME - {Name} | PRICE - {Price:C2}";
        }
    }
}
